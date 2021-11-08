using Databinding_DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databinding_WPF.ViewModels
{
    public class BindingNaarObjectViewModel : BasisViewModel
    {
        public BindingNaarObjectViewModel()
        {
            Producten = new ObservableCollection<Product>(DatabaseOperations.OphalenProducten());
            OrderlijnRecordInstellen();
            ComboboxEnabled = true;
        }


        //tekstveld OrderID
        private string _orderID;

        //combobox producten
        private ObservableCollection<Product> _producten;

        //datagrid orderlijnen
        private ObservableCollection<Orderlijn> _orderlijnen;


        //geselecteerd orderlijn uit datagrid
        private Orderlijn _selectedOrderlijn;
        private string _foutmelding;

       

        private Orderlijn _orderlijnRecord;
        private bool _comboboxEnabled;

        public bool ComboboxEnabled
        {
            get { return _comboboxEnabled; }
            set
            {
                _comboboxEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public Orderlijn OrderlijnRecord
        {
            get { return _orderlijnRecord; }
            set
            {
                _orderlijnRecord = value;
                NotifyPropertyChanged();
            }
        }


        public string Foutmelding
        {
            get { return _foutmelding; }
            set
            {
                _foutmelding = value;
                NotifyPropertyChanged();
            }
        }


        public string OrderID
        {
            get { return _orderID; }
            set
            {
                _orderID = value;
                //NotifyPropertyChanged("OrderID");
                NotifyPropertyChanged();
            }
        }

        public Orderlijn SelectedOrderlijn
        {
            get { return _selectedOrderlijn; }
            set
            {
                _selectedOrderlijn = value;
                OrderlijnRecordInstellen();
                //NotifyPropertyChanged("SelectedOrderlijn");
                NotifyPropertyChanged();

            }
        }



        public ObservableCollection<Orderlijn> Orderlijnen
        {
            get => _orderlijnen;
            set
            {
                _orderlijnen = value;
                //NotifyPropertyChanged("Orderlijnen");
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Product> Producten
        {
            get => _producten;
            set
            {
                _producten = value;

            }
        }

        public override string this[string columnName]
        {
            get
            {

                if (columnName == "OrderID" && !int.TryParse(OrderID, out int intOrderID))
                {
                    return "OrderID moet een numerieke waarde zijn!" + Environment.NewLine;
                }

                return "";
            }
        }


        public void Aanpassen()
        {

            
            if (SelectedOrderlijn != null)
            {
                if (OrderlijnRecord.IsGeldig())
                {
                    #region aanpassen orderlijn
                    int ok = DatabaseOperations.AanpassenOrderlijn(OrderlijnRecord);
                    if (ok > 0)
                    {

                        Resetten();
                    }
                    else
                    {
                        Foutmelding = "Orderlijn is niet aangepast";
                    }
                    #endregion
                }

            }
            else
            {
                Foutmelding = "Selecteer een orderlijn!";
            }


        }

        public void Resetten()
        {
            //if (this.IsGeldig())
            //{

                SelectedOrderlijn = null;
                OrderlijnRecordInstellen();
                Foutmelding = "";
            //}
            //else
            //{
            //    Foutmelding = this.Error;
            //}
        }

        public void Zoeken()
        {
            Foutmelding = "";
            if (IsGeldig())
            {
                List<Orderlijn> listOrderlijnen = DatabaseOperations.OphalenOrderlijnenViaOrderID(int.Parse(OrderID));
                Orderlijnen = new ObservableCollection<Orderlijn>(listOrderlijnen);
                if (listOrderlijnen == null || listOrderlijnen.Count <= 0)
                {
                    Foutmelding = "Er zijn geen orderlijnen gevonden horende bij orderID " + OrderID;
                }

            }
            else
            {
                Foutmelding = this.Error;
            }

        }

        public void Verwijderen()
        {

            if (SelectedOrderlijn != null)
            {


                #region verwijder + update velden
                int ok = DatabaseOperations.VerwijderenOrderlijn(SelectedOrderlijn);
                if (ok > 0)
                {
                    List<Orderlijn> listOrderlijnen = DatabaseOperations.OphalenOrderlijnenViaOrderID(int.Parse(OrderID));
                    Orderlijnen = new ObservableCollection<Orderlijn>(listOrderlijnen);
                    Resetten();
                }
                else
                {
                    Foutmelding = "Orderlijn is niet verwijderd.";
                }
                #endregion
            }
            else
            {
                Foutmelding = "Eerst Orderlijn selecteren";
            }
        }

        public void Toevoegen()
        {


            if (this.IsGeldig())
            {


                OrderlijnRecord.OrderID = int.Parse(OrderID);
                if (OrderlijnRecord.IsGeldig())
                {
                    #region toevoegen orderlijn
                    int ok = DatabaseOperations.ToevoegenOrderlijn(OrderlijnRecord);

                    if (ok > 0)
                    {
                        List<Orderlijn> listOrderlijnen = DatabaseOperations.OphalenOrderlijnenViaOrderID(int.Parse(OrderID));
                        Orderlijnen = new ObservableCollection<Orderlijn>(listOrderlijnen);
                        Resetten();
                    }
                    else
                    {
                        Foutmelding = "Orderlijn is niet toegevoegd";
                    }
                    #endregion

                }
            }
        }
        private void OrderlijnRecordInstellen()
        {
            if (SelectedOrderlijn != null)
            {
                OrderlijnRecord = SelectedOrderlijn;
                ComboboxEnabled = false;
            }
            else
            {
                OrderlijnRecord = new Orderlijn();
                ComboboxEnabled = true;
            }
        }


    }
}



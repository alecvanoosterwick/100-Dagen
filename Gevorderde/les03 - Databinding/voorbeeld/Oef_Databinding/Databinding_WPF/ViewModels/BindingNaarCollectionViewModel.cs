using Databinding_DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Databinding_WPF.ViewModels
{
    public class BindingNaarCollectionViewModel: BasisViewModel
    {
        private string _orderID;
        private ObservableCollection<Orderlijn> _orderlijnen;
        private string _foutmelding;
        private Orderlijn _selectedOrderlijn;
    


        public Orderlijn SelectedOrderlijn
        {
            get { return _selectedOrderlijn; }
            set {
                _selectedOrderlijn = value;
                NotifyPropertyChanged("SelectedOrderlijn");
                
            }
        }


       
        public ObservableCollection<Orderlijn> Orderlijnen
        {
            get { return _orderlijnen; }
            set {
                _orderlijnen = value;
                NotifyPropertyChanged();
               
            }
        }
        public string Foutmelding
        {
            get { return _foutmelding; }
            set
            {
                _foutmelding = value;
                NotifyPropertyChanged("Foutmelding");
             
            }
        }

        public string OrderID
        {
            get { return _orderID; }
            set {
                _orderID = value;
                NotifyPropertyChanged();
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


        public void Zoeken()
        {
            Foutmelding = "";
            if (this.IsGeldig())
            {
                List<Orderlijn> listOrderlijnen = DatabaseOperations.OphalenOrderlijnenViaOrderID(int.Parse(OrderID));

                Orderlijnen = new ObservableCollection<Orderlijn>(listOrderlijnen);

                if (listOrderlijnen == null || listOrderlijnen.Count <= 0)
                {
                    Foutmelding = "Er zijn geen orderlijnen gevonden horende bij orderID " + OrderID;
                }

            
                
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

        public void Resetten()
        {
            if (IsGeldig())
            {

                SelectedOrderlijn = null;
                Foutmelding = "";
            }
            else
            {
                Foutmelding = this.Error;
            }
        }


    }
}

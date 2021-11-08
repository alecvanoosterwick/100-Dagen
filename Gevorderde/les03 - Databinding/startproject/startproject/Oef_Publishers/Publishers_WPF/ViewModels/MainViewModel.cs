using Publishers_Dal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publishers_WPF.ViewModels
{
    public class MainViewModel : BasisViewModel
    {
        public override string this[string columnName] { get{ return ""; } }

        public override event EventHandler CanExecuteChanged;

        private string _naam;
        private ObservableCollection<Stores> _stores;

        public ObservableCollection<Stores> Stores { get { return _stores; } set { _stores = value; NotifyPropertyChanged(); } }
        
        public string Naam
        {
            get { return _naam; }
            set
            {
                _naam = value;
                NotifyPropertyChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "CudView":
                    CudView cv = new CudView();
                    CudViewModel cvm = new CudViewModel();
                    cv.DataContext = cvm;
                    cv.Show();
                    break;
                case "Zoeken":
                    this.Zoeken();
                    break;
               }
        }

        private void Zoeken()
        {
            List<Stores> store = DatabaseOperations.OphalenWinkelsOpNaam(Naam);
            Stores = new ObservableCollection<Stores>(store);
        }
    }
}

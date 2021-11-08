using Publishers_Dal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Publishers_WPF.ViewModels
{
    public class CudViewModel : BasisViewModel
    {
        public override string this[string columnName] { get { return ""; } }

        public override event EventHandler CanExecuteChanged;

        private ObservableCollection<Publishers> _uitgever;

        public ObservableCollection<Publishers> Uitgever
        {
            get { return _uitgever; }
            set
            {
                _uitgever = value;
                NotifyPropertyChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
        public CudViewModel ()
        {
            List<Publishers> lijstPublisher = DatabaseOperations.OphalenUitgevers();
            Uitgever = new ObservableCollection<Publishers>(lijstPublisher);
        }

}
}

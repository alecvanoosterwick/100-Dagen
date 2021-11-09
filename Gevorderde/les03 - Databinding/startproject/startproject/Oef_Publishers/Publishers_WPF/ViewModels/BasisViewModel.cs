using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Publishers_WPF.ViewModels
{
    public abstract class BasisViewModel : IDataErrorInfo, INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public abstract event EventHandler CanExecuteChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyname="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


        public abstract string this[string columnName] { get; }

       

        public bool IsGeldig()
        {
            return string.IsNullOrWhiteSpace(Error);

        }

        public abstract bool CanExecute(object parameter);
        public abstract void Execute(object parameter);

        public string Error
        {
            get
            {
                string foutmeldingen = "";

                foreach (var item in this.GetType().GetProperties()) //reflection 
                {
                    if (item.CanRead)
                    {
                        string fout = this[item.Name];
                        if (!string.IsNullOrWhiteSpace(fout))
                        {
                            foutmeldingen += fout + Environment.NewLine;
                        }
                    }
                }
                return foutmeldingen;
            }
        }




    }
}

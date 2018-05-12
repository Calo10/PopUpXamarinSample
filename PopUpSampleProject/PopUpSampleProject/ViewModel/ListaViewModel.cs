using PopUpSampleProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopUpSampleProject.ViewModel
{
    public class ListaViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<GenericListModel> _lstGeric { get; set; }

        public ObservableCollection<GenericListModel> lstGeric
        {
            get
            {
                return _lstGeric;
            }
            set
            {
                _lstGeric = value;
                OnPropertyChanged("lstGeric");
            }

        }

        public ListaViewModel()
        {

            lstGeric = GenericListModel.GetGenericList();

        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) // if there is any subscribers 
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}

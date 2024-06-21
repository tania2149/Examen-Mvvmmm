using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Mvvm.ViewModels

{

    public class ObservableObject : INotifyPropertyChanged

    {

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)

        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }


        protected virtual void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)

        {

            if (Equals(storage, value)) return;


            storage = value;

            OnPropertyChanged(propertyName);

        }

    }

}

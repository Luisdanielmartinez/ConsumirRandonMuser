using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsumApi.model
{
   public  class Usuario:INotifyPropertyChanged
    {
        private string last;
        private string first;
        private string medium;
        private string phone;
        private string email;
        private string title;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange([CallerMemberName]string nombre="") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
        public string First {
            get { return first; }
            set { first = value;
                OnPropertyChange();
            }
        }
        public string Last
        {
            get { return last; }
            set { last = value;
                OnPropertyChange();
            }
        }
        public string Medium
        {
            get { return medium; }
            set { medium = value;
                OnPropertyChange();
            }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value;
                OnPropertyChange();
            }
        }
        public string Title
        {
            get { return title; }
            set { title = value;
                OnPropertyChange();
            }
        }
        public string NombreCompleto{
            get { return $"{title}. {first} {last}"; }
               }

       
    }
}

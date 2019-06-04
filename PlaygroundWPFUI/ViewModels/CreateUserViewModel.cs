using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace PlaygroundWPFUI.ViewModels
{
    class CreateUserViewModel : Screen
    {
        private string _username;
        private string _firstname;
        private string _lastname;


        public string Username
        {
            get { return _username; }
            set { _username = value; }
        } 

        public string Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                NotifyOfPropertyChange(() => Firstname);
            }
        }     

        public string Lastname
        {
            get { return _lastname; }
            set
            { _lastname = value;
                NotifyOfPropertyChange(() => Lastname);
            }
        }

        
    }
}

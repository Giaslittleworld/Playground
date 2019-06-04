using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundWPFUI.ViewModels
{
    public class CombineNamesViewModel : Screen
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => CanCombine);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => CanCombine);
            }
        }


        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                NotifyOfPropertyChange(() => FullName);
            }
        }


        public bool CanCombine
        {
            get
            {
                return FirstName?.Length > 0 && LastName?.Length > 0;
            }
        }

        public void Combine()
        {
            FullName = $" { FirstName } { LastName } ";
        }
    }
}

using Caliburn.Micro;
using System;

namespace PlaygroundWPFUI.ViewModels
{
    public class ShellViewModel : Screen
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
            set {
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

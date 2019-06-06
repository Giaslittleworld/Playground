using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using PlaygroundWPFUI.Models;

namespace PlaygroundWPFUI.ViewModels
{
    class CreateUserViewModel : Screen
    {
        private string _username;
        private string _firstname;
        private string _lastname;
        private SalutationModel _selectedSalutation;
        private TitleModel _selectedTitle;
        private string _emailPrefix;
        private string _emailAddress;
        private DateTime _birthday;
        private bool _isRealPerson;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public BindableCollection<SalutationModel> Salutation
        {
            get; private set;
        }
        
        public SalutationModel SelectedSalutation
        {
            get { return _selectedSalutation; }
            set { _selectedSalutation = value; }
        }
        
        public BindableCollection<TitleModel> Title
        {
            get; private set;
        }
        public TitleModel SelectedTitle
        {
            get { return _selectedTitle; }
            set { _selectedTitle = value; }
        }

        public string EmailPrefix
        {
            get { return _emailPrefix; }
            set { _emailPrefix = value; }
        }     

        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }       

        public bool IsRealPerson
        {
            get { return _isRealPerson; }
            set { _isRealPerson = value; }
        }

        public void SubmitForm()
        {

        }

    }
}

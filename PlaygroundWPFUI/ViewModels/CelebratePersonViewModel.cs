using Caliburn.Micro;
using PlaygroundLibrary.DataAccess;
using PlaygroundLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundWPFUI.ViewModels
{
    public class CelebratePersonViewModel : Screen
    {
        public BindableCollection<PersonModel> People { get; set; }
               
        public CelebratePersonViewModel()
        {
            DataAccessLayer da = new DataAccessLayer();

            People = new BindableCollection<PersonModel>(da.GetPeople());
        }

        private PersonModel _selectedPerson;

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }


    }
}

using Caliburn.Micro;
using System;

namespace PlaygroundWPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public void ShowCombineNamesView()
        {
            ActivateItem(new CombineNamesViewModel());
        }

        public void ShowCelebratePersonView()
        {
            ActivateItem(new CelebratePersonViewModel());
        }
    }
}

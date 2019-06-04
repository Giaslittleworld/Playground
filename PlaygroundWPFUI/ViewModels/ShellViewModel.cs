using Caliburn.Micro;
using System;

namespace PlaygroundWPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
            // ActivateItem(new CombineNamesViewModel());
            ActivateItem(new CelebratePersonViewModel());
        }
    }
}

using Caliburn.Micro;
using PlaygroundWPFUI.ViewModels;
using System.Windows;

namespace PlaygroundWPFUI
{
    public class Bootstrapper : BootstrapperBase
    {

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}

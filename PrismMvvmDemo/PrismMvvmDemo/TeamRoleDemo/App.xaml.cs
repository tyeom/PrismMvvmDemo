using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TeamRoleDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            base.OnStartup(e);
            TeamRoleBootstrapper bootstrapper = new TeamRoleBootstrapper();
            bootstrapper.Run();
        }
    }
}

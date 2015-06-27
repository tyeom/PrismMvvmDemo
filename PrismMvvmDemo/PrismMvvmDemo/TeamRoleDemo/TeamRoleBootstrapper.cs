using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Interactivity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using System.Windows;
using ModuleRoleSelection;
using ModuleShowDetails;
using ModuleCommonDetails;
namespace TeamRoleDemo
{
    public class TeamRoleBootstrapper : UnityBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            //return new TeamRoleShell();

            TeamRoleShell teamRoleShell = this.Container.TryResolve<TeamRoleShell>();
            return teamRoleShell;
        }
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            
        }
        protected override void InitializeModules()
        {
           
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(RoleSelectionModule));
            moduleCatalog.AddModule(typeof(ShowDetailsModule));
            moduleCatalog.AddModule(typeof(CommonDetailsModule));
            base.InitializeModules();
        }
        protected override IModuleCatalog CreateModuleCatalog()
        {
             return base.CreateModuleCatalog();
             ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
             moduleCatalog.AddModule(typeof(RoleSelectionModule));
             moduleCatalog.AddModule(typeof(ShowDetailsModule));
             moduleCatalog.AddModule(typeof(CommonDetailsModule));
             //return moduleCatalog;
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }
    }
}

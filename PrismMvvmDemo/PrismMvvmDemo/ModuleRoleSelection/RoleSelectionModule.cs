using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleRoleSelection
{
    public class RoleSelectionModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IEventAggregator eventagg;
        public RoleSelectionModule(IRegionManager regionManager,IEventAggregator eventagg)
        {

            _regionManager = regionManager;
            this.eventagg = eventagg;
        }

        public void Initialize()
        {
            _regionManager.Regions["RoleSelection"].Add(new ModuleRoleSelection.View.RoleSelectionView(eventagg));
        }

    }
}

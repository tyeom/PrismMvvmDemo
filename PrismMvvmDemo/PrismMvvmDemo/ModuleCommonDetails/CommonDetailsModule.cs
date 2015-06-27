using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleCommonDetails
{
    public class CommonDetailsModule : IModule
    {
        private readonly IRegionManager _regionManager;
        public CommonDetailsModule(IRegionManager regionManager)
        {

            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.Regions["CommonSelection"].Add(new ModuleCommonDetails.View.CommonDetailView());
        }


    }
}

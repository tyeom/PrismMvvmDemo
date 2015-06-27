using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleShowDetails
{
    public class ShowDetailsModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IEventAggregator eventAgg;
        public ShowDetailsModule(IRegionManager regionManager,IEventAggregator eventAgg)
        {

            _regionManager = regionManager;
            this.eventAgg = eventAgg;
        }

        public void Initialize()
        {
            _regionManager.Regions["DetailSelection"].Add(new ModuleShowDetails.View.ShowDetailsView(eventAgg));
        }

    }
}

using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleCommonDetails.ViewModel
{
    public class CommonDetailViewModel:NotificationObject
    {
        public CommonDetailViewModel()
        {

        }
        private string universityName="Jaypee";
        public string UniversityName { get { return universityName; } set { universityName = value;
        RaisePropertyChanged(() => this.UniversityName);
        }
        }
    }
}

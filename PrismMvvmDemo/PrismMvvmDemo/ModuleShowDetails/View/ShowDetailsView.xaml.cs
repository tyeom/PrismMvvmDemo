using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Unity;
using ModuleShowDetails.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModuleShowDetails.View
{
    /// <summary>
    /// Interaction logic for ShowDetailsView.xaml
    /// </summary>
    public partial class ShowDetailsView : UserControl
    {
        public ShowDetailsView(IEventAggregator eventagg)
        {
            InitializeComponent();
            this.DataContext = new ShowDetailsViewModel(eventagg);
        }
        //[Dependency]
        //public ShowDetailsViewModel vm
        //{
        //    get { return  vm; }
        //    set { this.DataContext = new ShowDetailsViewModel(); }
        //}
    }
}

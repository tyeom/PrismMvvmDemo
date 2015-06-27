using Microsoft.Practices.Prism.PubSubEvents;
using ModuleRoleSelection.ViewModel;
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

namespace ModuleRoleSelection.View
{
    /// <summary>
    /// Interaction logic for RoleSelectionView.xaml
    /// </summary>
    public partial class RoleSelectionView : UserControl
    {
        public RoleSelectionView(IEventAggregator eventagg)
        {
            InitializeComponent();
            this.DataContext = new RoleSelectionViewModel(eventagg);
        }
    }
}

using Infrastructure;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ModuleRoleSelection.ViewModel
{
    public class RoleSelectionViewModel : NotificationObject
    {
        public DelegateCommand<object> RoleSelectionChangeCommand { get; set; }
        private IEventAggregator _eventAggregator;
        public RoleSelectionViewModel(IEventAggregator eventAggregator)
        {
            this._eventAggregator = eventAggregator;
            InitializeDelegateCommand();
            roleName.Add("Student");
            roleName.Add("Intern");
            roleName.Add("Faculty");

        }
        public void InitializeDelegateCommand()
        {
            RoleSelectionChangeCommand = new DelegateCommand<object>(OnSelection,canExecute);
        }
        public bool canExecute(object parm)
        {
            return true;
        }
        public void OnSelection(object parm)
        {
            _eventAggregator.GetEvent<RoleSelectionChangedEvent>().Publish((parm as ComboBox).SelectedValue);
        }
        private List<string> roleName = new List<string>();
        public List<string> RoleName
        {
            get { return roleName; }
            set
            {
                roleName = value;
                RaisePropertyChanged(() => this.RoleName);
            }
        }
        private string selectedroleName = "Student";
        public string SelectedRoleName
        {
            get { return selectedroleName; }
            set
            {
                selectedroleName = value;
                RaisePropertyChanged(() => this.SelectedRoleName);
            }
        }
    }
   
   
}

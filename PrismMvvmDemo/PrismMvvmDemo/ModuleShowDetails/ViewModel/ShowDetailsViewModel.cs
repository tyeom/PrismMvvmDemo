using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace ModuleShowDetails.ViewModel
{
    public class ShowDetailsViewModel : NotificationObject
    {

        private readonly IEventAggregator eventAggregator;
        public ShowDetailsViewModel(IEventAggregator eventAgg)
        {
            this.eventAggregator = eventAgg;
            userDetails.Add(new User() { FirstName = "Akhil", LastName = "Garg", ID = 1, Title = "Student" });
            userDetails.Add(new User() { FirstName = "Ankit", LastName = "Garg", ID = 2, Title = "Student" });
            userDetails.Add(new User() { FirstName = "Abhishek", LastName = "Garg", ID = 3, Title = "Student" });
            userDetails.Add(new User() { FirstName = "Abhilash", LastName = "Garg", ID = 4, Title = "Student" });
            userDetails.Add(new User() { FirstName = "Vivek", LastName = "Garg", ID = 5, Title = "Student" });
            userDetails.Add(new User() { FirstName = "Jatin", LastName = "Garg", ID = 6, Title = "Student" });
            userDetails.Add(new User() { FirstName = "Rishab", LastName = "Garg", ID = 7, Title = "Student" });
            userDetails.Add(new User() { FirstName = "Vipul", LastName = "Garg", ID = 8, Title = "Student" });
            userDetails.Add(new User() { FirstName = "Vikrant", LastName = "Garg", ID = 9, Title = "Student" });
            userDetails.Add(new User() { FirstName = "Amit", LastName = "Garg", ID = 1, Title = "Intern" });
            userDetails.Add(new User() { FirstName = "Ankush", LastName = "Garg", ID = 2, Title = "Intern" });
            userDetails.Add(new User() { FirstName = "Ashish", LastName = "Garg", ID = 3, Title = "Intern" });
            userDetails.Add(new User() { FirstName = "Rajat", LastName = "Garg", ID = 4, Title = "Intern" });
            userDetails.Add(new User() { FirstName = "Bhupesh", LastName = "Garg", ID = 5, Title = "Intern" });
            userDetails.Add(new User() { FirstName = "Albert", LastName = "Jr", ID = 1, Title = "Faculty" });
            userDetails.Add(new User() { FirstName = "Albert", LastName = "Sr", ID = 2, Title = "Faculty" });
            userDetails.Add(new User() { FirstName = "Julia", LastName = "Jr", ID = 3, Title = "Faculty" });
            userDetails.Add(new User() { FirstName = "Julia", LastName = "Sr", ID = 4, Title = "Faculty" });
            userDetails.Add(new User() { FirstName = "Newton", LastName = "Jr", ID = 5, Title = "Faculty" });
            userDetails.Add(new User() { FirstName = "Newton", LastName = "Sr", ID = 6, Title = "Faculty" });
            selecteduserDetails = userDetails.FindAll(x => x.Title == "Student");
            eventAggregator.GetEvent<RoleSelectionChangedEvent>().Subscribe(GenerateDataList);

        }
        public void GenerateDataList(object param)
        {
            SelecteduserDetails = userDetails.FindAll(x => x.Title == param.ToString());
        }

        private List<User> userDetails = new List<User>();
        public List<User> UserDetail
        {
            get { return userDetails; }
            set
            {
                userDetails = value;
                RaisePropertyChanged(() => this.UserDetail);
            }
        }
        private List<User> selecteduserDetails = new List<User>();
        public List<User> SelecteduserDetails
        {
            get { return selecteduserDetails; }
            set
            {
                selecteduserDetails = value;
                RaisePropertyChanged(() => this.SelecteduserDetails);
            }
        }


    }
    public class User
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}

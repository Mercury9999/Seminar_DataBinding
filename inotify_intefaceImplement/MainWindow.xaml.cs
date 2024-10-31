using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace inotify_intefaceImplement
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
            users.Add(new User() { Name = "John Doe" });
            users.Add(new User() { Name = "Jane Doe" });

            lbUsers.ItemsSource = users;
        }

        //        private List<User> users = new List<User>();
        private ObservableCollection<User> users = new ObservableCollection<User>(); 

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User() { Name = "New user" });
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                (lbUsers.SelectedItem as User).Name = "Random Name";
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                users.Remove(lbUsers.SelectedItem as User);
        }
    }

    //public class User 
    //{
    //    public string Name { get; set; }
    //}

    public class User : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.Name != value)
                {
                    this.name = value;
                    this.NotifyPropertyChanged("Name");
                }

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }


}
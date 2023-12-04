using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Facebook
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        facebookEntities1 db=new facebookEntities1();

        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            forget s=new forget();  
            this.NavigationService.Navigate(s);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            userr_login dd=new userr_login();
            dd= db.userr_login.FirstOrDefault(x=>x.username==u1.Text&& x.passwordd==p1.Text);
            if (dd!=null)
            {
                Home h=new Home();
                this.NavigationService.Navigate(h);
            }
            else
            {
                MessageBox.Show("Error Login");
            }
        }
    }
}

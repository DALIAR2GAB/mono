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

namespace Facebook
{
    /// <summary>
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        facebookEntities1 db=new facebookEntities1();
        public signup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr_login n=new userr_login();
            if(user!=null && pass !=null && con!=null)
            {
                n.username = user.Text;
                n.passwordd= pass.Text;
                n.passwordd= con.Text;
                db.userr_login.Add(n);
                db.SaveChanges();
                MessageBox.Show("Secucfully sign up");
                login l=new login();
                this.NavigationService.Navigate(l); 
            }
        }
    }
}

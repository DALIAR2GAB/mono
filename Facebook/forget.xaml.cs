using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forget.xaml
    /// </summary>
    public partial class forget : Page
    {
        facebookEntities1 db=new facebookEntities1();
        public forget()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr_login ul=new userr_login();
            ul=db.userr_login.FirstOrDefault(x=>x.username==uu.Text);   
            if(ul!=null)
            {
                ul.passwordd = pp.Text;
                db.userr_login.AddOrUpdate(ul);
                db.SaveChanges();
                MessageBox.Show("Secully update new password");
                login l= new login();
                this.NavigationService.Navigate(l); 
            }
        }
    }
}

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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        facebookEntities1 db=new facebookEntities1();
        public Home()
        {
            InitializeComponent();
            datagrid.ItemsSource=db.freinds.ToList();  
        }

        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            freind f=new freind();
            if(n1.Text!=null)
            {
                datagrid.ItemsSource=db.freinds.Where(x=>x.namee.Contains(n1.Text)).ToList();
            }
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           Page1 ss=new Page1();
           this.NavigationService.Navigate(ss);
        }
    }
}

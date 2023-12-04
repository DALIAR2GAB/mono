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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        facebookEntities1 db = new facebookEntities1();

        public Page1()
        {
            InitializeComponent();
            dd.ItemsSource = db.posts.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            dd.ItemsSource = db.posts.ToList();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            post p = new post();
            p.lines = search.Text;
            db.posts.AddOrUpdate(p);
            db.SaveChanges();
            MessageBox.Show("done share");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            post p = new post();
            int id = int.Parse(ide.Text);
            p = db.posts.FirstOrDefault(x => x.IDpost == id);
            p.lines = search.Text;
            db.posts.AddOrUpdate(p);
            db.SaveChanges();
            MessageBox.Show("Secsfully update");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            post d = new post();
            int idd = int.Parse(ide.Text);
            d = db.posts.FirstOrDefault(x => x.IDpost == idd);
            db.posts.Remove(d);
            db.SaveChanges();
            MessageBox.Show("Done Delete");
        }
    }
}

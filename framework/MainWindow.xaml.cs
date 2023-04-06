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

namespace framework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            baseEntities1 baseEntities = new baseEntities1();

            datagrid.ItemsSource = baseEntities.articles.ToList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            item item = new item();
            if (item.ShowDialog() == true)
            {
                baseEntities1 baseEntities = new baseEntities1();
                datagrid.ItemsSource = baseEntities.articles.ToList();
            }

        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            var item_form = (article)datagrid.SelectedItem;

            item item = new item(item_form);
            if(item.ShowDialog() == true)
            {
                baseEntities1 baseEntities = new baseEntities1();
                datagrid.ItemsSource = baseEntities.articles.ToList();
            }
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = ((article)datagrid.SelectedItem);
            


            baseEntities1 baseEntities = new baseEntities1();

            var it = baseEntities.articles.Where(u=>u.id == item.id).FirstOrDefault();

            baseEntities.articles.Remove(it);
            baseEntities.SaveChanges();

            datagrid.ItemsSource = baseEntities.articles.ToList();
        }
    }
}

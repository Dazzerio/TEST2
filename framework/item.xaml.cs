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
using System.Windows.Shapes;

namespace framework
{
    /// <summary>
    /// Логика взаимодействия для item.xaml
    /// </summary>
    public partial class item : Window
    {
        article article;

        public item(article article1)
        {
            InitializeComponent();

            this.article = article1;

            textboxName.Text = article.name;
            textboxText.Text = article.text;
        }

        public item()
        {
            InitializeComponent();

            this.article = new article();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

            baseEntities1 baseEntities = new baseEntities1();

            String name = textboxName.Text.ToString();
            String text = textboxText.Text.ToString();

            if(name != "" && text != "")
            {
                article.text = text;
                article.name = name;
                
                if(article.id_user == 0)
                    article.id_user = 1;

                if(article.id == 0)
                {
                    baseEntities.articles.Add(article);
                    baseEntities.SaveChanges();
                } else
                {
                    var art = baseEntities.articles.Where(u => u.id == article.id).FirstOrDefault();
                    art.text = text;
                    art.name = name;
                    baseEntities.SaveChanges();
                }

                
                DialogResult = true;
            }
            else { MessageBox.Show("Заполните поля"); return; }
        }
    }
}

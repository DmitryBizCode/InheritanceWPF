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

namespace InheritanceCopybookWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool Checked;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Cool(object sender, RoutedEventArgs e) => Checked = true;
        private void Simple(object sender, RoutedEventArgs e) => Checked = false;


        private void Check_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(Pages_quantity.Text) && String.IsNullOrEmpty(((ComboBoxItem)NameKind.SelectedItem).Content.ToString()))
                {
                    var a = new CopybookRich();
                    Cost.Content = ((Copybook)a).Calculate().ToString();
                }
                uint Pages = uint.Parse(Pages_quantity.Text);
                string Name = ((ComboBoxItem)NameKind.SelectedItem).Content.ToString();
                if (Checked)
                {
                    string Cover = ((ComboBoxItem)this.Cover.SelectedItem).Content.ToString();
                    var a = new CopybookRich(Pages, Name, Cover);
                    Cost.Content = a.Calculate().ToString();
                }
                else
                {
                    var a = new CopybookRich(Pages, Name);
                    Cost.Content = ((Copybook)a).Calculate().ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

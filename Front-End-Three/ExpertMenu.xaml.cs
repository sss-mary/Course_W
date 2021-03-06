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
using TCPConnectionAPIClientModule_C_sharp_;
namespace Front_End_Three
{
    /// <summary>
    /// Логика взаимодействия для ExpertMenu.xaml
    /// </summary>
    public partial class ExpertMenu : Window
    {
        private IExpertAccess module;
        public ExpertMenu(IExpertAccess module)
        {
            this.module = module;
            InitializeComponent();
        }

        private void FindBySomething_Click(object sender, RoutedEventArgs e)
        {
            FindBySomething findBySomething = new FindBySomething(module as ClientConnectionModule);
            findBySomething.ShowDialog();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            module.PreviousRoom();
            MainWindow mainWindow = new MainWindow(module as ClientConnectionModule);
            mainWindow.Show();
            this.Close();
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            Sort sort = new Sort(module);
            sort.ShowDialog();
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            Filtration filtration = new Filtration(module);
            filtration.ShowDialog();
        }

        private void ExpertMethod1_Click(object sender, RoutedEventArgs e)
        {
            ExpertMethod1 expertMethod1 = new ExpertMethod1(module);
            expertMethod1.ShowDialog();
        }

        private void ExpertMethod2_Click(object sender, RoutedEventArgs e)
        {
            ExpertMethod2 expertMethod2 = new ExpertMethod2(module);
            expertMethod2.ShowDialog();
        }
    }
}

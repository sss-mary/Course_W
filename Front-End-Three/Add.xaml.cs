using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        string fileName;
        bool isEmpty = true, isEmptyTwo = true, isEmptyThree = true;
        private IAdminAccess module;
        public Add(IAdminAccess module)
        {
            fileName = ConfigurationManager.AppSettings.Get("defaultPhotoPath");
            this.module = module;
            InitializeComponent();
        }

        /*private void addphoto_click(object sender, routedeventargs e)
        {
            openfiledialog op = new openfiledialog();
            op.title = "select a picture";
            op.filter = "all supported graphics|*.jpg;*.jpeg;*.png|" +
              "jpeg (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "portable network graphic (*.png)|*.png";
            if (op.showdialog() == true)
            {
                filename = op.filename;
            }
        }*/

         private void Add_Click(object sender, RoutedEventArgs e)
         {
            int CountEmp;
            int UNPValue;
            try
            {
                CountEmp = int.Parse(CostElem.Text);
                UNPValue = int.Parse(UNP.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод!");
                return;
            }
            Random random = new Random();
            var value = (random.Next(0, 9).ToString() + "," + random.Next(0,9).ToString());
            var answer = module.CreateSubcontractor(new DatabaseEntities.Subcontractor (Model.Text, CountEmp, UNPValue, new System.Drawing.Bitmap(fileName))
            {
                TotalRate = double.Parse(value)
            });
            switch (answer)
            {
                case ClassLibraryForTCPConnectionAPI_C_sharp_.AnswerFromServer.Successfully:
                    {
                        MessageBox.Show("Успешно!");
                        break;
                    }
                case ClassLibraryForTCPConnectionAPI_C_sharp_.AnswerFromServer.Error:
                    {
                        MessageBox.Show("Ошибка!");
                        break;
                    }
                case ClassLibraryForTCPConnectionAPI_C_sharp_.AnswerFromServer.UnknownCommand:
                    {
                        MessageBox.Show("Ошибка!");
                        break;
                    }
                default:
                    break;
            }
        }

        private void Model_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isEmpty)
            {
                Model.Text = "";
                isEmptyTwo = false;
            }
            if (Model.Text == "Введите название")
            {
                Model.Text = "";
            }
            if (CostElem.Text == "")
            {
                CostElem.Text = "Введите кол-во работодателей";
            }
            if (UNP.Text == "")
            {
                UNP.Text = "Введите номер УНП";
            }
        }

        private void Cost_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isEmptyTwo)
            {
                CostElem.Text = "";
                isEmptyTwo = false;
            }
            if (CostElem.Text == "Введите кол-во работодателей")
            {
                CostElem.Text = "";
            }
            if (Model.Text == "")
            {
                Model.Text = "Введите название";
            }
            if (UNP.Text == "")
            {
                UNP.Text = "Введите номер УНП";
            }
        }

        private void UNP_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isEmptyThree)
            {
                UNP.Text = "";
                isEmptyTwo = false;
            }
            if (UNP.Text == "Введите номер УНП")
            {
                UNP.Text = "";
            }
            if (Model.Text == "")
            {
                Model.Text = "Введите название";
            }
            if (CostElem.Text == "Введите кол-во работодателей")
            {
                CostElem.Text = "";
            }
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

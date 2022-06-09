using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        string fileName;
        int counter = 0;
        ParamToFind choosenParam;
        bool isEmpty = true;
        private IAdminAccess module;
        List<DatabaseEntities.Subcontractor> subcontractors;
        public Edit(IAdminAccess module)
        {
            fileName = "defaultPhoto.png";
            choosenParam = ParamToFind.Name;
            this.module = module;
            subcontractors = module.GetAllSubcontactors();
            InitializeComponent();
            if (subcontractors.Count == 0)
            {
                MessageBox.Show("Нет данных!");
            }
            else
                Show(subcontractors[0]);
        }

        private void SomeInput_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isEmpty)
            {
                SomeInput.Text = "";
                isEmpty = false;
            }
        }

        private void Show(DatabaseEntities.Subcontractor subcontractor)
        {
            if (subcontractor == null)
            {
                MessageBox.Show("Не найдено!");
            }
            else
            {
                SubcontractorImage.Source = App.ConvertToBitmapImage(subcontractor.Photo);
                SubcontractorName.Text = subcontractor.Name;
                SubcontractorAmount.Text = subcontractor.AmountOfEmployees.ToString();
                SubcontractorUNP.Text = subcontractor.UNP.ToString();
                SubcontractorRate.Text = subcontractor.TotalRate.ToString();
            }
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFind.None;
            TopMenuItem.Header = "Показать всё";
        }

        private void LeftArrow_Click(object sender, RoutedEventArgs e)
        {
            if (subcontractors.Count == 0)
            {
                MessageBox.Show("Не найдено!");
            }
            else
            {
                if (counter == 0)
                {
                    Show(subcontractors[0]);
                }
                else
                {
                    counter--;
                    Show(subcontractors[counter]);
                }
            }
        }

        private void RightArrow_Click(object sender, RoutedEventArgs e)
        {
            if (subcontractors.Count == 0)
            {
                MessageBox.Show("Не найдено!");
            }
            else if (subcontractors.Count == 1)
            {
                Show(subcontractors[counter]);
            }
            else
            {
                if (counter + 1 == subcontractors.Count)
                {
                    Show(subcontractors[counter]);
                }
                else
                {
                    counter++;
                    Show(subcontractors[counter]);
                }
            }
        }

        private void FindSome_Click(object sender, RoutedEventArgs e)
        {
            subcontractors.Clear();
            switch (choosenParam)
            {
                case ParamToFind.Name:
                    {
                        subcontractors = module.FindSubcontractorWithName(SomeInput.Text);
                        break;
                    }
                case ParamToFind.UNPNumber:
                    {
                        subcontractors = module.FindSubcontractorWithUNP(int.Parse(SomeInput.Text));
                        break;
                    }
                case ParamToFind.AmountOfEmployers:
                    {
                        subcontractors = module.FindSubcontractorWithAmountOfEmployees(int.Parse(SomeInput.Text));
                        break;
                    }
                case ParamToFind.None:
                    {
                        subcontractors = module.GetAllSubcontactors();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Повторите попытку!");
                        break;
                    }
            }
        }

        private void FindByEmployers_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFind.AmountOfEmployers;
            TopMenuItem.Header = "Поиск по заказчикам";
        }

        private void FindByUNP_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFind.UNPNumber;
            TopMenuItem.Header = "Поиск по УНП";
        }

        private void FindByName_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFind.Name;
            TopMenuItem.Header = "Поиск по имени";
        }

        private void NewSubcontractor(DatabaseEntities.Subcontractor subcontractor)
        {
            if (subcontractor == null)
            {
                MessageBox.Show("Не найдено!");
            }
            else
            {
                subcontractor.Photo = new Bitmap(fileName);
                subcontractor.Name = SubcontractorName.Text;
                subcontractor.TotalRate = float.Parse(SubcontractorRate.Text);
                subcontractor.AmountOfEmployees = int.Parse(SubcontractorAmount.Text);
                subcontractor.UNP = int.Parse(SubcontractorUNP.Text);
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            int CountEmp;
            int UNPValue;
            try
            {
                CountEmp = int.Parse(SubcontractorAmount.Text);
                UNPValue = int.Parse(SubcontractorUNP.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод!");
                return;
            }
            if (SubcontractorUNP.Text == "" || SubcontractorAmount.Text == "" || SubcontractorName.Text == "")
            {
                MessageBox.Show("Ошибка!");
            }
            else
                NewSubcontractor(subcontractors[counter]);
        }

        private void SaveObject_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in subcontractors)
            {
                module.ModifySubcontractor(item);
            }
        }

        private void SubcontractorImage_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                fileName = op.FileName;
                SubcontractorImage.Source = new BitmapImage(new Uri(fileName));
            }
        }
    }
}

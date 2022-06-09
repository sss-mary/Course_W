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
    /// Логика взаимодействия для Filtration.xaml
    /// </summary>
    enum ParamToFilter
    {
        Rating,
        AmountOfEmployers,
        UNP
    }
    public partial class Filtration : Window
    {
        int counter = 0;
        ParamToFilter choosenParam;
        private IDataViewAccess module;
        List<DatabaseEntities.Subcontractor> subcontractors;
        public Filtration(IDataViewAccess module)
        {
            choosenParam = ParamToFilter.Rating;
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

        private void FilterByRating_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFilter.Rating;
            TopMenuItem.Header = "Фильтрация по рейтингу";
        }

        private void FindSome_Click(object sender, RoutedEventArgs e)
        {
            double value1, value2;
            try
            {
                value1 = double.Parse(FirstValue.Text);
                value2 = double.Parse(SecondValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода!");
                return;
            }
            switch (choosenParam)
            {
                case ParamToFilter.Rating:
                    {
                        subcontractors = subcontractors.Where(c => (c.TotalRate >= value1 && c.TotalRate <= value2)).ToList();
                        break;
                    }
                case ParamToFilter.AmountOfEmployers:
                    {
                        subcontractors = subcontractors.Where(c => ((int)c.AmountOfEmployees >= value1 && (int)c.AmountOfEmployees <= value2)).ToList();
                        break;
                    }
                case ParamToFilter.UNP:
                    {
                        subcontractors = subcontractors.Where(c => (c.UNP >= value1 && c.UNP <= value2)).ToList();
                        break;
                    }
                default:
                    break;
            }
          
            counter = 0;
            if (subcontractors.Count == 0)
            {
                MessageBox.Show("Нет данных!");
                FirstValue.Text = "";
                SecondValue.Text = "";
                subcontractors = module.GetAllSubcontactors();
            }
            if (subcontractors.Count == 0)
                MessageBox.Show("Ошибка!");
            else
                Show(subcontractors[counter]);

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
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FilterByEmployers_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFilter.AmountOfEmployers;
            TopMenuItem.Header = "Фильтрация по заказчикам";
        }

        private void FilterByUNP_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToFilter.UNP;
            TopMenuItem.Header = "Фильтрация по УНП";
        }
    }
}

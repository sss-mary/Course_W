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
    /// Логика взаимодействия для Sort.xaml
    /// </summary>
    enum ParamToSort
    {
        Name,
        AmountOfEmployers,
        UNP,
        Rating
    }
    public partial class Sort : Window
    {
        int counter = 0;
        ParamToSort choosenParam;
        private IDataViewAccess module;
        List<DatabaseEntities.Subcontractor> subcontractors;
        public Sort(IDataViewAccess module)
        {
            choosenParam = ParamToSort.Name;
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

        private void SortByName_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToSort.Name;
            TopMenuItem.Header = "Сортировка по названию";
            subcontractors = subcontractors.OrderBy(c => c.Name).ToList();
        }

        private void SortByRating_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToSort.Rating;
            TopMenuItem.Header = "Сортировка по рейтингу";
            subcontractors = subcontractors.OrderByDescending(c => c.TotalRate).ToList();
        }

        private void FindSome_Click(object sender, RoutedEventArgs e)
        {
            if (subcontractors.Count == 0)
                MessageBox.Show("Ошибка!");
            else
                Show(subcontractors[0]);
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

        private void SortByEmployers_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToSort.AmountOfEmployers;
            TopMenuItem.Header = "Сортировка по заказчикам";
            subcontractors = subcontractors.OrderByDescending(c => c.AmountOfEmployees).ToList();
        }

        private void SortByUNP_Click(object sender, RoutedEventArgs e)
        {
            choosenParam = ParamToSort.UNP;
            TopMenuItem.Header = "Сортировка по УНП";
            subcontractors = subcontractors.OrderByDescending(c => c.UNP).ToList();
        }
    }
}

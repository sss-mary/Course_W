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
    /// Логика взаимодействия для ExpertMethod2.xaml
    /// </summary>
    public partial class ExpertMethod2 : Window
    {
        private IExpertAccess module;
        public ExpertMethod2(IExpertAccess module)
        {
            this.module = module;
            InitializeComponent();

            R1.Text = "";
            R2.Text = "";
            R3.Text = "";
            R4.Text = "";
            R5.Text = "";
        }

        private void Button_OK(object sender, RoutedEventArgs e)
        {
            if (R1.Text == "100" || R2.Text == "100" || R3.Text == "100" || R4.Text == "100" || R5.Text == "100")
            {
                int vendoreCode1, vendoreCode2, vendoreCode3, vendoreCode4, vendoreCode5;
                try
                {
                    vendoreCode1 = int.Parse(R1.Text);
                    vendoreCode2 = int.Parse(R2.Text);
                    vendoreCode3 = int.Parse(R3.Text);
                    vendoreCode4 = int.Parse(R4.Text);
                    vendoreCode5 = int.Parse(R5.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный ввод!");
                    return;
                }

                if (int.Parse(R1.Text) > 100 || int.Parse(R2.Text) > 100 || int.Parse(R3.Text) > 100 || int.Parse(R4.Text) > 100 || int.Parse(R5.Text) > 100)
                {
                    MessageBox.Show("Неверный ввод! Значения не могут быть больше 100.");
                }
                else
                {
                    // проверка заполнения полей
                    int[] mas = { int.Parse(R1.Text), int.Parse(R2.Text), int.Parse(R3.Text), int.Parse(R4.Text), int.Parse(R5.Text) };
                    mas = mas.OrderByDescending(i => i).ToArray();
                    bool res = true;
                    for (int i = 0; i < mas.Length; i++)
                    {
                        int sum = 0;
                        for (int j = i + 1; j < mas.Length; j++)
                        {
                            if (j == mas.Length) break;
                            sum += mas[j];
                        }
                        if (mas[i] < sum)
                        {
                            res = false;
                            break;
                        }
                    }
                    // проверка заполнения полей

                    if (res == true)
                    {
                        int sum = int.Parse(R1.Text) + int.Parse(R2.Text) + int.Parse(R3.Text) + int.Parse(R4.Text) + int.Parse(R5.Text);

                        double W1, W2, W3, W4, W5;

                        W1 = Math.Round(double.Parse(R1.Text) / sum, 2);
                        W2 = Math.Round(double.Parse(R2.Text) / sum, 2);
                        W3 = Math.Round(double.Parse(R3.Text) / sum, 2);
                        W4 = Math.Round(double.Parse(R4.Text) / sum, 2);
                        W5 = Math.Round(double.Parse(R5.Text) / sum, 2);

                        w1.Text = W1.ToString();
                        w2.Text = W2.ToString();
                        w3.Text = W3.ToString();
                        w4.Text = W4.ToString();
                        w5.Text = W5.ToString();

                        Tw1.Text = "w1";
                        Tw2.Text = "w2";
                        Tw3.Text = "w3";
                        Tw4.Text = "w4";
                        Tw5.Text = "w5";

                        var map = new Dictionary<string, double>();

                        map.Add("w1", W1);
                        map.Add("w2", W2);
                        map.Add("w3", W3);
                        map.Add("w4", W4);
                        map.Add("w5", W5);

                        Res.Text = "Лучший вариант: " + map.OrderByDescending(key => key.Value).First().Key + " = " + map.OrderByDescending(key => key.Value).First().Value.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Не соблюдено правило метода.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Одно из полей должно быть равным 100!");
            }
        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {

            R1.Text = "";
            R2.Text = "";
            R3.Text = "";
            R4.Text = "";
            R5.Text = "";

            w1.Text = "";
            w2.Text = "";
            w3.Text = "";
            w4.Text = "";
            w5.Text = "";

            Tw1.Text = "";
            Tw2.Text = "";
            Tw3.Text = "";
            Tw4.Text = "";
            Tw5.Text = "";

            Res.Text = "";
        }

        private void Button_Out(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

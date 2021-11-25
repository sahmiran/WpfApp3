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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        double tempvalue = 0;
        public MainWindow()
        {
            InitializeComponent();
            txtBox.Text = "50 + 8 / 5 * 4 - 10";
        }

        private void HesaplaBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] bolunmusDizi = txtBox.Text.Split(" ");
            List<string> bolunmusList = bolunmusDizi.ToList();

            foreach (string value in bolunmusDizi)
            {
                if (value == "*")
                {

                    tempvalue = Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("*") - 1]) * Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("*") + 1]);

                    int cx = bolunmusList.IndexOf("*");

                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.Insert(cx - 1, tempvalue.ToString());


                    bolunmusDizi = bolunmusList.ToArray();

                }
            }
            foreach (string value in bolunmusDizi)
            {
                if (value == "/")
                {
                    tempvalue = Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("/") - 1]) / Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("/") + 1]);

                    int cx = bolunmusList.IndexOf("/");

                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.Insert(cx - 1, tempvalue.ToString());

                    bolunmusDizi = bolunmusList.ToArray();
                }
            }
            foreach (string value in bolunmusDizi)
            {
                if (value == "+")
                {
                    tempvalue = Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("+") - 1]) + Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("+") + 1]);

                    int cx = bolunmusList.IndexOf("+");

                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.Insert(cx - 1, tempvalue.ToString());

                    bolunmusDizi = bolunmusList.ToArray();
                }
            }
            foreach (string value in bolunmusDizi)
            {
                if (value == "-")
                {
                    tempvalue = Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("-") - 1]) - Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("-") + 1]);

                    int cx = bolunmusList.IndexOf("-");

                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.Insert(cx - 1, tempvalue.ToString());

                    bolunmusDizi = bolunmusList.ToArray();
                }

                if (bolunmusDizi.Length == 1) break;
            }

            txtBox.Text = txtBox.Text + "=" + bolunmusDizi[0];

        }

           

        
    }
}

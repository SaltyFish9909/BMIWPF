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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.Write("Height(m):");
            string height = Console.ReadLine();
            Console.Write("Weight(kg):");
            string weight = Console.ReadLine();

            double BMI = double.Parse(weight) / (double.Parse(height) * double.Parse(height));
            Console.WriteLine("BMI: " + BMI.ToString());

            if (BMI < 18.5)
            {
                Console.WriteLine("體重過輕");
            }
            if (BMI <= 18.5 && BMI < 24)
            {
                Console.WriteLine("正常範圍");
            }
            if (BMI > 24)
            {
                Console.WriteLine("過重");
            }
            if (BMI < 16.5)
            {
                Console.WriteLine("免役");
            }
            if (BMI > 31.5)
            {
                Console.WriteLine("免役");
            }
            Console.ReadLine();
        }
    }
}

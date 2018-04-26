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

        private void HeightClearBtn_Click(object sender, RoutedEventArgs e)
        {
            //清空
            HeightBox.Text = "";
            
            //使Textbox清空后变色
            //HeightBox.Background = Brushes.Red;
        }

        private void WeightClearBtn_Click(object sender, RoutedEventArgs e)
        {
            //清空
            WeightBox.Text = "";
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            //计算BMI
            double w = double.Parse(WeightBox.Text);
            double h = double.Parse(HeightBox.Text) / 100 ;
            double BMI = w / (h * h);
            
            TextBlock.Text = BMI.ToString();

        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightBox.Text = slider.Value.ToString();

            double w = double.Parse(WeightBox.Text);
            double h = double.Parse(HeightBox.Text) / 100;
            double BMI = w / (h * h);

            TextBlock.Text = BMI.ToString();
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            WeightBox.Text = slider2.Value.ToString();

            double w = double.Parse(WeightBox.Text);
            double h = double.Parse(HeightBox.Text) / 100;
            double BMI = w / (h * h);

            TextBlock.Text = BMI.ToString();
        }
    }
}

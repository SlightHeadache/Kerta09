using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _9_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void EuroButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrorTextBlock.Text = "";
                double num = double.Parse(textBox.Text);
                num = num / 5.94573;
                textBox.Text = num.ToString("0.00") + " €";
            }
            catch(FormatException)
            {
                ErrorTextBlock.Text = "Invalid input";
            }
        }

        private void MarkkaButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrorTextBlock.Text = "";
                double num = double.Parse(textBox.Text);
                num = num * 5.94573;
                textBox.Text = num.ToString("0.00") + " mk";
            }
            catch (FormatException)
            {
                ErrorTextBlock.Text = "Invalid input";
            }
        }
    }
}

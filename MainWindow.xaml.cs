using System;
using System.Windows;
using System.Windows.Input;

namespace CatYearsXAMLDemo
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            try
            {
                int inputCatAge = Int32.Parse(InputCatAge.Text);
                string resultHumanAge = "";

                if (inputCatAge >= 0 && inputCatAge <= 1)
                {
                    resultHumanAge = "0~15";
                    ResultTextBlock.Text = "Your cat is " + resultHumanAge + " years old";
                    InputCatAge.Clear();
                    InputCatAge.Focus();
                }
                else if (inputCatAge >= 2 && inputCatAge < 25)
                {
                    resultHumanAge = (((inputCatAge - 2) * 4) + 24).ToString();
                    ResultTextBlock.Text = "Your cat is " + resultHumanAge + " years old";
                    InputCatAge.Clear();
                    InputCatAge.Focus();
                }
                else
                {
                    ResultTextBlock.Text = "Your cat must be super old or not yet born!";
                    InputCatAge.Clear();
                    InputCatAge.Focus();
                }
            }
            catch (Exception myException)
            {
                MessageBox.Show("Not a valid number, please enter a numeric value!", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void InputCatAge_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Calculate();
            }
        }

        private void calculate_btn_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }
    }
}

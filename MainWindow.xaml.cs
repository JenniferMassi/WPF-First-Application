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

namespace WPF_First_Application {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            int userInput1 = int.Parse(txt1.Text);
            int userInput2 = int.Parse(txt2.Text);

            int addedNumbers = userInput1 + userInput2;

            lblOutput.Content = "The total is " + addedNumbers.ToString();

            
        }//END FUNCTION

        private void Button_Click_1(object sender, RoutedEventArgs e) {

            txt1.Clear();
            txt2.Clear();
            lblOutput.Content = "";
            //.Content 
            
        }//END FUNCTION
    }
}

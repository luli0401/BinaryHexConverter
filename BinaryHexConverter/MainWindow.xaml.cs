using BinaryHexConverter.Processor;
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

namespace BinaryHexConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            HexProcessor = new HexProcessor();
            BinaryProcessor = new BinaryProcessor();
            IntegerProcessor = new IntegerProcessor();
        }

        public BinaryProcessor BinaryProcessor { get; set; }
        public HexProcessor HexProcessor { get; set; }
        public IntegerProcessor IntegerProcessor { get; set; }

        private void ConvertExecute(object sender, RoutedEventArgs e)
        {
            var input = InputTextBox.Text;

            if (IsHex.IsChecked == true)
            {
                BinaryTextBox.Text = HexProcessor.ConvertToBinary(input);
                IntegerTextBox.Text = HexProcessor.ConvertToInteger(input);
            }
            else if (IsBinary.IsChecked == true)
            {
                IntegerTextBox.Text = string.Empty;
                HexTextBox.Text = string.Empty;
            }
            else if (IsInteger.IsChecked == true)
            {

            }
        }

        private void RefreshExecute(object sender, RoutedEventArgs e)
        {
            BinaryTextBox.Text = string.Empty;
            IntegerTextBox.Text = string.Empty;
            HexTextBox.Text = string.Empty;
            InputTextBox.Text = string.Empty;
        }
    }
}

using BinaryHexConverter.Helper;
using BinaryHexConverter.Processor;
using System.Windows;
using System.Windows.Controls;

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

        private void RefreshExecute(object sender, RoutedEventArgs e)
        {
            BinaryTextBox.Text = string.Empty;
            IntegerTextBox.Text = string.Empty;
            HexTextBox.Text = string.Empty;
        }

        private void HexTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var input = HexTextBox.Text;

            if (!string.IsNullOrEmpty(input))
            {
                if (HexProcessor.IsHexNumber(input))
                {
                    var hexValue = HexProcessor.ConvertToHex(input);

                    IntegerTextBox.Text = hexValue.ToString();
                    BinaryTextBox.Text = hexValue.ToBinaryString();
                }
            }
            else
            {
                RefreshExecute(null, null);
            }
        }

        private void IntegerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var input = IntegerTextBox.Text;

            if (!string.IsNullOrEmpty(input))
            {
                var integerValue = 0;

                if(IntegerProcessor.IsInteger(input, out integerValue))
                {
                    HexTextBox.Text = integerValue.ToHexString();
                    BinaryTextBox.Text = integerValue.ToBinaryString();
                }
            }
            else
            {
                RefreshExecute(null, null);
            }
        }

        private void BinaryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var input = BinaryTextBox.Text;

            if (!string.IsNullOrEmpty(input))
            {
                var binaryValue = BinaryProcessor.ConvertToBinary(input);

                if (binaryValue != 2)
                {
                    IntegerTextBox.Text = binaryValue.ToString();
                    HexTextBox.Text = binaryValue.ToHexString();
                }
            }
            else
            {
                RefreshExecute(null, null);
            }
        }
    }
}

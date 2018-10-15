using BinaryHexConverter.Helper;
using BinaryHexConverter.Processor;
using System.Windows;
using System.Windows.Controls;

namespace BinaryHexConverter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            HexProcessor = new HexProcessor();
            BinaryProcessor = new BinaryProcessor();
            IntegerProcessor = new IntegerProcessor();
            HistoryProcessor = new HistoryProcessor();

            ReadFromClipboard();
        }

        //Properties
        private const string ERROR_MESSAGE = "Format Error!";

        private BinaryProcessor BinaryProcessor { get; set; }
        private HexProcessor HexProcessor { get; set; }
        private IntegerProcessor IntegerProcessor { get; set; }
        private HistoryProcessor HistoryProcessor { get; set; }


        //Methods
        private void RefreshExecute(object sender, RoutedEventArgs e)
        {
            BinaryTextBox.Text = string.Empty;
            IntegerTextBox.Text = string.Empty;
            HexTextBox.Text = string.Empty;
            BinaryNibbles.Text = string.Empty;
            ErrorMessage.Text = string.Empty;
        }

        private void HexTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var input = HexTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(input))
            {
                if (HexProcessor.IsHexNumber(input))
                {
                    var hexValue = HexProcessor.ConvertToHex(input);

                    IntegerTextBox.Text = hexValue.ToString();
                    BinaryTextBox.Text = hexValue.ToBinaryString();
                    PostConvertion(input);
                }
                else
                {
                    ErrorMessage.Text = ERROR_MESSAGE;
                }
            }
            else
            {
                RefreshExecute(null, null);
            }
        }

        private void IntegerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var input = IntegerTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(input))
            {
                var integerValue = 0;

                if (IntegerProcessor.IsInteger(input, out integerValue))
                {
                    HexTextBox.Text = integerValue.ToHexString();
                    BinaryTextBox.Text = integerValue.ToBinaryString();
                    PostConvertion(input);
                }
                else
                {
                    ErrorMessage.Text = ERROR_MESSAGE;
                }
            }
            else
            {
                RefreshExecute(null, null);
            }
        }

        private void BinaryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var input = BinaryTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(input))
            {
                if (BinaryProcessor.IsBinaryNumber(input))
                {
                    var binaryValue = BinaryProcessor.ConvertToBinary(input);

                    IntegerTextBox.Text = binaryValue.ToString();
                    HexTextBox.Text = binaryValue.ToHexString();
                    PostConvertion(input);
                }
                else
                {
                    ErrorMessage.Text = ERROR_MESSAGE;
                }
            }
            else
            {
                RefreshExecute(null, null);
            }
        }

        private void PostConvertion(string input)
        {
            BinaryNibbles.Text = BinaryProcessor.ConvertToNibbles(BinaryTextBox.Text);
            ErrorMessage.Text = string.Empty;

            HistoryList.ItemsSource = HistoryProcessor.SaveInput(input);
        }

        private void ReadFromClipboard()
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string copiedText = Clipboard.GetText(TextDataFormat.Text).Trim();

                if (BinaryProcessor.IsBinaryNumber(copiedText))
                {
                    BinaryTextBox.Text = copiedText;
                }
                else if (HexProcessor.IsHexNumber(copiedText))
                {
                    HexTextBox.Text = copiedText;
                }
                else if (IntegerProcessor.IsInteger(copiedText, out int intNumber))
                {
                    IntegerTextBox.Text = copiedText;
                }
            }
        }

    }
}

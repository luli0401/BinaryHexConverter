using BinaryHexConverter.Processor;
using System.Windows;

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
                HexTextBox.Text = input;
            }
            else if (IsBinary.IsChecked == true)
            {
                IntegerTextBox.Text = BinaryProcessor.ConvertToInteger(input);
                HexTextBox.Text = BinaryProcessor.ConvertToHex(input);
                BinaryTextBox.Text = input;
            }
            else if (IsInteger.IsChecked == true)
            {
                HexTextBox.Text = IntegerProcessor.ConvertToHex(input);
                BinaryTextBox.Text = IntegerProcessor.ConvertToBinary(input);
                IntegerTextBox.Text = input;
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

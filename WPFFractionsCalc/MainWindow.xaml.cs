using System.Windows;
using System.Windows.Controls;
// own fraction library
using LibraryFractions;

namespace WPFFractionsCalculator
{
    public partial class MainWindow : Window
    {
        public Fraction? LeftFrac { get; set; }
        public Fraction? RightFrac { get; set; }
        public bool IsErrorFrac { get; set; } = false;
        public bool IsInvalidFrac { get; set; } = false;

        public MainWindow()
        {
            InitializeComponent();
            Task.Run(BackgroundLoop);
        }

        public void Calculate()
        {
            if (mode == Mode.Operations && (LeftFrac is not null || RightFrac is not null)) Operation_func();
            else if (mode == Mode.Reciprocal && (LeftFrac is not null)) Reciprocal_func();
            else if (mode == Mode.Invert && (LeftFrac is not null)) Invert_func();
        }
        private void Ops_clicked(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "AdditionBtn") operation = Ops.Subtraction;
            else if (button.Name == "SubtractionBtn") operation = Ops.Multiplication;
            else if (button.Name == "MultiplicationBtn") operation = Ops.Division;
            else if (button.Name == "DivisionBtn") operation = Ops.Addition;
        }
        private void Mode_clicked(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "OperationsBtn") mode = Mode.Operations;
            else if (button.Name == "ReciprocalBtn") mode = Mode.Reciprocal;
            else if (button.Name == "InvertBtn") mode = Mode.Invert;
        }
        private bool CheckForZero() => (!int.TryParse(LeftDenominator.Text, out int left) || left is 0) || (!int.TryParse(RightDenominator.Text, out int right) || right is 0); 
        private void Operation_func()
        {
            if (LeftFrac is null || RightFrac is null) return;
            if (CheckForZero())
            {
                if(!IsErrorFrac)MessageBox.Show("Denominator('s) can't be zero");
                SetResultEmpty();
                IsErrorFrac = true;
                return;
            }
            if (operation == Ops.Addition) SetResult(LeftFrac.Add(RightFrac));
            else if (operation == Ops.Subtraction) SetResult(LeftFrac.Subtract(RightFrac));
            else if (operation == Ops.Multiplication) SetResult(LeftFrac.Multiply(RightFrac));
            else if (operation == Ops.Division) SetResult(LeftFrac.Divide(RightFrac));
        }
        private void Reciprocal_func()
        {
            if (LeftFrac is null) return;
            SetResult(LeftFrac.Reciprocal());
        }
        private void Invert_func()
        {
            if (LeftFrac is null) return;
            SetResult(LeftFrac.Invert());
        }
        private async Task BackgroundLoop()
        {
            while (true)
            {
                await Task.Delay(250);
                await Dispatcher.InvokeAsync(() =>
                {
                    CheckSetOperationVisibility();
                    CheckSetModeVisibility();
                    try
                    {
                        if (!string.IsNullOrEmpty(LeftDenominator.Text) && !string.IsNullOrEmpty(LeftNumerator.Text)) LeftFrac = new(int.Parse(LeftNumerator.Text), int.Parse(LeftDenominator.Text));
                        if (!string.IsNullOrEmpty(RightDenominator.Text) && !string.IsNullOrEmpty(RightNumerator.Text)) RightFrac = new(int.Parse(RightNumerator.Text), int.Parse(RightDenominator.Text));
                        if (string.IsNullOrEmpty(LeftDenominator.Text) && string.IsNullOrEmpty(LeftNumerator.Text) && string.IsNullOrEmpty(RightDenominator.Text) && string.IsNullOrEmpty(RightNumerator.Text)) SetResultEmpty();
                        IsInvalidFrac = false;
                    }
                    catch (FormatException)
                    {
                        if(!IsInvalidFrac) MessageBox.Show("Invalid input");
                        IsInvalidFrac = true;
                        return;
                    }
                    Calculate();
                });
            }
        }
        private void SetResult(Fraction fraction)
        {
            IsErrorFrac = false;
            ResultNumerator.Text = fraction.Numerator.ToString();
            ResultDenominator.Text = fraction.Denominator.ToString();
        }
        public static void SetButtonVisibility(Button button, bool visible) => button.Visibility = visible ? Visibility.Visible : Visibility.Collapsed;
        public void CheckSetOperationVisibility()
        {
            SetButtonVisibility(AdditionBtn, operation == Ops.Addition);
            SetButtonVisibility(SubtractionBtn, operation == Ops.Subtraction);
            SetButtonVisibility(MultiplicationBtn, operation == Ops.Multiplication);
            SetButtonVisibility(DivisionBtn, operation == Ops.Division);
        }
        private Ops operation = Ops.Addition;

        private Mode mode = Mode.Operations;
        private static void SetStackpanelVisibility(StackPanel stackPanel, bool visible) => stackPanel.Visibility = visible ? Visibility.Visible : Visibility.Collapsed;
        public void CheckSetModeVisibility()
        {
            SetStackpanelVisibility(Operation, mode == Mode.Operations);
            SetStackpanelVisibility(RightFraction, mode == Mode.Operations);
        }
        private void SetResultEmpty()
        {
            ResultNumerator.Text = "";
            ResultDenominator.Text = "";
        }
    }
}
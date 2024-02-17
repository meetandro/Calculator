using CalculatorMain;

namespace CalculatorApp;

public partial class CalculatorApp : Form
{
    public CalculatorApp()
    {
        InitializeComponent();
    }

    private void DigitButton_Click(object sender, EventArgs e)
    {
        Button digitButton = (Button)sender;
        char digit = digitButton.Text[0];

        if (digit.Equals('0')) ResultLabel.Text = Calculator.TryAddDigitToExpression(ResultLabel.Text);

        else ResultLabel.Text = Calculator.TryAddDigitToExpression(ResultLabel.Text, digit);
    }

    private void OperationButton_Click(Object sender, EventArgs e)
    {
        Button operationButton = (Button)sender;
        char operation = operationButton.Text[0];

        ResultLabel.Text = Calculator.TryAddOperationToExpression(ResultLabel.Text, operation);
    }

    private void EqualsButton_Click(object sender, EventArgs e)
    {
        if (Calculator.IsCorrectFormat(ResultLabel.Text))
        {
            ExpressionLabel.Text = $"{ResultLabel.Text} =";
            ResultLabel.Text = Calculator.Calculate(ResultLabel.Text.Replace("X", "*"));
        }
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        ExpressionLabel.Text = string.Empty;
        ResultLabel.Text = string.Empty;
    }
}
using System.Data;

namespace CalculatorMain;

public static class Calculator
{
    public static string? Calculate(string expression) => Convert.ToString(new DataTable().Compute(expression, ""));

    public static string TryAddDigitToExpression(string expression)
    {
        if (string.IsNullOrEmpty(expression))
        {
            return "0";
        }
        else if (expression.Equals("0") || expression.EndsWith(" 0") || expression.EndsWith("/ "))
        {
            return expression;
        }
        return expression + '0';
    }

    public static string TryAddDigitToExpression(string expression, char digit)
    {
        if (expression.Equals("0") || expression.EndsWith(" 0"))
        {
            return expression;
        }
        return expression + digit;
    }

    public static string TryAddOperationToExpression(string expression, char operation)
    {
        if (string.IsNullOrEmpty(expression) || expression.EndsWith(' '))
        {
            return expression;
        }
        return expression + $" {operation} ";
    }

    public static bool IsCorrectFormat(string expression)
    {
        if (string.IsNullOrEmpty(expression) || expression.EndsWith(' '))
        {
            return false;
        }
        return true;
    }
}
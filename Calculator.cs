using System.Data;

namespace CalculatorMain;

public static class Calculator
{
    public static string? Calculate(string expression)
    {
        return Convert.ToString(new DataTable().Compute(expression, ""));
    }

    public static string TryAddDigitToExpression(string expression)
    {
        if (string.IsNullOrEmpty(expression)) return "0";

        else if (expression.Equals("0") || expression.EndsWith(" 0") || expression.EndsWith("/ ")) return expression;

        return $"{expression}0";
    }

    public static string TryAddDigitToExpression(string expression, char digit)
    {
        return expression.Equals("0") || expression.EndsWith(" 0") ? expression : $"{expression}{digit}";
    }

    public static string TryAddOperationToExpression(string expression, char operation)
    {
        return string.IsNullOrEmpty(expression) || expression.EndsWith(' ') ? expression : $"{expression} {operation} ";
    }

    public static bool IsCorrectFormat(string expression)
    {
        return !string.IsNullOrEmpty(expression) && !expression.EndsWith(' ');
    }
}
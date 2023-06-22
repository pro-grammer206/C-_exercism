public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        string result = "{0} {1} {2} = {3}";
        try
        {
            if (operand2 == 0 && operation == "/") throw new DivideByZeroException("Division by zero is not allowed.");
        }
        catch (DivideByZeroException e)
        {
            return e.Message;
        }

        switch (operation)
        {
            case "":
                throw new ArgumentException();
            case null:
                throw new ArgumentNullException();
            case "+":
                result = string.Format(result, operand1, operation, operand2, SimpleOperation.Addition(operand1, operand2));
                break;
            case "*":
                result = string.Format(result, operand1, operation, operand2, SimpleOperation.Multiplication(operand1, operand2));
                break;
            case "/":
                result = string.Format(result, operand1, operation, operand2, SimpleOperation.Division(operand1, operand2));
                break;
            default:
                throw new ArgumentOutOfRangeException();

        }
        return result;
    }
}



public static class SimpleOperation
{
    public static int Division(int operand1, int operand2)
    {
        if (operand2 == 0) throw new DivideByZeroException("Divide by zero is not allowed.");
        return operand1 / operand2;
    }

    public static int Multiplication(int operand1, int operand2)
    {
        return operand1 * operand2;
    }

    public static int Addition(int operand1, int operand2)
    {
        return operand1 + operand2;
    }
}

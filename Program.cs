// See https://aka.ms/new-console-template for more information

class PasswordGenerator
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many characters does your password need to be?");

        var passLength = new string(Console.ReadLine());

        int returnCase = new Int(caseParameter);

        return;
    }

    static int caseParameter(int parameter)
    {
        Console.WriteLine("Great! Does your password need special case?");
        Console.WriteLine("1. Uppercase");
        Console.WriteLine("2. Lowercase");
        Console.WriteLine("3. Mix");

        while (true)
        {
            if (parameter == 1)
            {
                parameter = 1; 
                break;
            }
            if (parameter == 2)
            {
                parameter = 2;
                break;
            }
            if (parameter == 3)
            {
                parameter = 3;
                break;
            }
        }
    }
}
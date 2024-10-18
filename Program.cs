// See https://aka.ms/new-console-template for more information

class PasswordGenerator
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many characters does your password need to be?");

        var passLength = new string(Console.ReadLine());

        int returnCase = CaseParameter();

        return;
    }

    static int CaseParameter()
    {
        Console.WriteLine("Great! Does your password need special case?");
        Console.WriteLine("1. Uppercase");
        Console.WriteLine("2. Lowercase");
        Console.WriteLine("3. Mix");

        int parameter = 0;

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
            else 
            {
                parameter = 0;
                break; 
            }

            return parameter;
        }
    }
}
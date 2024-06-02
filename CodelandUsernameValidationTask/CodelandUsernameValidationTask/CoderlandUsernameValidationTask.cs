using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CodelandUsernameValidationTask {
    public static bool CodelandUsernameValidation(string str)
    {

        // code goes here 
        return str.Length >= 4 && str.Length <= 25;

    }

    public static char test()
    {
        String str = "Hello World";
        return str[0];
    }

    static void Main()
    {

        // keep this function call here
        Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));

        Console.WriteLine(test());
    }
}
    


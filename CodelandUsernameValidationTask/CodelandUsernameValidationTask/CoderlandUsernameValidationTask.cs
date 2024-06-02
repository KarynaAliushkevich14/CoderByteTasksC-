using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CodelandUsernameValidationTask {
    public static bool CodelandUsernameValidation(string str)
    {

        // code goes here
        int strLength = str.Length;
        bool isLastLetterNotUnderscore = str[strLength - 1] != '_';

        return strLength >= 4 && strLength <= 25 && char.IsLetter(str[0]) && isLastLetterNotUnderscore
          && IsStringContainsOnlyRequiredSymbols(str);

    }

    public static bool IsStringContainsOnlyRequiredSymbols(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (!char.IsLetterOrDigit(ch) && ch != '_')
            {
                return false;
            }
        }
        return true;
    }


    static void Main()
    {
        // keep this function call here
        Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
    }
}
    


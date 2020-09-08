using System;
using System.Collections.Generic;

namespace CS_Sample_Tests_Console
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the string that needs to be processed");

            var stringToBeProcessed = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(stringToBeProcessed))
                    Console.WriteLine("Input String Empty. Enter Non-Empty String");
            
            ProcessString(stringToBeProcessed);        


        }

        static void ProcessString(string stringToBeProcessed)
        {
            
            var stringToBeProcessedArray = stringToBeProcessed.ToCharArray();        
            var alphabetTable = new Dictionary<string,int>();

            foreach(char ch in stringToBeProcessedArray)
            {
                var byteValue = (byte)ch;
                if((byteValue > 64 && byteValue < 91) || (byteValue > 96 && byteValue < 123))
                {
                    var key = char.ToUpper(ch).ToString();
                    if(alphabetTable.ContainsKey(key))
                    {
                        alphabetTable[key]++;
                    }
                    else{
                        alphabetTable.Add(key,1);
                    }
                }
            }
            var alphabetString = string.Empty;
            var alphabetCountString = string.Empty;

            for(int asciiValue = 65 ; asciiValue < 91; asciiValue++)
            {
                char alphabet = Convert.ToChar(asciiValue);
                alphabetString += alphabet;
                var alphabetCount =  alphabetTable.ContainsKey(alphabet.ToString())? alphabetTable[alphabet.ToString()]: 0;
                alphabetCountString += alphabetCount;
                
            }
            Console.WriteLine();
            Console.WriteLine(alphabetString);
            Console.WriteLine(alphabetCountString);
            Console.WriteLine();

            var totalLetterCount = 0;

            foreach(var value in alphabetTable.Values)
            {
                totalLetterCount+= value;
            }
            Console.WriteLine($"Total letters counted: {totalLetterCount}");
            Console.WriteLine();
        }





       static int digitsManipulations(int n) {

        if(n <= 0)
            return 0;
            
            if(n >= 1 && n<= 9)
                return 0;
                
            var product = 1;

            var sum = 0;

            var temp = n;

            var digit = 0;

            while(temp > 0)
            {
                digit = temp % 10;
                product *= digit;
                sum += digit;
                temp = temp/10;
            }

            return product - sum;

}
    }
}

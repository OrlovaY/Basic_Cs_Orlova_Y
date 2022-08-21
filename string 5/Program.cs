// string5. Определить являются ли введенные с клавиатуры символы 
//правильно записью целого числа. 
//Вычислить сумму цифр введенного числа

using System;
 
namespace Sem8
{
    class Program
    {
        static void Main(string[] args) 
        {
            string? s = Console.ReadLine();
            int temper = 0;
                
                if (!Int32.TryParse(s, out temper))
                    
                    {
                        Console.WriteLine("Это не является верной записью целого");
                    }
                else 
                    {
                        int sum = 0;
                        foreach (char digit in s)
                        sum += digit - 48;
                Console.WriteLine(sum);
                    }
        }
    }
}
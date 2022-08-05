// Подсчитать сумму цифр в числе

int a = 1111; //int a=int.Parse(Console.ReadLine()); для ввода числа с клавиатуры
            int s = 0;
            while (a > 0)
            {
 
                s = s + a % 10;
                a = a /10 ;
 
            }
 Console.WriteLine(s);

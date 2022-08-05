// Показать кубы чисел, заканчивающихся на четную цифру
int[] array = new int[] {12,4,45,34,73,12};
int i=0;
double pow=Math.Pow(array[i],3);
for(i=0;i<array.Length;i++)

    if((array[i] % 2) == 0) 
    {
    pow=Math.Pow(array[i],3);
    System.Console.WriteLine($"{pow}");
    }


else
{
    System.Console.WriteLine("Число заканчивается на нечетную цифру");
}
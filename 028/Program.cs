// Определить количество цифр в числе. Сделать подпрограмму.

System.Console.WriteLine(CountDigits(1245));






int CountDigits(int N)

{
    int k=0;
    while (N!=0)
    {
        //k=k+1;
        k++;
        //N=N/10;
        N/=10;
    }
    return k;
}



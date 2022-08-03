// Определить количество цифр в числе. Сделать подпрограмму.

System.Console.WriteLine(CountDigits(0));






int CountDigits(int N)

{
    if (N==0) return 1;
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



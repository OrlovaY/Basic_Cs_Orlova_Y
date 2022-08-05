// Возведите число А в натуральную степень B используя цикл
/*
int A=1;
int B=3;
double pow=Math.Pow(A,B);
System.Console.WriteLine(pow);
*/

int A=3;
int B=3;
int b = 1;
for(int i=1;i<=B;i++) 
{
   b *= A; //b=b*A; 
}
System.Console.WriteLine(b);
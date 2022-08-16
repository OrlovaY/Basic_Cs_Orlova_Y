/*
ConsoleKeyInfo ck;
do
{
    ck=Console.ReadKey();
    System.Console.WriteLine((int)ck.KeyChar);
    System.Console.WriteLine("IsDigit:"+char.IsDigit(ck.KeyChar));
    System.Console.WriteLine("IsControl:"+char.IsControl(ck.KeyChar));
    System.Console.WriteLine("IsLetter:"+char.IsLetter(ck.KeyChar));
    
}
while(ck.Key!=ConsoleKey.Escape);

string s="s";

System.Console.WriteLine('a'.ToString()+'b');
if (c>='A' && c<='Z') System.Console.WriteLine("Latin");
if (c>='a' && c<='z') System.Console.WriteLine("Latin");

System.Diagnostics.Stopwatch stopwatch=new System.Diagnostics.Stopwatch();
stopwatch.Start();
string s="";
*/

/*
for(int i=0;i<30000;i++)
    s=s+"abcdefghijklmnopqrstvwxyz";
stopwatch.Stop();
System.Console.WriteLine(stopwatch.ElapsedMilliseconds);    
stopwatch.Reset();
stopwatch.Start();
System.Text.StringBuilder sb=new System.Text.StringBuilder("");
for(int i=0;i<30000;i++)
    sb.Append("abcdefghijklmnopqrstvwxyz");
stopwatch.Stop();
System.Console.WriteLine(stopwatch.ElapsedMilliseconds);    
*/
/*
// 1. Вывести на экран кодировку символов по ASCII(с 32 до 122)

string s;
for (int i = 32; i <= 122;i++)
{ 
    System.Console.Write((char)i); 
}
*/

/*
// Вывести на экран символы от A до Z как показано ниже: 
//A 
//BB 
//CCC 
for(int i = 65; i <= 90;i++)
{
    for(int j = 0; j <i-64 ;j++)

System.Console.Write((char)i);
System.Console.WriteLine();
}
*/

//Подсчитать количество цифр среди вводимых с клавиатуры символов
string s=Console.ReadLine();
int sum=0;
for(int i=0;i<s.Length;i++)
    //if (s[i]>='0' && s[i]<='9')
    if (char.IsDigit(s[i])) 
        sum=sum+ (int)(char.GetNumericValue(s[i])); //sum=sum+1
System.Console.WriteLine(sum);

// Задать номер четверти, показать диапазоны для возможных координат

int qNum;
qNum=Convert.ToInt32(Console.ReadLine());
if (qNum==1)
{
    System.Console.WriteLine("x>0; y>0");
}
else if (qNum==2)
{
    System.Console.WriteLine("x<0; y>0");
}
else if (qNum==3)
{
    System.Console.WriteLine("x<0; y<0");
}
else if (qNum==4)
{
    System.Console.WriteLine("x>0; y<0");
}
else if (qNum>4)
{
    System.Console.WriteLine("Ошибка!");
}
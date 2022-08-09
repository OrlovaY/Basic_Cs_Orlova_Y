// Дано число обозначающее день недели. 
//Выяснить является номер дня недели выходным

int dayOfWeek;
dayOfWeek=Convert.ToInt32(Console.ReadLine());
if (dayOfWeek==6 || dayOfWeek==7)
{
    System.Console.WriteLine("Выходной");
}
else if (dayOfWeek>=1 && dayOfWeek<=5)
{
    System.Console.WriteLine("Рабочий день");
}
else
{
    System.Console.WriteLine("Ошибка! День не найден!");
}



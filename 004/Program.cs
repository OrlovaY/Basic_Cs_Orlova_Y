
//По заданному с клавиатуры номеру дня недели вывести его название
int dayOfWeek;//camelCase - первая буква маленькая, 
//а следующие первые бквы - заглавными
dayOfWeek=Convert.ToInt32(Console.ReadLine());
//dayOfWeek=int.Parse(Console.ReadLine());
if (dayOfWeek==1) Console.WriteLine("Понедельник");
if (dayOfWeek==2) System.Console.WriteLine("Вторник");
if (dayOfWeek==3) System.Console.WriteLine("Среда");
if (dayOfWeek==4) System.Console.WriteLine("Четверг");
if (dayOfWeek==5) System.Console.WriteLine("Пятница");
if (dayOfWeek==6) System.Console.WriteLine("Суббота");
if (dayOfWeek==7) System.Console.WriteLine("Воскресенье"); 




switch(dayOfWeek)
{
    case 1:
        System.Console.WriteLine("Monday");
        break;
    case 2:
        System.Console.WriteLine("Tuesday");
        break;    
case 3:
        System.Console.WriteLine("Wednesday");
        break;  
case 4:
        System.Console.WriteLine("Thursday");
        break;  
case 5:
        System.Console.WriteLine("Friday");
        break;  
case 6:
        System.Console.WriteLine("Saturday");
        break;  
case 7:
        System.Console.WriteLine("Sunday");
        break; 
default:
        System.Console.WriteLine("Wrong!");
        break;
}
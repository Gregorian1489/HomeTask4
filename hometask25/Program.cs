Console.Write("Введите первое число: ");               // Немного позанудствовал в этой задаче, наверное, лишнего)
int num1 = Convert.ToInt32(Console.ReadLine());        // Подскажите пожалуйста, заметил, что у меня не весь синтаксис 
Console.Write("Введите второе число: ");               // подсвечивается (красится в цвет), как у других. 
int num2 = Convert.ToInt32(Console.ReadLine());        // Какой плагин надо установить или что поменять в настройках?
int exp = 1;                                           // Заранее, спасибо!
double exp1 = 1;


if (num2>0)
{
for (int i = 1; i <= num2; i++)
    {
    exp  = exp * num1;
    }
Console.WriteLine($"{num1} в степени {num2} = {exp}");
}
else if (num2<0)
{
for (int j = num2; j < 0; j++)
{
exp1 = exp1*num1;
}
Console.WriteLine($"{num1} в степени {num2} = {1/exp1}");
}
else if ((num2 == 0)&&(num1 != 0))
{
Console.WriteLine($"{num1} в степени {num2} = 1");  
}
else if ((num1 == 0)&&(num2 != 0))
{
Console.WriteLine($"{num1} в степени {num2} = 0");  
}
else if ((num1 == 0)&&(num2 == 0))
{
Console.WriteLine("Выражение не имеет смысла");  
}
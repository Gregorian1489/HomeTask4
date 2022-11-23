//      Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");                // Получилась очень большая портянка, хотелось бы знать, как можно сделать код компактнее
int num = Convert.ToInt32(Console.ReadLine());     // Так же заметил, что Int32 весьма ограничен по кол - ву символов, 
string line = Convert.ToString(num);               // чем его можно заменить, конкретно в методе Convert.ToInt32?
int sum = 0;
if (num<0)
{
    int [] array = new int [line.Length];
    for (int i = 1; i<line.Length;i++)
    {
        array[i-1] = Convert.ToInt32(Convert.ToString(line[i]));
        if (i-1 == 0) array[0] = array[0]* -1;
        sum = sum + array [i-1];
    }
    Console.WriteLine("Сумма чисел = "+sum);
}
if (num>0)
{   
    int [] array = new int [line.Length];
    for (int i = 0; i<line.Length;i++)
    {
    array[i] = Convert.ToInt32(Convert.ToString(line[i]));
    sum = sum + array[i];
    }
Console.WriteLine("Сумма чисел = " + sum);
}


 
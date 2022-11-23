Console.WriteLine("Если вы хотите заполнить массив вручную, нажмите 1");
Console.WriteLine("Если вы хотите заполнить массив рандомно, нажмите 2");
int choice = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[] arr) 
{
    Console.Write('[' + string.Join(" ", arr) + ']');
}

switch (choice)
{
    case 1:
    Console.WriteLine("Введите восемь чисел через пробел");
    string line = Console.ReadLine();
    string []array = line.Split(' ');
    int [] array1 = Array.ConvertAll(array, int.Parse);
    PrintArray(array1);
    break;

    case 2:
    Console.WriteLine("Введите желаемую длину массива");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальный элемент массива:");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальный элемент массива:");
    int max = Convert.ToInt32(Console.ReadLine())+1;
    int [] array2 = new int[num];
    for (int i = 0; i<array2.Length;i++)
    {
        array2[i] = new Random().Next(min, max);
    }
    PrintArray(array2);
    break;
    default:
        Console.WriteLine("Других вариантов не дано)");
    break;
}
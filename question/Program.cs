// Необходимо выполнить сортировку массива от максимального значения к минимальному.
// Это задание из лекции для треннировки цикла в цикле. 
// Дело в том, что програама отрабатывает идеально для чисел от 1-10,
// когда вводишь двузначные в перемешку с однозначными, начинает сбоить
// Не могу понять причину, голову уже сломал.
// Возможно, проблема в методе Parse, но я не уверен. 
// Справа - учсток кода из лекции на сортировку по возрастанию/
// Помогите понять, в чем причина неккоректной работы программы. Спасибо!

Console.WriteLine("Введите массив через пробел");
string text = Console.ReadLine();  // Считываем введенные данные
string [] array = text.Split(" "); // Указываем пробел в качестве разделителя массива и записываем string массив
int [] array1 = Array.ConvertAll(array,int.Parse); //Создаем int-овый массив и парсим в него строковый

for (int i = 0; i<array.Length;i++)               //     for (int i = 0; i<array.Length-1;i++)
{                                                 //     {
    int MaxPosition = i;                          //         int MinPosition = i;
    for (int j = i+1; j<array.Length;j++)         //         for (int j = i+1; j<array.Length;j++)
    {                                             //         {
        if (array1[j]>array1[MaxPosition])        //             if (array[j]<array[MinPosition])
        {                                         //             {
            MaxPosition = j;                      //                 MinPosition = j;          
        }                                         //             {
    int temporary = array1[i];                    //          int temporary = array[i];      
    array1[i] = array1[MaxPosition];              //          array[i] = array[MinPosition];
    array1[MaxPosition] = temporary;              //          array1[MinPosition] = temporary; 
                                                  //         {     
    }                                             //      }
    Console.Write($"{array1[i]} ");
}  

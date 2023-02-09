class Programm
{
    static void Main()
    {
        Console.Write("Введите длину массива: ");
        int arrayAmount = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[arrayAmount];

        Console.WriteLine();
        Console.WriteLine($"Заполните массив {arrayAmount}-числами:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите число на индекс {i} в массиве:\t");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        bool flag = true;

        while (flag)
        {
            Console.WriteLine();
            Console.WriteLine("Коды операций:\nДобавить число: 1\nУдалить число: 2\nРаспечатать массив: 3\nВыйти: 4");
            Console.WriteLine();
            Console.Write("Введите код операции: ");

            string сode = Console.ReadLine();

            switch (сode)
            {
                case "1": //добавление элемента
                    Console.Write("Введите добавляемое число: ");
                    int addNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write($"Доступные индексы: {array.Length - array.Length}-{array.Length} включительно. \nВведите позицию на которую вы хотите добавить число {addNum}: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    AddElement(ref array, addNum, index);
                    Console.WriteLine($"Число {addNum} под индексом {index} добавлено в массив.");
                    break;

                case "2": //удаление элемента
                    Console.Write("Введите удаляемое число: ");
                    int deleteNum = Convert.ToInt32(Console.ReadLine());
                    DeleteElement(ref array, deleteNum);
                    Console.WriteLine($"Число {deleteNum} удалено из массива.");
                    break;

                case "3": //вывод массива
                    PrintArray(ref array);
                    break;

                case "4": //выход
                    flag = false;
                    Console.WriteLine("Программа завершена.");
                    break;

                default: //сообщение об ошибке + выход
                    Console.WriteLine("Неверный код операции.");
                    Console.WriteLine("Программа завершена.");
                    flag = false;
                    break;
            }
        }
    }
    static void AddElement(ref int[] array, int inputAddNum, int inputIndex)
    {
        int[] tempArray = new int[array.Length + 1];

        tempArray[inputIndex] = inputAddNum;

        for (int i = 0; i < inputIndex; i++)
            tempArray[i] = array[i];

        for (int i = inputIndex; i < array.Length; i++)      
            tempArray[i + 1] = array[i];    
        
        array = tempArray;
    }
    static void DeleteElement(ref int[] array, int deleteNum)
    {
        int index = 0;
        int[] tempArray = new int[array.Length - 1];       

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == deleteNum)
                index = i;
        }

        for (int i = 0; i < index; i++)       
            tempArray[i] = array[i];

        for (int i = index + 1; i < array.Length; i++)
            tempArray[i - 1] = array[i];
      
        array = tempArray;
    }
    static void PrintArray(ref int[] array)
    {
        Console.WriteLine("Распечатанный массив:");
        foreach (int e in array) 
            Console.Write(e + " ");
        Console.WriteLine();
    }
}


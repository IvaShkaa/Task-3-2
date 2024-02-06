using System;

public class Program
{
    static void Main(string[] args)
    {
        BaseArray[] Base_Array = new BaseArray[3];

        //Cоздание одномерного массива
        Console.WriteLine("Введите длинну Вашего одномерного массива: ");
        int Arr_Len = int.Parse(Console.ReadLine());

        Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
        Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
        bool _1DKeyboard_Input = bool.Parse(Console.ReadLine());

        Base_Array[0] = new OneD_Array(Arr_Len, _1DKeyboard_Input);

        //Cоздание двумерного массива
        Console.WriteLine("Введите количество строк в вашем двумерном массиве:");
        int _2D_Arr_height = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов в вашем двумерном массиве:");
        int _2D_Arr_length = int.Parse(Console.ReadLine());

        Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
        Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
        bool _2DKeyboard_Input = bool.Parse(Console.ReadLine());

        Base_Array[1] = new TwoD_Array(_2D_Arr_length, _2D_Arr_height, _2DKeyboard_Input);

        //Создание ступенчатго массива
        Console.WriteLine("Введите количество подмассивов в вашем двумерном массиве:");
        int Step_Arr_length = int.Parse(Console.ReadLine());

        Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
        Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
        bool _SDKeyboard_Input = bool.Parse(Console.ReadLine());

        Base_Array[2] = new Step_Array(Step_Arr_length, _SDKeyboard_Input);

        //Вывод всего массива и его среднего значения
        for (int i = 0; i < Base_Array.Length; i++)
        {
            Console.WriteLine("Вывод массива:");
            Base_Array[i].Print_Array();
            Console.WriteLine($"Среднее значение {Base_Array[i].Mid_Value()} ");
        }

        Console.ReadLine();
    }
}

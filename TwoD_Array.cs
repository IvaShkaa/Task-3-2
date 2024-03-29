﻿using System;

public sealed class TwoD_Array : BaseArray
{
    public int[,] _array;

    public TwoD_Array(int _Height, int _Length, bool Keyboard_Input)
    {
        _array = new int[_Height, _Length];
        if (Keyboard_Input == false)
        {
            Initialize();
        }
        else
        {
            Keyboard_Initialize();
        }
    }
    public int Height
    {
        get
        {
            return _array.GetLength(0);
        }
    }

    public int Length
    {
        get
        {
            return _array.GetLength(1);
        }
    }

    public override void Initialize()
    {
        Random rnd = new Random();
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                _array[i, j] = rnd.Next(0, 100);
            }
        }
    }

    public override void Keyboard_Initialize()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                _array[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public override double Mid_Value()
    {
        int value_sum = 0;
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                value_sum += _array[i, j];
            }
        }
        return value_sum / _array.Length;
    }

    public override void Print_Array()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                Console.Write(_array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void Print_Snake_Array()
    {
        for (int i = 0; i < Height; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = Length - 1; j >= 0; j--)
                {
                    Console.Write(_array[i, j] + " ");
                }
            }
            else
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(_array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

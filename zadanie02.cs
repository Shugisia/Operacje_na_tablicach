using System;

public class MyProgram
{
    public static void Main()
    {
        int rozmiar, i;

        rozmiar = 10;
        int[] tab = new int[rozmiar];

        for (i = 0; i <= rozmiar - 1; i++)
        {
            tab[i] = random.Next(100);
        }
        for (i = 0; i <= rozmiar - 1; i++)
        {
            Console.WriteLine(tab[i]);
        }

        int najmniejszaWartosc = ZnajdzNajmniejszy(tab);
        int najwiekszaWartosc = ZnajdzNajwiekszy(tab);

        Console.WriteLine("Najmniejszy element: " + najmniejszaWartosc);
        Console.WriteLine("Największy element: " + najwiekszaWartosc);
    }

    public static int ZnajdzNajmniejszy(int[] tab)
    {
        int najmniejszaWartosc = tab[0];

        for (int i = 1; i < tab.Length; i++)
        {
            if (tab[i] < najmniejszaWartosc)
            {
                najmniejszaWartosc = tab[i];
            }
        }

        return najmniejszaWartosc;
    }

    public static int ZnajdzNajwiekszy(int[] tab)
    {

        int najwiekszaWartosc = tab[0];

        for (int i = 1; i < tab.Length; i++)
        {
            if (tab[i] > najwiekszaWartosc)
            {
                najwiekszaWartosc = tab[i];
            }
        }

        return najwiekszaWartosc;
    }
}
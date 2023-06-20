using System;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        int rOZMIAR, i;

        rOZMIAR = 10;
        int[] tab = new int[rOZMIAR];

        for (i = 0; i <= rOZMIAR - 1; i++)
        {
            tab[i] = random.Next(100);
        }
      
        Console.WriteLine("Przed sortowaniem:");
        Wypisz(tab);

        SortowanieBabelkowe(tab);

        Console.WriteLine("Po sortowaniu:");
        Wypisz(tab);
    }

    public static void SortowanieBabelkowe(int[] tab)
    {
        int n = tab.Length;
        bool zmiana;

        for (int i = 0; i < n - 1; i++)
        {
            zmiana = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (tab[j] > tab[j + 1])
                {
                    // Zamiana miejscami
                    int temp = tab[j];
                    tab[j] = tab[j + 1];
                    tab[j + 1] = temp;

                    zmiana = true;
                }
            }

            // Jeżeli w danym przejściu nie było żadnej zamiany, to lista jest już posortowana
            if (!zmiana)
            {
                break;
            }
        }
    }

    public static void Wypisz(int[] tab)
    {
        foreach (int element in tab)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
    


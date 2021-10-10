using System;

namespace TableauNbr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tab = { 2, 2, 3, 5 };
            Console.Write("Entrer un nombre :");
            int nbr = int.Parse(Console.ReadLine());
            Array.Resize<int>(ref Tab, Tab.Length + 1);
            for (int i = 0; i < Tab.Length - 1; i++)
            {
                if (nbr > Tab[Tab.Length - 2])
                {
                    Tab[Tab.Length - 1] = nbr;
                    break;
                }
                else if (nbr < Tab[i])
                {
                    for (int j = Tab.Length - 2; j >= i; j--)
                    {
                        Tab[j + 1] = Tab[j];
                    }
                    Tab[i] = nbr;
                    break;
                }
            }
            foreach (int num in Tab)
            {
                Console.WriteLine(num); ;
            }
        }
    }
}

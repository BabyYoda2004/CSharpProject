using System;
using System.IO;
using System.Globalization;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\Fedor\\Desktop\\Project1\\SE1_1.gfc");
                line = sr.ReadLine();
                int m = 15;
                int n = 15;
                double[,] array = new double[m, n];
                double[,] arra2 = new double[m, n];
                CultureInfo culture = CultureInfo.InvariantCulture;               
                while (line != null)
                {
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
                    if (words.Length < 4 || words[0] != "gfc")
                        continue;

                    int i = int.Parse(words[1]) - 1; 
                    int j = int.Parse(words[2]) - 1;

                    string val1Str = words[3].Trim(); 
                    string val2Str = words[4].Trim(); 

                    double val1 = double.Parse(val1Str, culture);
                    double val2 = double.Parse(val2Str, culture);

                    array[i, j] = val1;
                    arra2[i, j] = val2;
                }
                
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{arra2[i, j]} ");
                    }
                    Console.WriteLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}

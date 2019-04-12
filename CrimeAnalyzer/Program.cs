using System;
using System.IO;
using System.Collections.Generic;

namespace CrimeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Loadfile1 = new Loadfile(CrimeData.csv);
            //Loadfile1.test();

            using (var reader = new StreamReader(@"CrimeData.csv"))
            {
                List<string> listYear = new List<string>();
                List<string> listPop = new List<string>();
                List<string> listVioCri = new List<string>();
                List<string> listMurder = new List<string>();
                List<string> listRape = new List<string>();
                List<string> listRobbery = new List<string>();
                List<string> listAggAssault = new List<string>();
                List<string> listPropCrime = new List<string>();
                List<string> listBurglery = new List<string>();
                List<string> listTheft = new List<string>();
                List<string> listMotoTheft = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listYear.Add(values[0]);
                    listPop.Add(values[1]);
                    listVioCri.Add(values[2]);
                    listMurder.Add(values[3]);
                    listRape.Add(values[4]);
                    listRobbery.Add(values[5]);
                    listAggAssault.Add(values[5]);
                    listPropCrime.Add(values[6]);
                    listBurglery.Add(values[7]);
                    listTheft.Add(values[8]);
                    listMotoTheft.Add(values[9]);


                }


                Console.WriteLine("Crime Analyzer Report\n");
                Console.WriteLine("Period:{0}\n", listYear[20] - listYear[1]);
                Console.WriteLine("Years murders per year< 15000:");
                Console.WriteLine("Robberies per year > 500000:");
                Console.WriteLine("Violent crime per capita rate(2010);");
                Console.WriteLine("Average murder per year(all years):");
                Console.WriteLine("Average murder per year(1994–1997):");
                Console.WriteLine("Average murder per year(2010–2014):");
                Console.WriteLine("Minimum thefts per year(1999–2004):");
                Console.WriteLine("Maximum thefts per year(1999–2004):");
                Console.WriteLine("Year of highest number of motor vehicle thefts:");
            }
        }


        private string[,] Loadfile(string Filename)
        {
            // Get the file's text.
            string whole_file = System.IO.File.ReadAllText(Filename);

            // Split into lines.
            whole_file = whole_file.Replace('\n', '\r');
            string[] lines = whole_file.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // See how many rows and columns there are.
            int num_rows = lines.Length;
            int num_cols = lines[0].Split(',').Length;

            // Allocate the data array.
            string[,] values = new string[num_rows, num_cols];

            // Load the array.
            for (int r = 0; r < 20; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < 11; c++)
                {
                    values[r, c] = line_r[c];

                    Console.Write(values[r, c]);
                    Console.Read();
                }
            }

            return values;
        }
    }
}
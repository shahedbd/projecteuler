using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problems
{
    public static class P22NamesScores
    {
        public static long Get()
        {
            long sum = 0;
            string strFilesLocsWithFilesName = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "/ProjectEuler/Problems/Resource/P2Name.txt";
            string[] fileText = File.ReadAllLines(strFilesLocsWithFilesName);

            foreach (string line in fileText)
            {
                string[] nameCollection = line.Replace("\"", string.Empty).Split(new char[] { ',' });
                Array.Sort(nameCollection, StringComparer.InvariantCulture);
                for (int i = 0; i < nameCollection.Length; i++)
                {
                    int value = 0;
                    for (int j = 0; j < nameCollection[i].Length; j++)
                        value += nameCollection[i][j] - 'A' + 1;
                    sum += value * (i + 1);
                }
            }
            return sum;
        }


    }
}


//Notes: 
// charAt C#: str[8];
// char can minus: var abc = 'D' - 'A'; Result=3
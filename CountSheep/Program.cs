using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MyProject.CountSheep
{
    class CountSheep
    {
        private static List<char> digits;
        private static int MAX = int.MaxValue;
        private static int LARGE = (int)Math.Pow(10,6);

        static void Main(string[] args)
        {
            int interval = 0;
            int start = 0;
            string str = null;
            StreamReader inFile = new StreamReader("C:\\Users\\Derek\\Downloads\\A-large-practice.in");
            StreamWriter outFile = new StreamWriter("C:\\Users\\Derek\\Downloads\\outlarge.txt");

            str = inFile.ReadLine();
            int.TryParse(str, out interval);            
            for ( int i = 0; i < interval; i++ )
            {
                str = inFile.ReadLine();
                bool isNumeric = int.TryParse(str, out start);
                if (isNumeric && start >= 0 && start <= LARGE)
                {
                    int last = countDigits(start);
                    int caseNum = i + 1;
                    if (last == -1)
                        outFile.WriteLine("Case #" + caseNum + ": INSOMNIA");
                    else
                        outFile.WriteLine("Case #" + caseNum + ": " + last);
                }
                else
                    i--;
            }
            outFile.Flush();
            outFile.Close();
        }

        public static int countDigits(int start)
        {
            int current = start;
            string str;
            int i = 0;
            digits = new List<char>();

            if (start == 0)
                return -1;
            while ( current <=  MAX )
            {
                str = current.ToString();
                var strArray = str.ToCharArray();
                foreach ( char c in strArray )
                {
                    if (!digits.Contains(c))
                        digits.Add(c);
                }
                if (digits.Count == 10)
                    return current;
                current = (i + 1) * start;
                i++;
            }
            return -1;
        }
    }
}

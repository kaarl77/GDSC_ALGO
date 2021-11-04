using System;

namespace GDSC_ALGO
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftSup = 8;
            int leftInf = 8;
            int rightSup = 8;
            int rightInf = 8;

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();

                if (line[0][0] == '+')
                    if (line[1][0] == 'b')
                        leftSup = 0;
                    else
                        leftSup--;

                if (line[0][0] == '-')
                    if (line[1][0] == 'b')
                        leftInf = 0;
                    else
                        leftInf--;

                if (line[0][1] == '+')
                    if (line[1][0] == 'b')
                        rightSup = 0;
                    else
                        rightSup--;

                if (line[0][1] == '-')
                    if (line[1][0] == 'b')
                        rightInf = 0;
                    else
                        rightInf--;

            }

            if (leftSup > 0 && leftInf > 0)
            {
                Console.WriteLine(0);
                return;
            }
            if (rightSup > 0 && rightInf > 0)
            {
                Console.WriteLine(1);
                return;
            }
            Console.WriteLine(2);
        }
    }
}

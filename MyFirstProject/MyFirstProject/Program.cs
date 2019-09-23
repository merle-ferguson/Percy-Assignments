using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main()
        {
            bool result = CheckPalindrome("12woW21");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static bool CheckPalindrome(string strXval)
        {
            int vx1 = strXval.Length;
            int vx2 = vx1 - 1;
            var vstr1 = strXval.ToUpper();
            bool vstat0 = true;

            if (vstr1.Length == 1)
            { return (vstat0); }
            else
            {
                for (int vx3 = 0; vx3 < vx1 && vx2 >= 1;)
                {
                    if (vstr1[vx3] != vstr1[vx2])

                    {
                        vstat0 = false;
                        vx3 = vx1;
                    }
                    vx3++;
                    vx2--;
                }
                return (vstat0);
            }

        }

    }
}

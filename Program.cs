using System;
using System.Collections.Generic;
using System.Linq;

namespace app110
{
    class Program
    {
        public static List<int> Check(List<int> l1)
        {
            List<int> l2 = new List<int>();

            for (int i = 0; i < l1.Count; i++)
            {
                int v1, v2, v3;

                if (i - 1 < 0)
                {
                    v1 = l1[l1.Count - 1];
                    v2 = l1[i];
                    v3 = l1[i + 1];
                }
                
                else if (i + 1 > l1.Count - 1)
                {
                    v1 = l1[i - 1];
                    v2 = l1[i];
                    v3 = l1[0];
                }
                
                else 
                {
                    v1 = l1[i - 1];
                    v2 = l1[i];
                    v3 = l1[i + 1];
                }

                if (v1 == 0 && v2 == 0 && v3 == 0)
                    l2.Add(0);
                
                if (v1 == 0 && v2 == 0 && v3 == 1)
                    l2.Add(1);

                if (v1 == 0 && v2 == 1 && v3 == 0)
                    l2.Add(1);

                if (v1 == 0 && v2 == 1 && v3 == 1)
                    l2.Add(1);

                if (v1 == 1 && v2 == 0 && v3 == 0)
                    l2.Add(0);

                if (v1 == 1 && v2 == 0 && v3 == 1)
                    l2.Add(1);

                if (v1 == 1 && v2 == 1 && v3 == 0)
                    l2.Add(1);

                if (v1 == 1 && v2 == 1 && v3 == 1)
                    l2.Add(0);
            }

            return l2;
        }
        
        static void Main()
        {
            
            List<int> auto = new List<int>(){1, 1, 1, 0, 1};
            List<int> nul = new List<int>();

            foreach (var v in auto)
            {
                Console.Write(v);
            }
            Console.WriteLine();
            
            auto = Check(auto);
            
            foreach (var v in auto)
            {
                Console.Write(v);
            }
            Console.WriteLine();
            
            for (int i = 0; i < auto.Count; i++)
            {
                nul.Add(0);
            }
            
            while (!auto.SequenceEqual(nul))
            {
                var auto2 = Check(auto);
                foreach (var v in auto2)
                {
                    Console.Write(v);
                }
                Console.WriteLine();
                auto = auto2;
            }
        }
    }
}
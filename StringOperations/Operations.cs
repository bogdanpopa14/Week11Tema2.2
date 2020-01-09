using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    public class Operations
    {
        public static bool Permutation(string a, string b)
        {
            var countA = CountChar(a);
            var countB = CountChar(b);
            bool equal = false;
            if (countA.Count == countB.Count)
            {
                equal = true;
                foreach (var item in countA)
                {
                    int value;
                    if (countB.TryGetValue(item.Key, out value))
                    {
                        if (value != item.Value)
                        {
                            equal = false;
                            break;
                        }

                    }
                    else
                    {
                        equal = false;
                        break;
                    }
                }
            }
            return equal;
        }

        public static bool OneOrZeroEDit(string a, string b)
        {
            int count = 0;
            int x = 0;
            bool result = false;
            var dic1 = CountChar(a);
            var dic2 = CountChar(b);
            for (int i = 0; i < dic1.Count; i++)
            {
                for (int j = 0; j < dic2.Count; j++)
                {
                    if (dic1.Keys.ElementAt(i) == dic2.Keys.ElementAt(j) && dic1[dic1.Keys.ElementAt(i)] == dic2[dic2.Keys.ElementAt(j)])
                    {
                        x++;
                    }

                }

            }
            if(dic1.Count>=dic2.Count)
            {
                count = dic1.Count;
            }
            else
            {
                count = dic2.Count;
            }
            if(count-1==x)
            {
                result = true;
            }
            return result;

        }


        private static Dictionary<char, int> CountChar(string a)
        {
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (dict1.ContainsKey(a[i]))
                {
                    dict1[a[i]]++;
                }
                else
                    dict1.Add(a[i], 1);
            }
            return dict1;
        }
    }
}

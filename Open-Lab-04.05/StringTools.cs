using System;
using System.Text;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            int l = 0;
            string letter = "";
            while (l <= orig.Length - 1)
            {
                for (int i = 0; i < n; i++)
                    letter += orig[l];
                l++;
            }
            return letter;
        }
    }
}

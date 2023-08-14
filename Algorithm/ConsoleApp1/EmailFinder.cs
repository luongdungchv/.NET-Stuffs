using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EmailFinder
    {
        static string FindEmail(string s)
        {
            s += " ";
            string q = "";
            foreach (char i in s)
            {
                if (i == ' ')
                {
                    bool b = CheckEmail(q);
                    if (b) return q;
                    q = "";
                    continue;
                }
                q += i.ToString();
            }
            return "Not FOund";
        }

        static bool CheckEmail(string input)
        {

            int acount = 0;
            foreach (char i in input)
            {
                if (i.ToString() == "@") acount++;

            }

            if (acount != 1) return false;
            int index = input.IndexOf("@");
            string start = input.Substring(0, index);
            if (start[0] == '.') return false;
            if (start[start.Length - 1] == '.') return false;
            string end = input.Substring(index + 1);
            //Console.Write(end);
            if (!end.Contains(".")) return false;
            foreach (char i in start)
            {
                if (!Char.IsLetterOrDigit(i))
                {
                    if (i.ToString() != ".") return false;
                }
            }
            return true;
        }
    }
}

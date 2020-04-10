using System;

namespace Kata.Spec
{
    public class Calculator
    {
        public int Add(string s ="")
        {
            string[] pieces = s.Split(',');
            if (string.IsNullOrEmpty(s))
                return 0;
            if (pieces.Length == 1)
            {
                return int.Parse(pieces[0]);
            }
            return int.Parse(pieces[0]) + int.Parse(pieces[1]);
        }
    }
}
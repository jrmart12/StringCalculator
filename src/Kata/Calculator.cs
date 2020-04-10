using System;
using System.Linq;

namespace Kata.Spec
{
    public class Calculator
    {
        public int Add(string s ="")
        {
            
            if (string.IsNullOrEmpty(s))
                return 0;
            
            var pieces = s.Split(',');
            if (pieces.Length == 1)
            {
                return int.Parse(pieces[0]);
            }
            var numbers = pieces.Select(x => int.Parse(x));
            return numbers.Sum();
        }
    }
}
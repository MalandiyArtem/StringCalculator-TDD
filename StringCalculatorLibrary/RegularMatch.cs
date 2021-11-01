using System;
using System.Text.RegularExpressions;

namespace StringCalculatorLibrary
{
    class RegularMatch
    {
        Regex regex;
        Match match;
        string searchString;

        public RegularMatch(string pattern, string searchString)
        {
            regex = new Regex(pattern);
            this.searchString = searchString;
        }

        public Match GetMatch()
        {
            match = regex.Match(searchString);
            return match;
        }

        public string Replace(string replacement)
        {
            return regex.Replace(searchString, replacement);
        }
    }
}

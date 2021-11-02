using System;
using System.Text.RegularExpressions;

namespace StringCalculatorLibrary
{
    class RegularMatch
    {
        Regex regex;
        Match match;
        MatchCollection matchCollection;
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

        public string[] GetDelimiters()
        {
            matchCollection = regex.Matches(searchString);
            return ConvertToArray(matchCollection);
        }

        private string[] ConvertToArray(MatchCollection collection)
        {
            string[] delimiters = new string[collection.Count];

            for (int i = 0; i < collection.Count; i++)
                delimiters[i] = collection[i].Value;

            return delimiters;
        }
        public string Replace(string replacement)
        {
            return regex.Replace(searchString, replacement);
        }
    }
}

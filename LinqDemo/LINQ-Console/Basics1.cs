using System.Collections.Generic;
using System.Text;

namespace LINQ_Console
{
    internal class Basics1
    {
        // the basics units of LINQ are Sequences and Elements
        private string[] _names =
        {
            "Wil",
            "Erin",
            "Shelby",
            "Hunter",
            "Spencer",
            "Jorden"
        };

        private StringBuilder _sb = new StringBuilder();

        public Basics1()
        {
            _sb = new StringBuilder();

            var lexicon = new Dictionary<string, string>
            {
                {"Sequences", "Any object that implements IEnumerable."},
                {"Elements", "Each item in the Sequence."},
                {
                    "Operator",
                    "A method that transforms a Sequence. These extensions are called 'Standard Query Operators' and are implemented as static extension methods (around 40 of them)"
                }
            };

            foreach (var dic in lexicon)
            {
                _sb.Append(dic.Key + " : ");
                _sb.Append(dic.Value);
                _sb.AppendLine("");
            }
        }

        public StringBuilder ForOutput
        {
            get { return _sb; }
            set { _sb = value; }
        }


        public string[] Names
        {
            get { return _names; }
            set { _names = value; }
        }
    }
}
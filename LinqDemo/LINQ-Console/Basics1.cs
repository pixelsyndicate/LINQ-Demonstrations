using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Console
{
    class Basics1
    {
        // the basics units of LINQ are Sequences and Elements
        StringBuilder _sb = new StringBuilder();
        public StringBuilder ForOutput
        {
            get { return _sb; }
            set { _sb = value; }
        }
        private string[] _names = new[]
        {
            "Wil",
            "Erin",
            "Shelby",
            "Hunter",
            "Spencer",
            "Jorden"
        };


        public string[] Names
        {
            get { return _names; }
            set { _names = value; }
        }

        public Basics1()
        {
            _sb = new StringBuilder();

            var lexicon = new Dictionary<string, string>
            {
                {"Sequences", "Any object that implements IEnumerable."},
                {"Elements", "Each item in the Sequence."},
                {"Operator", "A method that transforms a Sequence. These extensions are called 'Standard Query Operators' and are implemented as static extension methods (around 40 of them)"}
            };

            foreach (var dic in lexicon)
            {
                _sb.Append(dic.Key + " : ");
                _sb.Append(dic.Value);
                _sb.AppendLine("");

            }
        }


    }
}

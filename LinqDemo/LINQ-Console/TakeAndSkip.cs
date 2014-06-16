using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Console
{
    public class TakeAndSkip
    {
        private StringBuilder _sb = new StringBuilder();

        public TakeAndSkip()
        {
            // .Take(#) - Returns the first # elements
            // .Skip(#) - Returns all after the first #
            var basics = new Basics1();
            string[] names = basics.Names;
            IEnumerable<string> Names = names.Select(n => n.ToUpper());


            _sb = new StringBuilder();

            var lexicon = new Dictionary<string, string>
            {
                {
                    ".Take(2)",
                    "Returns the first # Elements within the Sequence."
                }
            };

            foreach (string name in names)
            {
                string partial = string.Empty;
                foreach (char c in name.Take(2)) partial += c;
                lexicon.Add("    " + name + ".Take(2)", partial + "... ");
            }

            lexicon.Add(".Skip(2)",
                "Returns remaining Sequence after the first # Elements.");

            foreach (string name in names)
            {
                string partial = string.Empty;
                foreach (char c in name.Skip(2)) partial += c;
                lexicon.Add("    " + name + ".Skip(2)", " ..." + partial);
            }


            foreach (var dic in lexicon)
            {
                ForOutput.Append(dic.Key + " = ");
                ForOutput.Append(dic.Value);
                ForOutput.AppendLine(" ");
            }
        }

        public StringBuilder ForOutput
        {
            get { return _sb; }
            set { _sb = value; }
        }
    }
}
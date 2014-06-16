using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Console
{
    internal class Projecting
    {
        private StringBuilder _sb = new StringBuilder();

        public Projecting()
        {
            // .Select(...)  can project each element into something else
            // .Select(n => n.ToUpper()) returns all uppercase elements
            // .Select(n => new {name=n, length=n.length}) returns a sequence of anonymous types

            var names = new Basics1();
            IEnumerable<string> capitalNames = names.Names.Select(n => n.ToUpper());
            var namesAndLength = names.Names.Select(n => new
            {
                Name = n,
                n.Length
            });

            _sb = new StringBuilder();

            var lexicon = new Dictionary<string, string>
            {
                {
                    ".Select(...)",
                    "can project each element into something else."
                },
                {
                    ".Select(n => n.ToUpper())",
                    "returns all uppercase elements."
                }
            };

            foreach (string str in names.Names)
            {
                lexicon.Add("    " + str, capitalNames.SingleOrDefault(n => n.ToLower().Contains(str.ToLower())));
            }

            lexicon.Add(".Select(n => new {name=n, length=n.length})", "returns a sequence of anonymous types.");

            foreach (var obj in namesAndLength)
            {
                lexicon.Add("    Name = " + obj.Name, "Length = " + obj.Length);
            }
            foreach (var dic in lexicon)
            {
                ForOutput.Append(dic.Key + ", ");
                ForOutput.Append(dic.Value);
                ForOutput.AppendLine(" ");
            }


            ForOutput.AppendLine(" ");
        }

        public StringBuilder ForOutput
        {
            get { return _sb; }
            set { _sb = value; }
        }
    }
}
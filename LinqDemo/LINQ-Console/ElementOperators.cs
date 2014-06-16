using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Console
{
    internal class ElementOperators
    {
        private StringBuilder _sb = new StringBuilder();

        public ElementOperators()
        {
            // .Take(#) - Returns the first # elements
            // .Skip(#) - Returns all after the first #
            var basics = new Basics1();
            string[] names = basics.Names;


            _sb = new StringBuilder();

            var lexicon = new Dictionary<string, string>
            {
                {
                    ".First(), .First(?) .Last(), Single(), ElementAt(?)",
                    "Returns the specified Element in the Sequence (throws exception if null or no return)."
                }
            };

            lexicon.Add("names.First()", names.First());
            lexicon.Add("names.First(n => n.ToLower() == \"hunter\")",
                names.First(n => n.ToLower() == "hunter") ?? "NULL");
            try
            {
                lexicon.Add("names.Single()", names.Single());
            }
            catch (InvalidOperationException ex)
            {
                lexicon.Add("names.Single()", "! ! Sequence contains more than one element");
            }
            lexicon.Add("names.Last()", names.Last());
            lexicon.Add("names.ElementAt(4)", names.ElementAt(4) ?? "NULL");

            lexicon.Add(" ", "");
            lexicon.Add(".FirstOrDefault(), .LastOrDefault(), SingleOrDefault(), ElementAtOrDefault(?)",
                "Returns null or the specified Element in the Sequence  (throws exception if more than one returned).");
            lexicon.Add("names.FirstOrDefault()", names.FirstOrDefault());
            lexicon.Add("names.FirstOrDefault(n => n.ToLower() == \"shelby\")",
                names.FirstOrDefault(n => n.ToLower() == "shelby"));
            lexicon.Add("names.FirstOrDefault(n => n.ToLower() == \"bob\")",
                names.FirstOrDefault(n => n.ToLower() == "bob") ?? "NULL");
            try
            {
                lexicon.Add("names.SingleOrDefault()", names.SingleOrDefault());
            }
            catch (InvalidOperationException ex)
            {
                lexicon.Add("names.SingleOrDefault()", "! ! Sequence contains more than one element");
            }
            lexicon.Add("names.LastOrDefault()", names.LastOrDefault());
            lexicon.Add("names.ElementAtOrDefault(4)", names.ElementAtOrDefault(4));

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
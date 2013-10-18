using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingExample
{
    public class ExampleViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> NickNames { get; set; }

        public ExampleViewModel()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public ExampleViewModel(string first, string last, List<string> nickNames)
        {
            FirstName = first;
            LastName = last;
            NickNames = nickNames;
        }
    }
}

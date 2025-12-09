using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    public abstract class Search
    {
        public abstract List<string> AlphabeticalSearch();
        public abstract List<string> DateSearch();
        public abstract List<string> ReverseAlphabeticalSearch();
    }
}

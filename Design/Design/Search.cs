using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    public abstract class Search
    {
        // 3 auto user Control
        // Try mo dito implement yugn automatic na pagggawa ng user control (public)
        public void autoUserControl()
        {
            // dit
        }

        // 2 Procceed sa logic (dito mo ipapasa yung list na nakuha mo sa Iload)
        public abstract List<string> AlphabeticalSearch(); // dito yung logic ng mga Sorting
        public abstract List<string> DateSearch(); // dito yung logic ng mga Sorting
        public abstract List<string> ReverseAlphabeticalSearch(); // dito yung logic ng mga Sorting
    }
}

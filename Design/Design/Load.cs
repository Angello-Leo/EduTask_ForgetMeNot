using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    internal abstract class Load
    {
        public void LoadPersonalTasks();
        void LoadPending();
        void LoadAccomplished();

        void LoadMissing();
    }
}

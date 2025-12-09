using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    public interface ILoadable
    {
        // 1) Dito ang suggestion ko ay return list sa mga data sa db
        public void LoadData();
    }
}

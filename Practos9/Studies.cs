using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practos9
{
    struct Studies
    {
        public string DisciplineName { get; set; }
        public string Perfomance { get; set; }

        public Studies(string disciplineName, string perfomance)
        {
            DisciplineName = disciplineName;
            Perfomance =  perfomance;
            
        }

    }
}

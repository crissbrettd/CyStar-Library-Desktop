using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_v1.Code
{
    internal interface ILibraryItem
    {
        string Name { get; set; }
        string Genre { get; set; }
        string Description { get; set; }
        bool IsStarted { get; set; }    
        bool IsCompleted { get; set; }

        void MarkStarted();
        void MarkCompleted();
    }
}

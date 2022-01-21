using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_v1.Code
{
    internal class Book : ILibraryItem
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public bool IsStarted { get; set; }
        public bool IsCompleted { get; set; }

        public void MarkStarted()
        {
            IsStarted = true;
        }

        public void MarkCompleted()
        {
            IsCompleted = true; 
        }
    }
}

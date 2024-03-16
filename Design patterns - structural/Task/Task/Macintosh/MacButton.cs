using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Macintosh
{
    public class MacButton : IButton
    {
        public void Draw() => Console.WriteLine("Macintosh button has been drawn");
    }
}

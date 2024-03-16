using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Macintosh
{
    public class MacFactory : IGuiFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckBox() => new MacCheckbox();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Windows
{
    public class WinFactory : IGuiFactory
    {
        public IButton CreateButton() => new WinButton();
        public ICheckbox CreateCheckBox() => new WinCheckbox();
    }
}

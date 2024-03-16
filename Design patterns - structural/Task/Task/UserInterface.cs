using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class UserInterface
    {
        private IGuiFactory _guiFactory;

        public UserInterface(IGuiFactory guiFactory)
        {
            _guiFactory = guiFactory;
        }

        public void DrawWindow()
        {
            var button = _guiFactory.CreateButton();
            var checkbox = _guiFactory.CreateCheckBox();

            button.Draw();
            checkbox.Draw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace BlinkByte.Graphics
{
    public interface IWindowManager
    {

        void startWindow(uint width, uint height);
        void UpdateEvents();
        void ClearWindow();
        void displayWindow();
        void onResize(object sender, SFML.Window.SizeEventArgs e); // needs to not use sfml
        void onClosed(object sender, System.EventArgs e);

   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace BlinkByte.Graphics
{
    class WindowManager
    {
        SFML.Window.Window window;
        public WindowManager()
        {
            Console.WriteLine("start window");
            try
            {
                startWindow(800, 600);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Window Failed as: " + e);
            }
        }
        private void startWindow(uint width, uint height)
        {
            window = new SFML.Window.Window(new SFML.Window.VideoMode(width, height), "window");
            window.Resized += new EventHandler<SFML.Window.SizeEventArgs>(onResize);
            window.Closed += new EventHandler(onClosed);
            window.SetActive();
        }
        public void Update()
        {
            window.DispatchEvents();
        }
        public void onResize(object sender, SFML.Window.SizeEventArgs e) {
            window.Size = new SFML.System.Vector2u(e.Width, e.Height);
        }
        public void onClosed(object sender, System.EventArgs e)
        {
            ((SFML.Window.Window)sender).Close();
        }

   }
}

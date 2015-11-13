
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;
    using BlinkByte.Utilitys;
    using BlinkByte.Graphics;
    namespace BlinkByte.SFMLGraphics
    {
        class WindowManager: BlinkByte.Graphics.IWindowManager
        {
            public SFML.Graphics.RenderWindow window;
            static WindowManager instance;
            public WindowManager()
            {
                instance = this;
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
            public void startWindow(uint width, uint height)
            {
                window = new SFML.Graphics.RenderWindow(new SFML.Window.VideoMode(width, height), "window");
                window.Resized += new EventHandler<SFML.Window.SizeEventArgs>(onResize);
                window.Closed += new EventHandler(onClosed);
                window.SetActive();

            }
            public void UpdateEvents()
            {
                window.DispatchEvents();
            }
            public void ClearWindow()
            {

            window.Clear(Colour.Blue.convert());
            }
            public void displayWindow()
            {
                window.Display();
            }
            public void onResize(object sender, SFML.Window.SizeEventArgs e)
            {
                window.Size = new SFML.System.Vector2u(e.Width, e.Height);
            }
            public void onClosed(object sender, System.EventArgs e)
            {
                ((SFML.Window.Window)sender).Close();

            }
            public static WindowManager getInstance()
            {
                return instance;
            }
        public SFML.Graphics.RenderWindow getRenderWin()
        {
            return window;
        }

        }
    }


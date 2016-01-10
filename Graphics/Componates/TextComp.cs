using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Graphics.Componates
{
    public class TextComp: Shape2DComp
    {
        public string text;
        public int size = 12;
        public string FontLocation = "Fonts/arial.ttf";
        public void SetText(string text)
        {
            this.text = text;
        }
        public string getText()
        {
            return text;
        }
        public void SetSize(int size)
        {
            this.size = size;
        }
        public int getSize()
        {
            return size;
        }
    }
}

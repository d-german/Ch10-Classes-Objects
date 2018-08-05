using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Examples
{
    public struct Box
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public static Box operator +(Box b, Box c)
        {
            return new Box
            {
                Length = b.Length + c.Length,
                Width = b.Width + c.Width,
                Height = b.Height + c.Height
            };            
        }

        public static bool operator ==(Box b, Box c) => 
            b.Length == c.Length &&
            b.Width == c.Width &&
            b.Height == c.Height;

        public static bool operator !=(Box b, Box c) => b != c;
    }
}

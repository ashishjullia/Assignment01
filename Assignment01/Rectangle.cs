using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    // Rectangle Class
    public class Rectangle
    {
        // Member variables
        private int length;
        private int width;

        // Default constructor
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        // Parameterized constructor
        public Rectangle(int len, int wid)
        {
            this.length = len;
            this.width = wid;
        }

        // Function to get the :Length of current object
        public int GetLength()
        {
            return this.length;
        }

        // Function to set the new Length of current object
        public int SetLength(int len)
        {
            this.length = len;
            return this.length;
        }

        // Function to get the Width of current object
        public int GetWidth()
        {
            return this.width;
        }

        // Function to set the Width of current object
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        // Function to Calculate and get the Perimiter of current object
        public int GetPerimeter()
        {
            return (2 * (this.length + this.width));
        }

        // Function to Calculate and get the Area of current object
        public int GetArea()
        {
            return (this.length * this.width);
        }
    }
}

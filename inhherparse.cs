using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//#nullable disable

namespace ConsoleApplication1
{
    class shape 
    {
        private int length;
        public int Length { get { return length; } set { length = value; } }
       

            public void show()
            {
            
            
            }
    
    
    }
    class rectangle:shape
    {
        private int width;
        public int Width { get { return width; } set { width = value; } }

        public void getarea() 
        {
            Console.WriteLine("Rectangle Area: " + Length * Width); 
        }
    }
    class square : shape
    {
       

        public void getarea()
        {
            Console.WriteLine("Square Area: " + Length * Length);
        }
    }
    class triangle : shape
    {
        private int height;
        public int Height { get { return height; } set { height = value; } }
       public void getarea()
        {
            Console.WriteLine("Triangle Area: "+0.5*Length * Height);
        }


    }
    class box : rectangle
    {
        private int height;
        public int Height { get { return height; } set { height = value; } }

        public void getavolume()
        {
            Console.WriteLine("Box Volume: "+Length * Width * Height);
        }
    }

    class Program
    {

        public void swapper(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;


        }
        static void Main(string[] args)
        {
            /* Program op = new Program();
             int x,y ;
             int.TryParse(Console.ReadLine(), out x);
             int.TryParse(Console.ReadLine(), out y);
             Console.WriteLine("x:" + x + " " + "y:" + y);
             op.swapper(ref x, ref y);
             Console.WriteLine("x:"+x + " " +"y:"+ y);*/

            rectangle rec = new rectangle();
            triangle tri = new triangle();
            square sq = new square();
            box bx = new box();
            bx.Length = 10;
            bx.Height = 10;
            bx.Width = 10;
            rec.Length = 20;
            rec.Width = 20;
            sq.Length = 30;
            tri.Length = 40;
            tri.Height = 40;
            rec.getarea();
            sq.getarea();
            tri.getarea();
            bx.getavolume();



        }



    }
}

using System;



namespace DrawShapes
{
    public abstract class DrawingObject
    {
        public abstract void Draw();
       
    }

    public class Line : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Line.");
        }
    }

    public class Circle : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Circle.");
        }
    }

    public class Square : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Square.");
        }
    }

    public class DrawDemo
    {
        public static int Main(string[] args)
        {
            DrawingObject[] dObj = new DrawingObject[3];

            dObj[0] = new Line();
            dObj[1] = new Circle();
            dObj[2] = new Square();

            foreach (DrawingObject drawObj in dObj)
            {
                drawObj.Draw();
            }
            Console.ReadLine();
            return 0;

        }

    }

}
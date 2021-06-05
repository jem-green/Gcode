using GcodeLibrary;
using System;
using System.Collections.Generic;
using ShapeLibrary;
using DXFLibrary;

namespace GcodeCreator
{
    class Program
    {
        static void Main(string[] args)
        {

            //GcodeDocument gc = new GcodeDocument();
            //gc.Add(new Dwell(150));
            //gc.Add(new RapidMove(new Point(0, 0, 5), new Point(10, 10, 0)));
            //gc.Add(new LinearMove(new Point(0, 0, 0), new Point(10, 10, 0)));

            //foreach(Code code in gc)
            //{
            //    Console.WriteLine(code.ToString());
            //}

            //Console.WriteLine("----");

            //Console.WriteLine(gc.ToString());

            //DXFLibrary.DXFDocument dXFDocument = new DXFDocument();
            //dXFDocument.Load("test.dwg");

            //Gcode gcode = new Gcode();
            //gc = gcode.FromDXF(dXFDocument);

        }
    }
}

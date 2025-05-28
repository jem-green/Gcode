using GcodeLibrary;
using System;
using System.Collections.Generic;
using ShapeLibrary;
using DXFLibrary;

namespace GcodeTest
{
    class Program
    {
        static void Main(string[] args)
        {

            GcodeLibrary.Document gc = new GcodeLibrary.Document();
            gc.Add(new Dwell(150));
            gc.Add(new RapidMove(new ShapeLibrary.Point(0, 0, 5), new ShapeLibrary.Point(10, 10, 0)));
            gc.Add(new LinearMove(new ShapeLibrary.Point(0, 0, 0), new ShapeLibrary.Point(10, 10, 0)));

            foreach (Code code in gc)
            {
                Console.WriteLine(code.ToString());
            }

            Console.WriteLine("----");

            Console.WriteLine(gc.ToString());

            DXFLibrary.Document dXFDocument = new DXFLibrary.Document();
            dXFDocument.Load("test.dwg"); // Adds on the extra .dxf so test.dwg.dxf
            Gcode gcode = new Gcode();
            gc = gcode.FromDXF(dXFDocument);
            

        }
    }
}

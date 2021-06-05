using DXFLibrary;
using System.Collections.Generic;
using ShapeLibrary;

namespace GcodeLibrary
{
    public class Gcode
    {
        public GcodeDocument FromDXF(DXFDocument document)
        {

            List<object> items = new List<object>();


            // Need to get to the initial start point
            // The class structure needs to store the full co-ordinates
            // but only output the gcode with the differences

            foreach (DXFEntity entity in document.Entities)
            {
                if (entity.GetType() == typeof(DXFLine))
                {
                    DXFLine dxfLine = (DXFLine)entity;
                    Point from = new Point(dxfLine.Start.X.Value, dxfLine.Start.Y.Value, dxfLine.Start.Z.Value);
                    Point to = new Point(dxfLine.End.X.Value, dxfLine.End.Y.Value, dxfLine.End.Z.Value);
                    Line line = new Line(from, to);
                    items.Add(line);
                }
            }

            GcodeDocument gcodeDocument = new GcodeDocument();

            //foreach (DXFEntity entity in document.Entities)
            //{
            //    if (entity.GetType() == typeof(DXFLine))
            //    {
            //        DXFLine dxfLine = (DXFLine)entity;
            //        GraphicPrimitives.Point from = new GraphicPrimitives.Point(dxfLine.Start.X.Value, dxfLine.Start.Y.Value, dxfLine.Start.Z.Value);
            //        GraphicPrimitives.Point to = new GraphicPrimitives.Point(dxfLine.End.X.Value, dxfLine.End.Y.Value, dxfLine.End.Z.Value);
            //        GraphicPrimitives.Line line = new GraphicPrimitives.Line(from, to);
            //        GcodeLibrary.LinearMove linearMove = new LinearMove(line);
            //        gcodeDocument.Add(linearMove);
            //    }
            //}

            return (gcodeDocument);
        }
    }
}

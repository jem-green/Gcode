using DXFLibrary;
using System.Collections.Generic;
using ShapeLibrary;

namespace GcodeLibrary
{
    public class Gcode
    {
        public Document FromDXF(DXFLibrary.Document document)
        {

            List<object> items = new List<object>();


            // Need to get to the initial start point
            // The class structure needs to store the full co-ordinates
            // but only output the gcode with the differences

            foreach (DXFLibrary.Entity entity in document.Entities)
            {
                if (entity.GetType() == typeof(DXFLibrary.Line))
                {
                    DXFLibrary.Line dxfLine = (DXFLibrary.Line)entity;
                    ShapeLibrary.Point from = new ShapeLibrary.Point(dxfLine.Start.X.Value, dxfLine.Start.Y.Value, dxfLine.Start.Z.Value);
                    ShapeLibrary.Point to = new ShapeLibrary.Point(dxfLine.End.X.Value, dxfLine.End.Y.Value, dxfLine.End.Z.Value);
                    ShapeLibrary.Line line = new ShapeLibrary.Line(from, to);
                    items.Add(line);
                }
            }

            Document gcodeDocument = new Document();

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

        public Document FromHPGL2(DXFLibrary.Document document)
        {

            List<object> items = new List<object>();


            // Need to get to the initial start point
            // The class structure needs to store the full co-ordinates
            // but only output the gcode with the differences

            foreach (DXFLibrary.Entity entity in document.Entities)
            {
                if (entity.GetType() == typeof(DXFLibrary.Line))
                {
                    DXFLibrary.Line dxfLine = (DXFLibrary.Line)entity;
                    ShapeLibrary.Point from = new ShapeLibrary.Point(dxfLine.Start.X.Value, dxfLine.Start.Y.Value, dxfLine.Start.Z.Value);
                    ShapeLibrary.Point to = new ShapeLibrary.Point(dxfLine.End.X.Value, dxfLine.End.Y.Value, dxfLine.End.Z.Value);
                    ShapeLibrary.Line line = new ShapeLibrary.Line(from, to);
                    items.Add(line);
                }
            }

            Document gcodeDocument = new Document();

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

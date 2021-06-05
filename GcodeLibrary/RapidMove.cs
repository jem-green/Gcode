using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using ShapeLibrary;

namespace GcodeLibrary
{
    public class RapidMove : Code
    {
        public RapidMove(Point from, Point to) // G0
        {
            _word = WordType.G;
            _address = 0;
            _parameters = new Dictionary<WordType, Word>();
            if (from.X != to.X)
            {
                _parameters.Add(WordType.X, new X(to.X));
            }
            if (from.Y != to.Y)
            {
                _parameters.Add(WordType.Y, new Y(to.Y));
            }
            if (from.Z != to.Z)
            {
                _parameters.Add(WordType.Z, new Z(to.Z));
            }
        }
    }
}

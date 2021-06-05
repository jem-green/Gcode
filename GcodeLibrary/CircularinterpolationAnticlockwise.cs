using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class CircularInterpolationAnticlockwise : Word
    {
        public CircularInterpolationAnticlockwise() // G2
        {
            _word = WordType.G;
            _address = 2;
            _parameters = new Dictionary<WordType, Word>();
            _parameters.Add(WordType.X, new X());
            _parameters.Add(WordType.Y, new Y());
            _parameters.Add(WordType.Z, new Z());
            _parameters.Add(WordType.R, new R());

            // could consider if any are optional or
            // there should be at leaset one.

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class RapidMove : Word
    {
        public RapidMove() // G0
        {
            _word = WordType.G;
            _address = 0;
            _parameters = new Dictionary<WordType, Word>();
            _parameters.Add(WordType.X, new X());
            _parameters.Add(WordType.Y, new Y());
            _parameters.Add(WordType.Z, new Z());
            _parameters.Add(WordType.A, new A());
            _parameters.Add(WordType.B, new B());
            _parameters.Add(WordType.C, new C());

            // could consider if any are optional or
            // there should be at leaset one.

        }
    }
}

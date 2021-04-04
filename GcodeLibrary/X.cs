using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class X : Word
    {
        public X()
        {
            _word = WordType.X;
            _address = -1;

        }
        public X(double coordinate)
        {
            _word = WordType.X;
            _address = -1;
            _value = coordinate;

        }
        public double Coordinate
        {
            get
            {
                return ((double)_value);
            }
            set
            {
                _value = value;
            }
        }
    }
}

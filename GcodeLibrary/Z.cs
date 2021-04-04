using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class Z : Word
    {
        public Z()
        {
            _word = WordType.Z;
            _address = -1;

        }
        public Z(double coordinate)
        {
            _word = WordType.Z;
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

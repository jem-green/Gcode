using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class Y : Word
    {
        public Y()
        {
            _word = WordType.Y;
            _address = -1;

        }
        public Y(double coordinate)
        {
            _word = WordType.Y;
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

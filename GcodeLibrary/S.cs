using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class S : Word
    {
        public S()  // Speed
        {
            _word = WordType.S;
            _address = -1;
        }

        public S(int speed)  // Parameter
        {
            _word = WordType.S;
            _address = -1;
            _value = speed;
        }

        public int Speed
        {
            get
            {
                return ((int)_value);
            }
            set
            {
                _value = value;
            }
        }
    }
}

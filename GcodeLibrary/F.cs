using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class F : Word
    {
        public F()
        {
            _word = WordType.F;
            _address = -1;

        }
    }
}

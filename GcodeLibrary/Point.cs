using System;
using System.Collections.Generic;
using System.Text;

namespace GcodeLibrary
{
    public class Point
    {
        #region Field
        Word _x;
        Word _y;
        Word _z;
        #endregion
        #region Constructor
        public Point(Word x, Word y, Word z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
        #endregion
        #region Properties
        public Word X
        {
            get
            {
                return (_x);
            }
        }

        #endregion

    }
}

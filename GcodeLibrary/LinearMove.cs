using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using ShapeLibrary;

namespace GcodeLibrary
{
    public class LinearMove : Code
    {
        #region Fields
        
        #endregion
        #region Constructor

        public LinearMove(Point from, Point to) // G1
        {
            _word = WordType.G;
            _address = 1;
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

        public LinearMove(Line line) // G1
        {
            _word = WordType.G;
            _address = 1;
            _parameters = new Dictionary<WordType, Word>();
            if (line.From.X != line.To.X)
            {
                _parameters.Add(WordType.X, new X(line.To.X));
            }
            if (line.From.Y != line.To.Y)
            {
                _parameters.Add(WordType.Y, new Y(line.To.Y));
            }
            if (line.From.Z != line.To.Z)
            {
                _parameters.Add(WordType.Z, new Z(line.To.Z));
            }
        }

        #endregion
        #region Properties

        public double X
        {
            get
            {
                return (_parameters[WordType.X].Value);
            }
            set
            {
                _parameters[WordType.X].Value = value;
            }
        }
        public double Y
        {
            get
            {
                return (_parameters[WordType.Y].Value);
            }
            set
            {
                _parameters[WordType.Y].Value = value;
            }
        }
        public double Z
        {
            get
            {
                return (_parameters[WordType.Z].Value);
            }
            set
            {
                _parameters[WordType.Z].Value = value;
            }
        }
        #endregion
    }
}

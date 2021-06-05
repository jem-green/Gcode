using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class Dwell : Code
    {
        #region Varaibles
        #endregion
        #region Constructors

        public Dwell()  // G4
        {
            _word = WordType.G;
            _address = 4;
            _parameters = new Dictionary<WordType, Word>();
            _parameters.Add(WordType.P, new P());  // miliseconds
            _parameters.Add(WordType.X, new S());  // seconds

            // S take presidence
        }
        public Dwell(int miliseconds)  // G4
        {
            _word = Word.WordType.G;
            _address = 4;
            _parameters = new Dictionary<WordType, Word>();
            _parameters.Add(WordType.P, new P(miliseconds));  // miliseconds

            // S take presidence
        }
        public Dwell(int miliseconds, int seconds)  // G4
        {
            _word = Word.WordType.G;
            _address = 4;
            _parameters = new Dictionary<WordType, Word>();
            _parameters.Add(WordType.P, new P(miliseconds));  // miliseconds
            _parameters.Add(WordType.X, new S(seconds));      // seconds

            // X take presidence
        }

        #endregion
        #region Properties
        public int Miliseconds
        {
            get
            {
                return ((int)_parameters[WordType.P].Value);
            }
            set
            {
                _parameters[WordType.P].Value = value;
            }
        }
        public int Seconds
        {
            get
            {
                return ((int)_parameters[WordType.X].Value);
            }
            set
            {
                _parameters[WordType.X].Value = value;
            }
        }

        #endregion
    }
}

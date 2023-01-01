using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;

namespace GcodeLibrary
{
    /// <summary>
    /// Container
    /// </summary>
    public class GcodeDocument : IEnumerable<Code>
    {
        #region Fields

        List<Code> _codes;

        #endregion
        #region Constructors

        public GcodeDocument()
        {
            _codes = new List<Code>();
        }

        #endregion
        #region Properties

        public int Count
        {
            get
            {
                return(_codes.Count);
            }
        }

        public Code this[int index]
        {
            set
            {
                _codes[index] = value;
            }
            get
            {
                return (_codes[index]);
            }
        }

        #endregion
        #region Methods

        public void Add(Code code)
        {
            _codes.Add(code);
        }

        public void Clear()
        {
            _codes.Clear();
        }

        public void Load(string filename)
        {
            Load("", filename);
        }

        public void Load(string path, string filename)
        {
            string filenamePath = Path.Combine(path, filename);
            FileStream stream = new FileStream(filenamePath + ".gcode", FileMode.Open);
            Load(stream);
            stream.Close();
        }

        public void Load(Stream file)
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            bool versionwarningsent = false;

            // Work through the file and add the object structure

            _codes = new List<Code>();

        }

        public override string ToString()
        { 
            StringBuilder gcode = new StringBuilder();
            foreach (Code code in _codes)
            {
                gcode.AppendLine(code.ToString());
            }
            return (gcode.ToString());
        }

        public IEnumerator<Code> GetEnumerator()
        {
            return (_codes.GetEnumerator());
        }

        #endregion
        #region Private

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (_codes.GetEnumerator());
        }

        #endregion
    }
}

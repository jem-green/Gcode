using System;
using System.Collections.Generic;
using System.Text;
using GcodeLibrary;
using System.IO;
using System.Xml;

namespace GcodeLibrary
{
    /// <summary>
    /// Serialise and deserialise confguration data
    /// </summary>
    public class Serialise
    {
        /*
         * 
         * <?xml version="1.0" encoding="utf-8" ?>
         * <clean>
         *   <configuration>
         *     <process>[true/false]</process>
         *     <mobipath>[full path]</mobipath>
         *     <ebubpath>[full path]</ebubpath>
         *   </configuration>
         * </clean>
         * 
         */

        #region Fields

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        string filename = "";
        string path = "";
        bool _process = false;
        string _mobiPath = "";
        string _epubPath = "";

        #endregion
        #region Constructor
        public Serialise()
        { }
        public Serialise(string filename, string path)
        {
            this.filename = filename;
            this.path = path;
        }
        #endregion
        #region Properties
        public string Filename
        {
            get
            {
                return (filename);
            }
            set
            {
                filename = value;
            }
        }

        public string Path
        {
            get
            {
                return (path);
            }
            set
            {
                path = value;
            }
        }

        #endregion
        #region Methods

        public Clean FromXML()
        {
            return(FromXML(filename, path));
        }

        public Clean FromXML(string filename, string path)
        {
            log.Debug("In FromXML()");
			Clean clean = null;
            bool process = false;
            string compiler = "";

            try
            {
                // Point to the file

                string fileLocation = System.IO.Path.Combine(path, filename);
                try
                {
                    FileStream fs = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);

                    // Pass the parameters in

                    XmlReaderSettings xmlSettings = new XmlReaderSettings
                    {

                        // Enable <!ENTITY to be expanded
                        // <!ENTITY chap1 SYSTEM "chap1.xml">
                        // &chap1;

                        DtdProcessing = DtdProcessing.Parse
                    };

                    // Open the file and pass in the settings

                    try
                    {
                        Stack<string> stack = new Stack<string>();
                        string element = "";
                        string text = "";
                        string current = "";    // Used to flag what level we are at
                        int level = 1;          // Indentation level

                        XmlReader xmlReader = XmlReader.Create(fs, xmlSettings);
                        while (xmlReader.Read())
                        {
                            switch (xmlReader.NodeType)
                            {
                                #region Element
                                case XmlNodeType.Element:
                                    {
                                        element = xmlReader.LocalName.ToLower();

                                        if (!xmlReader.IsEmptyElement)
                                        {
                                            log.Info(Level(level) + "<" + element + ">");
                                            level = level + 1;
                                        }
                                        else
                                        {
                                            log.Info(Level(level) + "<" + element + "/>");
                                        }
                                        switch (element)
                                        {
                                            #region Book
                                            case "clean":
                                                {
                                                    stack.Push(current);
                                                    current = element;
													clean = new Clean();
                                                    break;
                                                }
                                            #endregion
                                            default:
                                                {
                                                    stack.Push(current);
                                                    current = element;
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                #endregion
                                #region EndElement
                                case XmlNodeType.EndElement:
                                    {
                                        element = xmlReader.LocalName;
                                        level = level - 1;
                                        log.Info(Level(level) + "</" + element + ">");
                                        switch (element)
                                        {
                                            case "clean":
                                                {
                                                    break;
                                                }
                                        }
                                        current = stack.Pop();
                                        break;
                                    }
                                #endregion
                                #region Text

                                case XmlNodeType.Text:
                                    {
                                        text = xmlReader.Value;
                                        text = text.Replace("\t", "");
                                        text = text.Replace("\n", "");
                                        text = text.Trim();
                                        log.Info(Level(level) + text);

                                        switch (current)
                                        {
                                            case "process":
                                                {
                                                    try
                                                    {
                                                        clean.Process = Clean.BoolLookup(text);
                                                    }
                                                    catch { }
                                                    break;
                                                }

                                            case "path":
                                                {
                                                    if (stack.Peek() == "mobi")
                                                    {
                                                        clean.Compiler.Add(Writer.BookType.mobi, text);
                                                    }
                                                    else if (stack.Peek() == "epub")
                                                    {
                                                        clean.Compiler.Add(Writer.BookType.epub, text);
                                                    }
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                #endregion
                                #region Entity
                                case XmlNodeType.Entity:
                                    break;
                                #endregion
                                case XmlNodeType.EndEntity:
                                    break;
                                case XmlNodeType.Whitespace:
                                    break;
                                case XmlNodeType.Comment:
                                    break;
                                case XmlNodeType.Attribute:
                                    break;
                                default:
                                    log.Info(xmlReader.NodeType);
                                    break;

                            }
                        }

                        xmlReader.Close();  // Force the close
                        xmlReader = null;
                    }
                    catch (Exception ex)
                    {
                        log.Warn("XML Error " + ex.Message);
                    }
                    fs.Close();
                    fs.Dispose();   // Force the dispose as it was getting left open
                }
                catch (FileNotFoundException ex)
                {
                    log.Warn("File Error " + ex.Message);
                }
                catch (Exception ex)
                {
                    log.Warn("File Error " + ex.Message);
                }
            }
            catch (Exception e)
            {
                log.Error("Other Error " + e.Message);
            }

            log.Debug("Out FromXML()");
            return (clean);
        }
        #endregion
        #region Private
        private static string Level(int level)
        {
            string text = "";
            for (int i = 1; i < level; i++)
            {
                text = text + "  ";
            }
            return (text);
        }
        #endregion
    }
}

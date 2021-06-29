using System;
using System.ComponentModel;
using System.Xml.Serialization;
using ZPLForge.Contracts;
using ZPLForge.Common;
using ZPLForge.Configuration;

namespace ZPLForge.XmlSerialization
{
    [Serializable]
    [XmlType("DataMatrix")]
    public class DataMatrixXmlNode : LabelContentXmlNode, IDataMatrix
    {
        public DataMatrixXmlNode()
        {
            AspectRatio = ZPLForgeDefaults.Elements.DataMatrix.AspectRatio;
            Format = ZPLForgeDefaults.Elements.DataMatrix.Format;
            ErrorCorrection = ZPLForgeDefaults.Elements.DataMatrix.ErrorCorrection;
            EscapeCharacter = ZPLForgeDefaults.Elements.DataMatrix.EscapeCharacter;
        }

        
        [XmlElement]
        public string Content { get; set; }

        [XmlElement("DimensionalHeight")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int DimensionalHeight { get; set; }

        [XmlElement("ErrorCorrection")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DataMatrixErrorCorrection ErrorCorrection { get; set; }
        
        [XmlElement("Format")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DataMatrixFormat Format { get; set; }
        
        [XmlElement("EscapeCharacter")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public char EscapeCharacter { get; set; }
        
        [XmlElement("AspectRatio")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DataMatrixAspectRatio AspectRatio { get; set; }
        
        [XmlElement("ColumnsToEncode")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int ColumnsToEncode { get; set; }
        
        [XmlElement("RowsToEndode")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int RowsToEndode { get; set; }

    }
}

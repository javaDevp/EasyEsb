using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.repository.entity
{
    [Table(Name = "Trans_Field_Info")]
    public class TransFieldInfo
    {
        [Column(Name="Field_ID")]
        public int FieldID { get; set; }
        [Column(Name="Field_Name")]
        public string FieldName { get; set; }
        [Column(Name="Field_Type")]
        public string FieldType { get; set; }
        [Column(Name="DField_Name")]
        public string DFieldName { get; set; }
        [Column(Name="Field_Length")]
        public int FieldLength { get; set; }
        [Column(Name="Field_Desc")]
        public string FieldDesc { get; set; }
        [Column(Name="Trans_ID")]
        public int TransID { get; set; }
        [Column(Name="Field_Nullable")]
        public bool FieldNullable { get; set; }
        [Column(Name="Field_Precision")]
        public int FieldPrecision { get; set; }
        [Column(Name = "Field_Direction")]
        public bool FieldDirection { get; set; }
    }
}

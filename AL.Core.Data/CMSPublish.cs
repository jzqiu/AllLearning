//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AL.Core.Data
{
    using System;
    using System.Collections.Generic;
    using AL.Component.Tools;
    
    public partial class CMSPublish:Entity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ColumnCode { get; set; }
        public string ColumnName { get; set; }
        public string GradeCode { get; set; }
        public string GradeName { get; set; }
        public string Contents { get; set; }
        public string Author { get; set; }
        public string Source { get; set; }
        public string KeyWord { get; set; }
        public string ImgUrl { get; set; }
        public Nullable<System.DateTime> UpLineTime { get; set; }
        public Nullable<System.DateTime> DownLineTime { get; set; }
        public Nullable<int> Seq { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateUser { get; set; }
        public string CreateUserName { get; set; }
        public Nullable<int> IsChecked { get; set; }
        public string CheckUser { get; set; }
        public string CheckUserName { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
    }
}

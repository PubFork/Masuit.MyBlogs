//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelCodeGenerate
{
    using System;
    using System.Collections.Generic;
    
    public partial class Issue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public System.DateTime SubmitTime { get; set; }
        public Nullable<System.DateTime> HandleTime { get; set; }
        public string Msg { get; set; }
        public string IPAddress { get; set; }
        public int Status { get; set; }
    }
}

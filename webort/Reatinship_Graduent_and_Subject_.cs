//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webort
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reatinship_Graduent_and_Subject_
    {
        public int ID_Reationship { get; set; }
        public Nullable<int> ID_Graduent { get; set; }
        public Nullable<byte> ID_Subject { get; set; }
    
        public virtual Graduant Graduant { get; set; }
        public virtual Subject Subject { get; set; }
    }
}

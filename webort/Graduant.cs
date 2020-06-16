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
    
    public partial class Graduant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Graduant()
        {
            this.Access_ticket = new HashSet<Access_ticket>();
            this.Reatinship_Graduent_and_Subject_ = new HashSet<Reatinship_Graduent_and_Subject_>();
            this.Receipt = new HashSet<Receipt>();
        }
    
        public int ID_Graduant { get; set; }
        public string Sur_name { get; set; }
        public string First_name { get; set; }
        public string Third_name { get; set; }
        public Nullable<System.DateTime> Birth_date { get; set; }
        public string Gender { get; set; }
        public string Street { get; set; }
        public string Microdistrict { get; set; }
        public string Apartment_House { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public string Diplom_number { get; set; }
        public string Attestat_number { get; set; }
        public Nullable<System.DateTime> Date_of_registr { get; set; }
        public Nullable<byte> Category { get; set; }
        public Nullable<short> Distrit { get; set; }
        public Nullable<short> School { get; set; }
        public Nullable<byte> Language { get; set; }
        public Nullable<int> Authoriziation { get; set; }
        public string LocalityName { get; set; }
        public string LocalityAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Access_ticket> Access_ticket { get; set; }
        public virtual Authorization Authorization { get; set; }
        public virtual Category_Graduent Category_Graduent { get; set; }
        public virtual District_town_ District_town_ { get; set; }
        public virtual Language Language1 { get; set; }
        public virtual School School1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reatinship_Graduent_and_Subject_> Reatinship_Graduent_and_Subject_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipt { get; set; }
    }
}
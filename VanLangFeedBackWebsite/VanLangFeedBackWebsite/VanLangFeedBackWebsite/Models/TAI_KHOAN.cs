//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VanLangFeedBackWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAI_KHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAI_KHOAN()
        {
            this.CAU_HOI = new HashSet<CAU_HOI>();
            this.CAU_TRA_LOI = new HashSet<CAU_TRA_LOI>();
            this.DANH_MUC = new HashSet<DANH_MUC>();
            this.LICH_SU_CHINH_SUA_CAU_HOI = new HashSet<LICH_SU_CHINH_SUA_CAU_HOI>();
            this.LICH_SU_CHINH_SUA_DANH_MUC = new HashSet<LICH_SU_CHINH_SUA_DANH_MUC>();
            this.QUYEN_CUA_USER = new HashSet<QUYEN_CUA_USER>();
        }
    
        public int ID { get; set; }
        public string AVATAR { get; set; }
        public string MAT_KHAU { get; set; }
        public string EMAIL { get; set; }
        public string MA_SO_NGUOI_DUNG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAU_HOI> CAU_HOI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAU_TRA_LOI> CAU_TRA_LOI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_MUC> DANH_MUC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICH_SU_CHINH_SUA_CAU_HOI> LICH_SU_CHINH_SUA_CAU_HOI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICH_SU_CHINH_SUA_DANH_MUC> LICH_SU_CHINH_SUA_DANH_MUC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUYEN_CUA_USER> QUYEN_CUA_USER { get; set; }
    }
}

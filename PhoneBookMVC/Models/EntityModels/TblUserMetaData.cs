using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneBookMVC.Models.EntityModels
{
    public class TblUserMetaData
    {
        
        public int ID { get; set; }
        [Display(Name="نام")]
        [Required(ErrorMessage ="نام را وارد کنید")]
        
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "نام خانوادگی را وارد کنید")]
        public string Family { get; set; }
        [Display(Name = "موبایل")]
        [Required(ErrorMessage = "موبایل را وارد کنید")]
        [RegularExpression(@"^0\d{10}$", ErrorMessage = "لطفا یک شماره موبایل 11 رقمی که با صفر شروع شود وارد کنید")]
        [Range(0, 99999999999, ErrorMessage = "لطفا یک شماره موبایل 11 رقمی که با صفر شروع شود وارد کنید")]
        public string Mobile { get; set; }
        [Display(Name = "تلفن ثابت")]
        public string PhoneNumber { get; set; }
        [Display(Name = "کد ملی")]
        [Required(ErrorMessage = "کد ملی را وارد کنید")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "لطفا یک کد ملی 10 رقمی وارد کنید")]
        [StringLength(10, ErrorMessage = "کد ملی باید 10 رقم باشد")]
        public string NationalCode { get; set; }
        [Display(Name = "شغل")]
        public string OrgPos { get; set; }
    }
}

namespace PhoneBookMVC.Models.DominModels
{
    [MetadataType(typeof(EntityModels.TblUserMetaData))]
    public partial class TblUser
    {

    }
}
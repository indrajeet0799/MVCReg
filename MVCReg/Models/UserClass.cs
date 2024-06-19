using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;


namespace MVCReg.Models
{
    public class UserClass
    {
        //[Required(ErrorMessage ="Enter username")]
        [Display(Name ="Enter UserName")]
        [StringLength(maximumLength:7,MinimumLength =3,ErrorMessage ="Username lenth must be 7 & min3")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="please enter the email address")]
        [Display(Name ="Email Id:")]
        public string Uemail { get; set; }
        [Required(ErrorMessage ="Enter the pass")]
        [Display(Name ="pass")]
        [DataType(DataType.Password)]
        public string UPwd { get; set; }

        [Required(ErrorMessage = "Enter the pass")]
        [Display(Name = "re-pass")]
        [DataType(DataType.Password)]
        [Compare("UPwd")]
        public string repwd { get; set; }
        [Required(ErrorMessage ="select the gender")]
        [Display(Name ="Gender :")]
        public char Gender { get; set; }
        [Required(ErrorMessage = "Upload Profile Image")]
        [Display(Name = "Profile Image :")]
        public string Uimg { get; set; }



    }
}
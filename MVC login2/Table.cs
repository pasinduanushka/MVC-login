using System.ComponentModel.DataAnnotations;
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_login2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Please enter the username" , AllowEmptyStrings= false)]
        public string username { get; set; }
        [Required(ErrorMessage = "Please enter the password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string password { get; set; }
    }
}

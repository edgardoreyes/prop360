//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace prop360.web.Models
//{
//  public class Redirect
//  {
//  }
//}


using System.ComponentModel.DataAnnotations;

namespace prop360.web.Models
{
  public class RedirectViewModel
  {
    //Junk for testing

    [Required]
    [Display(Name = "User name")]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [Display(Name = "Remember me?")]
    public bool RememberMe { get; set; }
  }

}
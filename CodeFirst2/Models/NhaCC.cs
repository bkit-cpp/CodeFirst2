using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst2.Models
{
    public class NhaCC
    {
        [Key]
        public int IDNCC { get; set; }
        [Required(ErrorMessage = "TenNCC is required")]
        [Display(Name ="TenNCC")]
        public string TenNCC { get; set; }
        [Required(ErrorMessage = "TenGiaoDich is required")]
        [Display(Name = "TenGiaoDich")]
        public string TenGiaoDich { get; set; }
        [Required(ErrorMessage = "SDT is required")]
        [Display(Name = "SDT")]
        public int SDT { get; set; }
        [Required(ErrorMessage = "fax is required")]
        [Display(Name = "fax")]
        public int fax { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
    public class EFCodeFirst2:DbContext
    {
        public DbSet<NhaCC> nhaccs { get; set; }
    }
}
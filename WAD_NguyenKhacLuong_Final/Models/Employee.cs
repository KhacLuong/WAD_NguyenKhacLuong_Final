using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_NguyenKhacLuong_Final.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "EmployeeID")]
        [Required(ErrorMessage = "Không được bỏ qua trường này")]
        public String Id { get; set; }

        [Display(Name = "EmployeeName")]
        [Required(ErrorMessage = "Không được bỏ qua trường này")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Không được bỏ qua trường này")]
        public String Departmet { get; set; }

        [Required(ErrorMessage = "Không được bỏ qua trường này")]
        [DataType(DataType.Currency)]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Nhập với định dạng tiền tệ vd: 10000,00")]
        public Decimal Salary { get; set; }
    }
}
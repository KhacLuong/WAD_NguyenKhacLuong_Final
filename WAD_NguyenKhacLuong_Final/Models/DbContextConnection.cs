using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_NguyenKhacLuong_Final.Models
{
    public class DbContextConnection:DbContext
    {
        public DbContextConnection() : base("name=Dbconnection")
        {

        }
        public DbSet<Employee> Employees { get; set; }

        
    }
}
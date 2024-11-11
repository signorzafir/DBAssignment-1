using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAssignment_1
{
    internal class StudentDbContext:DbContext
    {
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBAssignment1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

        
        public DbSet<Student>? students {  get; set; }

        private string ConnectinString { get; set; } = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBAssignment1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectinString);
        }
    }
}

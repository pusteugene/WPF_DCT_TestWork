using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_DCT_TestWork.DB
{
    public class DBContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<DBContext>();
            options.UseSqlServer("Data Source=localhost;Initial Catalog=DCT_TestWork_base;Integrated Security=True");
            return new DBContext(options.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WPF_DCT_TestWork.Model;

namespace WPF_DCT_TestWork.DB
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\localhost;Database=DCT_TestWork_base;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

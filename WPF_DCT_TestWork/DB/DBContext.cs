using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WPF_DCT_TestWork.Models;

namespace WPF_DCT_TestWork.DB
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }
        public DBContext(DbContextOptions options) : base(options) { }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LoanManagementSystem.Models
{
    public class AccountManagementContext:DbContext
    {
        public AccountManagementContext(DbContextOptions<AccountManagementContext> options):base(options)
        {
        }

        public DbSet<UserAccount> Accounts { get; set; }

    }
}

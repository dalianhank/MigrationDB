using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Data.Entity;
using GeFeng.Domain.Entities;

namespace GeFeng.Domain.Concrete
{
    public class EFDbContext:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }              
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Client> Clients { get; set; }
     }
}

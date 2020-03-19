﻿using Microsoft.EntityFrameworkCore;
using PutAVettoWork.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PutAVettoWork.Site.Data
{
    public class GenDynContext : DbContext
    {
        public GenDynContext(DbContextOptions<GenDynContext> options)
            : base(options)
        {

        }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}

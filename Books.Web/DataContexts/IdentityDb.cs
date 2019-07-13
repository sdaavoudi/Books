﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Books.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Books.Web.DataContexts
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("Identity");
            base.OnModelCreating(modelBuilder);

        }

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }
    }
}
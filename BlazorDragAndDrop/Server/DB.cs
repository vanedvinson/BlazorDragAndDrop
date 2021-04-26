﻿using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDragAndDrop.Shared;

namespace BlazorDragAndDrop.Server
{
    public class DB : ApiAuthorizationDbContext<IdentityUser>
    {
        public DbSet<TaskModel> TaskModels { get; set; }
        public DB(DbContextOptions<DB> o , IOptions<OperationalStoreOptions> o2) :base(o, o2) {  }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskModel>().HasKey(t => t.ID);
        }
    }
}

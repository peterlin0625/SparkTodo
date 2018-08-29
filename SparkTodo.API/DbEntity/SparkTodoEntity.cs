﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SparkTodo.Models
{
    /// <summary>
    /// SparkTodoEntity
    /// </summary>
    public class SparkTodoEntity : IdentityDbContext<UserAccount, UserRole, int>
    {
        public SparkTodoEntity(DbContextOptions<SparkTodoEntity> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasKey(c => c.CategoryId);
            builder.Entity<TodoItem>().HasKey(t => t.TodoId);

            base.OnModelCreating(builder);
        }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<TodoItem> TodoItems { get; set; }
    }
}

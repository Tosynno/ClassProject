using ClassProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Payment> payments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasOne(c => c.Product)
                .WithMany(c => c.order)
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Order>()
                .HasOne(c => c.user)
                .WithMany(c => c.orders)
                .HasForeignKey(c => c.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Payment>()
               .HasOne(c => c.user)
               .WithMany(c => c.Payments)
               .HasForeignKey(c => c.CustomerId)
               .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Payment>()
              .HasOne(c => c.order)
              .WithMany(c => c.payment)
              .HasForeignKey(c => c.OrderId)
              .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<Products>()
            .HasOne(c => c.CreatedUser)
            .WithMany(c => c.createdUser)
            .HasForeignKey(c => c.CreatedBy)
            .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Products>()
           .HasOne(c => c.ApprovalUser)
           .WithMany(c => c.approvalUser)
           .HasForeignKey(c => c.ApprovalBy)
           .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

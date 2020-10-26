using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce.Models
{
	public partial class DatabaseContext : DbContext
	{
		public DatabaseContext()
		{
		}

		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{

		}

		public virtual DbSet<Account> Account { get; set; }
		public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RoleAccount> RoleAccounts { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<SlideShow> SlideShows { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Photo> Photos { get; set; }
		public virtual DbSet<Invoice> Invoices { get; set; }
		public virtual DbSet<InvoiceDetails> InvoiceDetailses { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Ecommerce;Trusted_Connection=True;MultipleActiveResultSets=true");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<RoleAccount>(entity =>
			{
				entity.HasKey(e => new { e.RoleId, e.AccountId });

				entity.HasOne(d => d.Account)
				.WithMany(p => p.RoleAccounts)
				.HasForeignKey(d => d.AccountId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Account_Roles_Account");

				entity.HasOne(D => D.Roles)
				.WithMany(P => P.RoleAccounts)
				.HasForeignKey(d => d.RoleId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Account_Roles_Roles");

			});




			modelBuilder.Entity<Product>(entity =>
			{

				entity.HasOne(d => d.Category)
				.WithMany(p => p.Products)
				.HasForeignKey(d => d.CategoryId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Category_Product");

			
			});

			modelBuilder.Entity<Photo>(entity =>
			{

				entity.HasOne(d => d.Product)
				.WithMany(p => p.Photos)
				.HasForeignKey(d => d.ProductId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Product_Photo");


			});


			modelBuilder.Entity<Invoice>(entity =>
			{

				entity.HasOne(d => d.Account)
				.WithMany(p => p.Invoices)
				.HasForeignKey(d => d.AccountId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Category_Product");


			});


			modelBuilder.Entity<InvoiceDetails>(entity =>
			{
				entity.HasKey(e => new { e.InvoiceId, e.ProductId });

				entity.HasOne(d => d.Invoices)
				.WithMany(p => p.InvoiceDetailses)
				.HasForeignKey(d => d.InvoiceId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_InvoiceDetails_Invoice");


				entity.HasOne(d => d.Product)
				.WithMany(p => p.InvoiceDetailses)
				.HasForeignKey(d => d.ProductId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_InvoiceDetails_Product");

			});

		}


	}
}

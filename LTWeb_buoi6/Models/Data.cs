using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTWeb_buoi6.Models
{
	public partial class Data : DbContext
	{
		public Data()
			: base("name=Data")
		{
		}

		public virtual DbSet<Book> Book { get; set; }
		public virtual DbSet<Category> Category { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>()
				.Property(e => e.Price)
				.HasPrecision(18, 0);
		}
	}
}

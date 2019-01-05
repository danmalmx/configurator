using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConfigThis.Models
{
    public partial class ConfigContext : DbContext
    {
        public ConfigContext()
        {
        }

        public ConfigContext(DbContextOptions<ConfigContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DisallowedParameter> DisallowedParameter { get; set; }
        public virtual DbSet<DisallowedRule> DisallowedRule { get; set; }
        public virtual DbSet<DisallowedValue> DisallowedValue { get; set; }
        public virtual DbSet<Parameter> Parameter { get; set; }
        public virtual DbSet<ParameterValue> ParameterValue { get; set; }
        public virtual DbSet<Product> Product { get; set; }
                

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<DisallowedParameter>(entity =>
            {
                entity.HasKey(e => e.ObjectId);

                entity.ToTable("DISALLOWED_PARAMETER");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisallowedRuleId).HasColumnName("DISALLOWED_RULE_ID");

                entity.Property(e => e.ParameterId).HasColumnName("PARAMETER_ID");
            });

            modelBuilder.Entity<DisallowedRule>(entity =>
            {
                entity.HasKey(e => e.ObjectId);

                entity.ToTable("DISALLOWED_RULE");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DisallowedValue>(entity =>
            {
                entity.HasKey(e => e.ObjectId);

                entity.ToTable("DISALLOWED_VALUE");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisallowedParameterId).HasColumnName("DISALLOWED_PARAMETER_ID");

                entity.Property(e => e.ParameterValueId).HasColumnName("PARAMETER_VALUE_ID");
            });

            modelBuilder.Entity<Parameter>(entity =>
            {
                entity.HasKey(e => e.ObjectId);

                entity.ToTable("PARAMETER");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            });

            modelBuilder.Entity<ParameterValue>(entity =>
            {
                entity.HasKey(e => e.ObjectId);

                entity.ToTable("PARAMETER_VALUE");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterId).HasColumnName("PARAMETER_ID");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ObjectId);

                entity.ToTable("PRODUCT");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50);
            });
        }
    }
}

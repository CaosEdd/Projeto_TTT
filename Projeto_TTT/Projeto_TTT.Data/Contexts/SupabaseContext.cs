using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projeto_TTT.Domain.Entities.AggregateRoots;
using Projeto_TTT.Domain.Entities.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TTT.Data.Contexts
{
    public class SupabaseContext : IdentityDbContext<Usuario>
    {
        public SupabaseContext(DbContextOptions<SupabaseContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Usuario

            var usuario = builder.Entity<Usuario>();
            usuario.HasKey(u => u.UsuarioId);
            usuario.Property(u => u.NomeCompleto).IsRequired().HasMaxLength(50);
            usuario.Property(u => u.Telefone).IsRequired().HasMaxLength(15);
            usuario.Property(u => u.Genero).IsRequired().HasConversion<string>();
            usuario.Property(u => u.Cpf.CpfValor).HasColumnName("Cpf").IsRequired().HasMaxLength(11);
            usuario.Property(u => u.OrixaPrincipal).IsRequired().HasConversion<string>();
            usuario.Property(u => u.OrixaSecundario).IsRequired().HasConversion<string>();
            usuario.Property(u => u.Preferencia).IsRequired().HasConversion<string>();
            usuario.Property(u => u.DataEntrada).HasColumnType("timestamp with time zone").IsRequired();
            usuario.Property(u => u.CriadoEm).HasColumnType("timestamp with time zone")
                                             .HasDefaultValue(DateTime.Now)
                                             .ValueGeneratedOnAdd();
            usuario.Property(u => u.AtualizadoEm).HasColumnType("timestamp with time zone")
                                                 .HasDefaultValue(DateTime.Now)
                                                 .ValueGeneratedOnAddOrUpdate();

            usuario.HasIndex(u => u.Email).IsUnique();
            usuario.HasIndex(u => u.Cpf.CpfValor).IsUnique();


            usuario.Ignore(u => u.Id);
            usuario.Ignore(u => u.LockoutEnabled);
            usuario.Ignore(u => u.TwoFactorEnabled);
            usuario.Ignore(u => u.AccessFailedCount);
            usuario.Ignore(u => u.UserName);
            usuario.Ignore(u => u.SecurityStamp);
            usuario.Ignore(u => u.PhoneNumber);
            usuario.Ignore(u => u.PhoneNumberConfirmed);
            usuario.Ignore(u => u.ConcurrencyStamp);
            usuario.Ignore(u => u.LockoutEnd);
            usuario.Ignore(u => u.NormalizedUserName);
            usuario.Ignore(u => u.NormalizedEmail);

            builder.Ignore<IdentityUserLogin<int>>();
            builder.Ignore<IdentityUserClaim<int>>();

            #endregion

            #region Endereco

            var endereco = builder.Entity<Endereco>();


            #endregion



        }
    }
}

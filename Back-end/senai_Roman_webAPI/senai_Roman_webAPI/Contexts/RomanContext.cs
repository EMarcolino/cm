using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai_Roman_webAPI.Domains;

#nullable disable

namespace senai_Roman_webAPI.Contexts
{
    public partial class RomanContext : DbContext
    {
        public RomanContext()
        {
        }

        public RomanContext(DbContextOptions<RomanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Projeto> Projetos { get; set; }
        public virtual DbSet<Situacao> Situacaos { get; set; }
        public virtual DbSet<Tema> Temas { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MARC-NOTE; initial catalog=Roman; user Id=sa; pwd=marcsql;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Projeto>(entity =>
            {
                entity.HasKey(e => e.IdProjeto)
                    .HasName("PK__Projeto__8FCCED760577C0ED");

                entity.ToTable("Projeto");

                entity.Property(e => e.IdProjeto).HasColumnName("idProjeto");

                entity.Property(e => e.DescricaoProjeto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descricaoProjeto");

                entity.Property(e => e.IdSituacao).HasColumnName("idSituacao");

                entity.Property(e => e.IdTema).HasColumnName("idTema");

                entity.Property(e => e.NomeProjeto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeProjeto");

                entity.HasOne(d => d.IdSituacaoNavigation)
                    .WithMany(p => p.Projetos)
                    .HasForeignKey(d => d.IdSituacao)
                    .HasConstraintName("FK__Projeto__idSitua__412EB0B6");

                entity.HasOne(d => d.IdTemaNavigation)
                    .WithMany(p => p.Projetos)
                    .HasForeignKey(d => d.IdTema)
                    .HasConstraintName("FK__Projeto__idTema__403A8C7D");
            });

            modelBuilder.Entity<Situacao>(entity =>
            {
                entity.HasKey(e => e.IdSituacao)
                    .HasName("PK__Situacao__12AFD1972A565098");

                entity.ToTable("Situacao");

                entity.Property(e => e.IdSituacao).HasColumnName("idSituacao");

                entity.Property(e => e.NomeSituacao)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nomeSituacao");
            });

            modelBuilder.Entity<Tema>(entity =>
            {
                entity.HasKey(e => e.IdTema)
                    .HasName("PK__Tema__BCD9EB48CEF923BE");

                entity.ToTable("Tema");

                entity.Property(e => e.IdTema).HasColumnName("idTema");

                entity.Property(e => e.NomeTema)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeTema");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TipoUsua__03006BFFA7AA46DD");

                entity.ToTable("TipoUsuario");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.NomeTipoUsuario)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeTipoUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A65A6BC371");

                entity.ToTable("Usuario");

                entity.HasIndex(e => e.Email, "UQ__Usuario__AB6E61641B41126D")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeUsuario");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuario__idTipoU__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

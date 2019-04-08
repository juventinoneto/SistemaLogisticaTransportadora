﻿// <auto-generated />
using System;
using Cargo.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cargo.Infrastructure.Migrations
{
    [DbContext(typeof(CargoContexto))]
    partial class CargoContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cargo.DomainModel.Models.Commons.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Complemento")
                        .HasMaxLength(30);

                    b.Property<int>("Numero");

                    b.Property<string>("RuaAvenida")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("IdEndereco");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleColetaDefinicaoCarga.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int>("IdEndereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("IdCliente");

                    b.HasIndex("IdEndereco");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleColetaDefinicaoCarga.Coleta", b =>
                {
                    b.Property<int>("IdColeta")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<int>("IdCliente");

                    b.Property<int>("IdEndereco");

                    b.Property<int>("IdParceiro");

                    b.HasKey("IdColeta");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEndereco");

                    b.HasIndex("IdParceiro");

                    b.ToTable("Coleta");
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleColetaDefinicaoCarga.Parceiro", b =>
                {
                    b.Property<int>("IdParceiro")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int>("IdEndereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("IdParceiro");

                    b.HasIndex("IdEndereco");

                    b.ToTable("Parceiro");
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleColetaDefinicaoCarga.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleExpedicao.Expedicao", b =>
                {
                    b.Property<int>("IdExpedicao")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("IdExpedicao");

                    b.ToTable("Expedicao");
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleExpedicao.ExpedicaoColeta", b =>
                {
                    b.Property<int>("IdExpedicaoColeta")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdColeta");

                    b.Property<int>("IdExpedicao");

                    b.HasKey("IdExpedicaoColeta");

                    b.HasIndex("IdColeta");

                    b.HasIndex("IdExpedicao");

                    b.ToTable("ExpedicaoColeta");
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleTabelaFrete.SimulacaoTarifa", b =>
                {
                    b.Property<int>("IdSimulacaoTarifa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<int>("IdSimulacao");

                    b.Property<string>("StatusSimulacaoTarifa")
                        .IsRequired();

                    b.Property<decimal>("Valor");

                    b.HasKey("IdSimulacaoTarifa");

                    b.HasIndex("IdSimulacao");

                    b.ToTable("SimulacaoTarifa");
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleTabelaFrete.Tarifa", b =>
                {
                    b.Property<int>("IdTarifa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdColeta");

                    b.HasKey("IdTarifa");

                    b.HasIndex("IdColeta");

                    b.ToTable("Tarifa");
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleColetaDefinicaoCarga.Cliente", b =>
                {
                    b.HasOne("Cargo.DomainModel.Models.Commons.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleColetaDefinicaoCarga.Coleta", b =>
                {
                    b.HasOne("Cargo.DomainModel.Models.ControleColetaDefinicaoCarga.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cargo.DomainModel.Models.Commons.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cargo.DomainModel.Models.ControleColetaDefinicaoCarga.Parceiro", "Parceiro")
                        .WithMany()
                        .HasForeignKey("IdParceiro")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleColetaDefinicaoCarga.Parceiro", b =>
                {
                    b.HasOne("Cargo.DomainModel.Models.Commons.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleExpedicao.ExpedicaoColeta", b =>
                {
                    b.HasOne("Cargo.DomainModel.Models.ControleColetaDefinicaoCarga.Coleta", "Coleta")
                        .WithMany()
                        .HasForeignKey("IdColeta")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cargo.DomainModel.Models.ControleExpedicao.Expedicao", "Expedicao")
                        .WithMany("ExpedicoesColetas")
                        .HasForeignKey("IdExpedicao")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleTabelaFrete.SimulacaoTarifa", b =>
                {
                    b.HasOne("Cargo.DomainModel.Models.ControleTabelaFrete.Tarifa", "Tarifa")
                        .WithMany("Simulacoes")
                        .HasForeignKey("IdSimulacao")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cargo.DomainModel.Models.ControleTabelaFrete.Tarifa", b =>
                {
                    b.HasOne("Cargo.DomainModel.Models.ControleColetaDefinicaoCarga.Coleta", "Coleta")
                        .WithMany()
                        .HasForeignKey("IdColeta")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

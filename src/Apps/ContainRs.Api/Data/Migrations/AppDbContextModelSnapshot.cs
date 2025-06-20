﻿// <auto-generated />
using System;
using ContainRs.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContainRs.Api.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContainRs.Api.Domain.Conteiner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocacaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Conteineres");
                });

            modelBuilder.Entity("ContainRs.Api.Events.OutboxMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("InfoEvento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoEvento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Outbox");
                });

            modelBuilder.Entity("ContainRs.Api.InboxMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataProcessamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Erro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OutboxMessageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TipoLeitor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OutboxMessageId");

                    b.ToTable("Inbox");
                });

            modelBuilder.Entity("ContainRs.Clientes.Cadastro.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ContainRs.Clientes.Cadastro.EnderecoCli", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("EnderecoCli");
                });

            modelBuilder.Entity("ContainRs.Vendas.Locacoes.Locacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPrevistaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataTermino")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PropostaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PropostaId")
                        .IsUnique();

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.Comentario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PropostaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropostaId");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Referencias")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.PedidoLocacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataInicioOperacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisponibilidadePrevia")
                        .HasColumnType("int");

                    b.Property<int>("DuracaoPrevistaLocacao")
                        .HasColumnType("int");

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Finalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocalizacaoId")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeEstimada")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocalizacaoId");

                    b.ToTable("Solicitacoes");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.Proposta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataExpiracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeArquivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SolicitacaoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SolicitacaoId");

                    b.ToTable("Propostas");
                });

            modelBuilder.Entity("ContainRs.Api.InboxMessage", b =>
                {
                    b.HasOne("ContainRs.Api.Events.OutboxMessage", "Evento")
                        .WithMany()
                        .HasForeignKey("OutboxMessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("ContainRs.Clientes.Cadastro.Cliente", b =>
                {
                    b.OwnsOne("ContainRs.Clientes.Cadastro.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Email");

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.Navigation("Email")
                        .IsRequired();
                });

            modelBuilder.Entity("ContainRs.Clientes.Cadastro.EnderecoCli", b =>
                {
                    b.HasOne("ContainRs.Clientes.Cadastro.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ContainRs.Vendas.Locacoes.Locacao", b =>
                {
                    b.HasOne("ContainRs.Vendas.Propostas.Proposta", "Proposta")
                        .WithOne()
                        .HasForeignKey("ContainRs.Vendas.Locacoes.Locacao", "PropostaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("ContainRs.Vendas.Locacoes.StatusLocacao", "Status", b1 =>
                        {
                            b1.Property<Guid>("LocacaoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Situacao");

                            b1.HasKey("LocacaoId");

                            b1.ToTable("Locacoes");

                            b1.WithOwner()
                                .HasForeignKey("LocacaoId");
                        });

                    b.Navigation("Proposta");

                    b.Navigation("Status")
                        .IsRequired();
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.Comentario", b =>
                {
                    b.HasOne("ContainRs.Vendas.Propostas.Proposta", "Proposta")
                        .WithMany("Comentarios")
                        .HasForeignKey("PropostaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proposta");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.PedidoLocacao", b =>
                {
                    b.HasOne("ContainRs.Vendas.Propostas.Endereco", "Localizacao")
                        .WithMany()
                        .HasForeignKey("LocalizacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("ContainRs.Vendas.Propostas.StatusPedido", "Status", b1 =>
                        {
                            b1.Property<Guid>("PedidoLocacaoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Situacao");

                            b1.HasKey("PedidoLocacaoId");

                            b1.ToTable("Solicitacoes");

                            b1.WithOwner()
                                .HasForeignKey("PedidoLocacaoId");
                        });

                    b.Navigation("Localizacao");

                    b.Navigation("Status")
                        .IsRequired();
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.Proposta", b =>
                {
                    b.HasOne("ContainRs.Vendas.Propostas.PedidoLocacao", "Solicitacao")
                        .WithMany("Propostas")
                        .HasForeignKey("SolicitacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("ContainRs.Vendas.Propostas.SituacaoProposta", "Situacao", b1 =>
                        {
                            b1.Property<Guid>("PropostaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Situacao");

                            b1.HasKey("PropostaId");

                            b1.ToTable("Propostas");

                            b1.WithOwner()
                                .HasForeignKey("PropostaId");
                        });

                    b.OwnsOne("ContainRs.Vendas.Propostas.ValorMonetario", "ValorTotal", b1 =>
                        {
                            b1.Property<Guid>("PropostaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Valor")
                                .HasColumnType("decimal(18,2)");

                            b1.HasKey("PropostaId");

                            b1.ToTable("Propostas");

                            b1.WithOwner()
                                .HasForeignKey("PropostaId");
                        });

                    b.Navigation("Situacao")
                        .IsRequired();

                    b.Navigation("Solicitacao");

                    b.Navigation("ValorTotal")
                        .IsRequired();
                });

            modelBuilder.Entity("ContainRs.Clientes.Cadastro.Cliente", b =>
                {
                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.PedidoLocacao", b =>
                {
                    b.Navigation("Propostas");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.Proposta", b =>
                {
                    b.Navigation("Comentarios");
                });
#pragma warning restore 612, 618
        }
    }
}

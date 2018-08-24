﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApp;

namespace MyWebApp.Migrations
{
    [DbContext(typeof(MyWebAppContext))]
    [Migration("20180718232357_MyWebAppMigration")]
    partial class MyWebAppMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyWebApp.Entidades.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("MyWebApp.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataPedido");

                    b.Property<int?>("PedidoId");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("MyWebApp.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("MyWebApp.Entidades.ItemPedido", b =>
                {
                    b.HasOne("MyWebApp.Entidades.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("MyWebApp.Entidades.Pedido", b =>
                {
                    b.HasOne("MyWebApp.Entidades.Pedido")
                        .WithMany("Pedidos")
                        .HasForeignKey("PedidoId");
                });
#pragma warning restore 612, 618
        }
    }
}
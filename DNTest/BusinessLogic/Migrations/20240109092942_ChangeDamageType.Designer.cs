﻿// <auto-generated />
using System;
using BusinessLogic.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BusinessLogic.Migrations
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20240109092942_ChangeDamageType")]
    partial class ChangeDamageType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Monster", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AC")
                        .HasColumnType("integer");

                    b.Property<int>("AttackModifier")
                        .HasColumnType("integer");

                    b.Property<int>("AttackPerRound")
                        .HasColumnType("integer");

                    b.Property<string>("Damage")
                        .HasColumnType("text");

                    b.Property<int>("DamageModifier")
                        .HasColumnType("integer");

                    b.Property<int>("HitPoints")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Monsters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c031b307-6e59-4377-907d-86adc1ec324e"),
                            AC = 9,
                            AttackModifier = 7,
                            AttackPerRound = 5,
                            Damage = "1d20",
                            DamageModifier = 3,
                            HitPoints = 8,
                            Name = "Monster1"
                        },
                        new
                        {
                            Id = new Guid("587596d8-a08c-4029-b0a7-ba801364a61f"),
                            AC = 5,
                            AttackModifier = 4,
                            AttackPerRound = 1,
                            Damage = "1d8",
                            DamageModifier = 3,
                            HitPoints = 26,
                            Name = "Monster2"
                        },
                        new
                        {
                            Id = new Guid("b391e892-99bf-4e48-965a-d19700fadd82"),
                            AC = 19,
                            AttackModifier = 8,
                            AttackPerRound = 2,
                            Damage = "2d4",
                            DamageModifier = 1,
                            HitPoints = 1,
                            Name = "Monster3"
                        },
                        new
                        {
                            Id = new Guid("666e3a10-7f73-492e-998d-8629922b7873"),
                            AC = 15,
                            AttackModifier = 5,
                            AttackPerRound = 2,
                            Damage = "1d10",
                            DamageModifier = 2,
                            HitPoints = 27,
                            Name = "Monster4"
                        },
                        new
                        {
                            Id = new Guid("49b62e77-ddfb-430c-8996-b85806be91ff"),
                            AC = 3,
                            AttackModifier = 9,
                            AttackPerRound = 5,
                            Damage = "1d12",
                            DamageModifier = 5,
                            HitPoints = 13,
                            Name = "Monster5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

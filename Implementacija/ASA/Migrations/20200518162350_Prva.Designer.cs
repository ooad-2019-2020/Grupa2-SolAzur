﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using authTest.Models;

namespace ASA.Migrations
{
    [DbContext(typeof(ASAContext))]
    [Migration("20200518162350_Prva")]
    partial class Prva
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("authTest.Models.Agencija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RacunId")
                        .HasColumnType("int");

                    b.Property<string>("UsloviPutovanja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RacunId");

                    b.ToTable("Agencija");
                });

            modelBuilder.Entity("authTest.Models.Cijena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Akontacija")
                        .HasColumnType("float");

                    b.Property<double>("PunaCijena")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Cijena");
                });

            modelBuilder.Entity("authTest.Models.Kod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgencijaId")
                        .HasColumnType("int");

                    b.Property<int>("Popust")
                        .HasColumnType("int");

                    b.Property<string>("Sifra")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AgencijaId");

                    b.ToTable("Kod");
                });

            modelBuilder.Entity("authTest.Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgencijaId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PutovanjeId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AgencijaId");

                    b.HasIndex("PutovanjeId");

                    b.ToTable("Korisnik");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Korisnik");
                });

            modelBuilder.Entity("authTest.Models.Ocjena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojOcjena")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<double>("Prosjek")
                        .HasColumnType("float");

                    b.Property<int>("PutovanjeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("PutovanjeId");

                    b.ToTable("Ocjena");
                });

            modelBuilder.Entity("authTest.Models.Putovanje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgencijaId")
                        .HasColumnType("int");

                    b.Property<bool>("Aktuelno")
                        .HasColumnType("bit");

                    b.Property<int>("CijenaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumPolaska")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPovratka")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destinacija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KlijentId")
                        .HasColumnType("int");

                    b.Property<int>("MaxBrojLjudi")
                        .HasColumnType("int");

                    b.Property<int>("MinBrojLjudi")
                        .HasColumnType("int");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AgencijaId");

                    b.HasIndex("CijenaId");

                    b.HasIndex("KlijentId");

                    b.ToTable("Putovanje");
                });

            modelBuilder.Entity("authTest.Models.Racun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojRacuna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("IznosNovca")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Racun");
                });

            modelBuilder.Entity("authTest.Models.Rezervacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgencijaId")
                        .HasColumnType("int");

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<int>("KlijentId")
                        .HasColumnType("int");

                    b.Property<int?>("KodId")
                        .HasColumnType("int");

                    b.Property<int>("PutovanjeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgencijaId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("KodId");

                    b.HasIndex("PutovanjeId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("authTest.Models.Klijent", b =>
                {
                    b.HasBaseType("authTest.Models.Korisnik");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MjestoStanovanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RacunId")
                        .HasColumnType("int");

                    b.HasIndex("RacunId");

                    b.HasDiscriminator().HasValue("Klijent");
                });

            modelBuilder.Entity("authTest.Models.Agencija", b =>
                {
                    b.HasOne("authTest.Models.Racun", "Racun")
                        .WithMany()
                        .HasForeignKey("RacunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("authTest.Models.Kod", b =>
                {
                    b.HasOne("authTest.Models.Agencija", "Agencija")
                        .WithMany()
                        .HasForeignKey("AgencijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("authTest.Models.Korisnik", b =>
                {
                    b.HasOne("authTest.Models.Agencija", "Agencija")
                        .WithMany("Korisnici")
                        .HasForeignKey("AgencijaId");

                    b.HasOne("authTest.Models.Putovanje", null)
                        .WithMany("Putnici")
                        .HasForeignKey("PutovanjeId");
                });

            modelBuilder.Entity("authTest.Models.Ocjena", b =>
                {
                    b.HasOne("authTest.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("authTest.Models.Putovanje", "Putovanje")
                        .WithMany()
                        .HasForeignKey("PutovanjeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("authTest.Models.Putovanje", b =>
                {
                    b.HasOne("authTest.Models.Agencija", null)
                        .WithMany("Kodovi")
                        .HasForeignKey("AgencijaId");

                    b.HasOne("authTest.Models.Cijena", "Cijena")
                        .WithMany()
                        .HasForeignKey("CijenaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("authTest.Models.Klijent", null)
                        .WithMany("Putovanja")
                        .HasForeignKey("KlijentId");
                });

            modelBuilder.Entity("authTest.Models.Rezervacija", b =>
                {
                    b.HasOne("authTest.Models.Agencija", null)
                        .WithMany("Ponude")
                        .HasForeignKey("AgencijaId");

                    b.HasOne("authTest.Models.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("authTest.Models.Kod", "Kod")
                        .WithMany()
                        .HasForeignKey("KodId");

                    b.HasOne("authTest.Models.Putovanje", "Putovanje")
                        .WithMany()
                        .HasForeignKey("PutovanjeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("authTest.Models.Klijent", b =>
                {
                    b.HasOne("authTest.Models.Racun", "Racun")
                        .WithMany()
                        .HasForeignKey("RacunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RS1_2019_12_16.EF;
using System;

namespace RS1_2019_12_16.Migrations
{
    [DbContext(typeof(MojContext))]
    partial class MojContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.DodjeljenPredmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OdjeljenjeStavkaId");

                    b.Property<int>("PredmetId");

                    b.Property<int>("ZakljucnoKrajGodine");

                    b.HasKey("Id");

                    b.HasIndex("OdjeljenjeStavkaId");

                    b.HasIndex("PredmetId");

                    b.ToTable("DodjeljenPredmet");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.Komisija", b =>
                {
                    b.Property<int>("PopravniIspitID");

                    b.Property<int>("NastavnikID");

                    b.HasKey("PopravniIspitID", "NastavnikID");

                    b.HasIndex("NastavnikID");

                    b.ToTable("Komisija");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.Nastavnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<int>("SkolaID");

                    b.HasKey("Id");

                    b.HasIndex("SkolaID");

                    b.ToTable("Nastavnik");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.Odjeljenje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsPrebacenuViseOdjeljenje");

                    b.Property<string>("Oznaka");

                    b.Property<int>("Razred");

                    b.Property<int>("RazrednikID");

                    b.Property<int>("SkolaID");

                    b.Property<int>("SkolskaGodinaID");

                    b.HasKey("Id");

                    b.HasIndex("RazrednikID");

                    b.HasIndex("SkolaID");

                    b.HasIndex("SkolskaGodinaID");

                    b.ToTable("Odjeljenje");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.OdjeljenjeStavka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojUDnevniku");

                    b.Property<int>("OdjeljenjeId");

                    b.Property<int>("UcenikId");

                    b.HasKey("Id");

                    b.HasIndex("OdjeljenjeId");

                    b.HasIndex("UcenikId");

                    b.ToTable("OdjeljenjeStavka");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.PopravniIspit", b =>
                {
                    b.Property<int>("PopravniIspitID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum");

                    b.Property<int>("PredmetID");

                    b.Property<int>("SkolaID");

                    b.Property<int?>("SkolskaGodinaId");

                    b.Property<int>("SkoslkaGodinaID");

                    b.HasKey("PopravniIspitID");

                    b.HasIndex("PredmetID");

                    b.HasIndex("SkolaID");

                    b.HasIndex("SkolskaGodinaId");

                    b.ToTable("PopravniIspit");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.PopravniIspitOdljenjeStavka", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OdjeljenjeStavkaID");

                    b.Property<int>("PopravniIspitID");

                    b.Property<int>("bodovi");

                    b.Property<bool?>("isPristupio");

                    b.HasKey("id");

                    b.HasIndex("OdjeljenjeStavkaID");

                    b.HasIndex("PopravniIspitID");

                    b.ToTable("PopravniIspitOdljenjeStavka");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.PredajePredmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NastavnikID");

                    b.Property<int>("OdjeljenjeID");

                    b.Property<int>("PredmetID");

                    b.HasKey("Id");

                    b.HasIndex("NastavnikID");

                    b.HasIndex("OdjeljenjeID");

                    b.HasIndex("PredmetID");

                    b.ToTable("PredajePredmet");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.Predmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.Property<int>("Razred");

                    b.HasKey("Id");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.Skola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Skola");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.SkolskaGodina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Aktuelna");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("SkolskaGodina");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.Ucenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImePrezime");

                    b.HasKey("Id");

                    b.ToTable("Ucenik");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.DodjeljenPredmet", b =>
                {
                    b.HasOne("RS1_2019_12_16.EntityModels.OdjeljenjeStavka", "OdjeljenjeStavka")
                        .WithMany()
                        .HasForeignKey("OdjeljenjeStavkaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RS1_2019_12_16.EntityModels.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.Komisija", b =>
                {
                    b.HasOne("RS1_2019_12_16.EntityModels.Nastavnik", "Nastavnik")
                        .WithMany("Komisija")
                        .HasForeignKey("NastavnikID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RS1_2019_12_16.EntityModels.PopravniIspit", "PopravniIspit")
                        .WithMany("Komisija")
                        .HasForeignKey("PopravniIspitID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.Nastavnik", b =>
                {
                    b.HasOne("RS1_2019_12_16.EntityModels.Skola", "Skola")
                        .WithMany()
                        .HasForeignKey("SkolaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.Odjeljenje", b =>
                {
                    b.HasOne("RS1_2019_12_16.EntityModels.Nastavnik", "Razrednik")
                        .WithMany()
                        .HasForeignKey("RazrednikID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RS1_2019_12_16.EntityModels.Skola", "Skola")
                        .WithMany()
                        .HasForeignKey("SkolaID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RS1_2019_12_16.EntityModels.SkolskaGodina", "SkolskaGodina")
                        .WithMany()
                        .HasForeignKey("SkolskaGodinaID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.OdjeljenjeStavka", b =>
                {
                    b.HasOne("RS1_2019_12_16.EntityModels.Odjeljenje", "Odjeljenje")
                        .WithMany()
                        .HasForeignKey("OdjeljenjeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RS1_2019_12_16.EntityModels.Ucenik", "Ucenik")
                        .WithMany()
                        .HasForeignKey("UcenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.PopravniIspit", b =>
                {
                    b.HasOne("RS1_2019_12_16.EntityModels.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RS1_2019_12_16.EntityModels.Skola", "Skola")
                        .WithMany()
                        .HasForeignKey("SkolaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RS1_2019_12_16.EntityModels.SkolskaGodina", "SkolskaGodina")
                        .WithMany()
                        .HasForeignKey("SkolskaGodinaId");
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.PopravniIspitOdljenjeStavka", b =>
                {
                    b.HasOne("RS1_2019_12_16.EntityModels.OdjeljenjeStavka", "OdjeljenjeStavka")
                        .WithMany()
                        .HasForeignKey("OdjeljenjeStavkaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RS1_2019_12_16.EntityModels.PopravniIspit", "PopravniIspit")
                        .WithMany()
                        .HasForeignKey("PopravniIspitID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RS1_2019_12_16.EntityModels.PredajePredmet", b =>
                {
                    b.HasOne("RS1_2019_12_16.EntityModels.Nastavnik", "Nastavnik")
                        .WithMany()
                        .HasForeignKey("NastavnikID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RS1_2019_12_16.EntityModels.Odjeljenje", "Odjeljenje")
                        .WithMany()
                        .HasForeignKey("OdjeljenjeID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RS1_2019_12_16.EntityModels.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

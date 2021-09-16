﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ekitap.data.Concrete.EfCore;

namespace ekitap.data.Migrations
{
    [DbContext(typeof(ekitapContext))]
    partial class ekitapContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("ekitap.entity.kategori", b =>
                {
                    b.Property<int>("kategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("ka_adi")
                        .HasColumnType("TEXT");

                    b.HasKey("kategoriId");

                    b.ToTable("kategoriler");
                });

            modelBuilder.Entity("ekitap.entity.kitap", b =>
                {
                    b.Property<int>("kitapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("k_aciklama")
                        .HasColumnType("TEXT");

                    b.Property<string>("k_adi")
                        .HasColumnType("TEXT");

                    b.Property<bool>("k_anasayfa")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("k_fiyat")
                        .HasColumnType("REAL");

                    b.Property<bool>("k_onay")
                        .HasColumnType("INTEGER");

                    b.Property<string>("k_resim")
                        .HasColumnType("TEXT");

                    b.Property<int>("k_sayfa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("kategoriId")
                        .HasColumnType("INTEGER");

                    b.HasKey("kitapId");

                    b.HasIndex("kategoriId");

                    b.ToTable("kitaplar");
                });

            modelBuilder.Entity("ekitap.entity.kitapyazar", b =>
                {
                    b.Property<int>("yazarId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("kitapId")
                        .HasColumnType("INTEGER");

                    b.HasKey("yazarId", "kitapId");

                    b.HasIndex("kitapId");

                    b.ToTable("kitapyazar");
                });

            modelBuilder.Entity("ekitap.entity.yazar", b =>
                {
                    b.Property<int>("yazarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("yazarad")
                        .HasColumnType("TEXT");

                    b.Property<string>("yazarsoyad")
                        .HasColumnType("TEXT");

                    b.HasKey("yazarId");

                    b.ToTable("yazarlar");
                });

            modelBuilder.Entity("ekitap.entity.kitap", b =>
                {
                    b.HasOne("ekitap.entity.kategori", "kategori")
                        .WithMany("kitaplar")
                        .HasForeignKey("kategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ekitap.entity.kitapyazar", b =>
                {
                    b.HasOne("ekitap.entity.kitap", "kitap")
                        .WithMany("kitapyazarlar")
                        .HasForeignKey("kitapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ekitap.entity.yazar", "yazar")
                        .WithMany("kitapyazarlar")
                        .HasForeignKey("yazarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

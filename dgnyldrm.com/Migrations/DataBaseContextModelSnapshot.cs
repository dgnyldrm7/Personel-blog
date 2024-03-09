﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dgnyldrm.com.Data.Concrete.EfCore;

#nullable disable

namespace dgnyldrm.com.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("CategoriesNews", b =>
                {
                    b.Property<int>("CategoriesCategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NewsID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriesCategoryID", "NewsID");

                    b.HasIndex("NewsID");

                    b.ToTable("CategoriesNews");
                });

            modelBuilder.Entity("dgnyldrm.com.Entity.Authors", b =>
                {
                    b.Property<int?>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthorEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorName")
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorID");

                    b.ToTable("Yazarlar");

                    b.HasData(
                        new
                        {
                            AuthorID = 1,
                            AuthorEmail = "dgnyldrm7@icloud.com",
                            AuthorName = "Doğan"
                        },
                        new
                        {
                            AuthorID = 2,
                            AuthorEmail = "merve7@icloud.com",
                            AuthorName = "Merve"
                        });
                });

            modelBuilder.Entity("dgnyldrm.com.Entity.Categories", b =>
                {
                    b.Property<int?>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Javascript",
                            Slug = "Javascript"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "AspCore",
                            Slug = "AspCore"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Python",
                            Slug = "Python"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "C#",
                            Slug = "C#"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Php",
                            Slug = "Php"
                        });
                });

            modelBuilder.Entity("dgnyldrm.com.Entity.Comments", b =>
                {
                    b.Property<int>("CommentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("NewsID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YorumcuId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentsId");

                    b.HasIndex("NewsID");

                    b.HasIndex("YorumcuId");

                    b.ToTable("Yorumlar");

                    b.HasData(
                        new
                        {
                            CommentsId = 1,
                            CommentContent = "Gerçekten Çok Beğendim.Sağ olun!",
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NewsID = 1,
                            YorumcuId = 1
                        },
                        new
                        {
                            CommentsId = 2,
                            CommentContent = "Çok yardımcı oldunuz.Sağ olun !",
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NewsID = 1,
                            YorumcuId = 2
                        },
                        new
                        {
                            CommentsId = 3,
                            CommentContent = "Başka örnekler var mı ?",
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NewsID = 2,
                            YorumcuId = 3
                        },
                        new
                        {
                            CommentsId = 4,
                            CommentContent = "Çok iyisiniz.Allah yardımcımız olsun bu alanda uzmanlaşmak gerçekten çok zor. HAHAHAHHAHA bu bir test verisi ama ben daha çok şey yazarak aslında bazı şeylere çözüm üretmeye çalışıyorum!!!!!",
                            CreatedTime = new DateTime(2024, 2, 28, 0, 36, 31, 632, DateTimeKind.Local).AddTicks(198),
                            NewsID = 3,
                            YorumcuId = 4
                        });
                });

            modelBuilder.Entity("dgnyldrm.com.Entity.News", b =>
                {
                    b.Property<int>("NewsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("NewsID");

                    b.HasIndex("AuthorID");

                    b.ToTable("Yazilarim");

                    b.HasData(
                        new
                        {
                            NewsID = 1,
                            AuthorID = 1,
                            Content = "Yazının içeriği 1",
                            CreatedTime = new DateTime(2024, 2, 28, 0, 36, 31, 631, DateTimeKind.Local).AddTicks(9913),
                            IsActive = true,
                            Slug = "php-ile-kodlama",
                            Title = "Php ile kodlama"
                        },
                        new
                        {
                            NewsID = 2,
                            AuthorID = 1,
                            Content = "Yazının içeriği 2",
                            CreatedTime = new DateTime(2024, 2, 28, 0, 36, 31, 631, DateTimeKind.Local).AddTicks(9925),
                            IsActive = true,
                            Slug = "js-ile-kodlama",
                            Title = "JavaScript ile kodlama"
                        },
                        new
                        {
                            NewsID = 3,
                            AuthorID = 2,
                            Content = "Yazının içeriği 3",
                            CreatedTime = new DateTime(2024, 2, 28, 0, 36, 31, 631, DateTimeKind.Local).AddTicks(9927),
                            IsActive = true,
                            Slug = "python-ile-kodlama",
                            Title = "Python ile kodlama"
                        },
                        new
                        {
                            NewsID = 4,
                            AuthorID = 2,
                            Content = "Yazının içeriği 4",
                            CreatedTime = new DateTime(2024, 2, 28, 0, 36, 31, 631, DateTimeKind.Local).AddTicks(9971),
                            IsActive = true,
                            Slug = "csharp-ile-kodlama",
                            Title = "C# ile kodlama"
                        });
                });

            modelBuilder.Entity("dgnyldrm.com.Entity.YorumcuKisi", b =>
                {
                    b.Property<int>("YorumcuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("YorumcuEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("YorumcuLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("YorumcuName")
                        .HasColumnType("TEXT");

                    b.HasKey("YorumcuId");

                    b.ToTable("Yorumcular");

                    b.HasData(
                        new
                        {
                            YorumcuId = 1,
                            YorumcuEmail = "dgn@mail.com",
                            YorumcuLastName = "Yıldırım",
                            YorumcuName = "Doğan"
                        },
                        new
                        {
                            YorumcuId = 2,
                            YorumcuEmail = "diyar@mail.com",
                            YorumcuLastName = "Ahmet",
                            YorumcuName = "Diyar"
                        },
                        new
                        {
                            YorumcuId = 3,
                            YorumcuEmail = "kemal@mail.com",
                            YorumcuLastName = "Tanca",
                            YorumcuName = "Kemal"
                        },
                        new
                        {
                            YorumcuId = 4,
                            YorumcuEmail = "abc@mail.com",
                            YorumcuLastName = "Harfes",
                            YorumcuName = "Abece"
                        });
                });

            modelBuilder.Entity("CategoriesNews", b =>
                {
                    b.HasOne("dgnyldrm.com.Entity.Categories", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dgnyldrm.com.Entity.News", null)
                        .WithMany()
                        .HasForeignKey("NewsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dgnyldrm.com.Entity.Comments", b =>
                {
                    b.HasOne("dgnyldrm.com.Entity.News", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dgnyldrm.com.Entity.YorumcuKisi", "YorumcuKisi")
                        .WithMany()
                        .HasForeignKey("YorumcuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");

                    b.Navigation("YorumcuKisi");
                });

            modelBuilder.Entity("dgnyldrm.com.Entity.News", b =>
                {
                    b.HasOne("dgnyldrm.com.Entity.Authors", "Authors")
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Authors");
                });

            modelBuilder.Entity("dgnyldrm.com.Entity.News", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}

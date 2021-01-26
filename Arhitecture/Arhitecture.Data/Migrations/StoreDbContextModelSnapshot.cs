﻿// <auto-generated />
using System;
using Arhitecture.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Arhitecture.Data.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateAndTimeOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Bills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAndTimeOfIssue = new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            DateAndTimeOfIssue = new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            DateAndTimeOfIssue = new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            DateAndTimeOfIssue = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            DateAndTimeOfIssue = new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            DateAndTimeOfIssue = new DateTime(2020, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Category A"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Category B"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Category C"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Category D"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Category E"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Category F"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Category G"
                        });
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BeginingOfShift")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndingOfShift")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BeginingOfShift = new DateTime(1, 1, 1, 8, 0, 1, 0, DateTimeKind.Unspecified),
                            EndingOfShift = new DateTime(1, 1, 1, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mate",
                            LastName = "Matić"
                        },
                        new
                        {
                            Id = 2,
                            BeginingOfShift = new DateTime(1, 1, 1, 16, 0, 1, 0, DateTimeKind.Unspecified),
                            EndingOfShift = new DateTime(1, 1, 1, 23, 59, 59, 0, DateTimeKind.Unspecified),
                            FirstName = "Ante",
                            LastName = "Antić"
                        },
                        new
                        {
                            Id = 3,
                            BeginingOfShift = new DateTime(1, 1, 1, 23, 59, 59, 0, DateTimeKind.Unspecified),
                            EndingOfShift = new DateTime(1, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ana",
                            LastName = "Anić"
                        });
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Offers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Artikal A",
                            Price = 10m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Artikal B",
                            Price = 15m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Artikal C",
                            Price = 13m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Artikal D",
                            Price = 12.79m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Artikal E",
                            Price = 17.99m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Artikal F",
                            Price = 18m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Artikal G",
                            Price = 7.8m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Service A",
                            Price = 50m
                        },
                        new
                        {
                            Id = 9,
                            Name = "Service B",
                            Price = 30m
                        },
                        new
                        {
                            Id = 10,
                            Name = "Service C",
                            Price = 60m
                        },
                        new
                        {
                            Id = 11,
                            Name = "Service D",
                            Price = 39m
                        },
                        new
                        {
                            Id = 12,
                            Name = "Service E",
                            Price = 20m
                        },
                        new
                        {
                            Id = 13,
                            Name = "Service F",
                            Price = 59m
                        },
                        new
                        {
                            Id = 14,
                            Name = "Service G",
                            Price = 40m
                        },
                        new
                        {
                            Id = 15,
                            Name = "Rent A",
                            Price = 35m
                        },
                        new
                        {
                            Id = 16,
                            Name = "Rent B",
                            Price = 37.5m
                        },
                        new
                        {
                            Id = 17,
                            Name = "Rent C",
                            Price = 19.5m
                        },
                        new
                        {
                            Id = 18,
                            Name = "Rent D",
                            Price = 50m
                        },
                        new
                        {
                            Id = 19,
                            Name = "Rent E",
                            Price = 25.5m
                        },
                        new
                        {
                            Id = 20,
                            Name = "Rent F",
                            Price = 12m
                        },
                        new
                        {
                            Id = 21,
                            Name = "Rent G",
                            Price = 80m
                        });
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.OfferPerCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("OfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OfferId");

                    b.ToTable("OfferPerCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            OfferId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            OfferId = 8
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            OfferId = 15
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            OfferId = 2
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            OfferId = 9
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            OfferId = 16
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            OfferId = 3
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            OfferId = 10
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            OfferId = 17
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 4,
                            OfferId = 4
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 4,
                            OfferId = 11
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            OfferId = 18
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 5,
                            OfferId = 5
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 5,
                            OfferId = 12
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 5,
                            OfferId = 19
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 6,
                            OfferId = 6
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 6,
                            OfferId = 13
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 6,
                            OfferId = 20
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 7,
                            OfferId = 7
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 7,
                            OfferId = 14
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 7,
                            OfferId = 21
                        });
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.OneOffBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("ProductId");

                    b.ToTable("OneOffBills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 4,
                            BillId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 6,
                            BillId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            Amount = 1,
                            BillId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            Amount = 7,
                            BillId = 1,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            Amount = 12,
                            BillId = 1,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 6,
                            Amount = 3,
                            BillId = 2,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 7,
                            Amount = 16,
                            BillId = 2,
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("OfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Count = 2,
                            OfferId = 1
                        },
                        new
                        {
                            Id = 2,
                            Count = 9,
                            OfferId = 2
                        },
                        new
                        {
                            Id = 3,
                            Count = 59,
                            OfferId = 3
                        },
                        new
                        {
                            Id = 4,
                            Count = 90,
                            OfferId = 4
                        },
                        new
                        {
                            Id = 5,
                            Count = 14,
                            OfferId = 5
                        },
                        new
                        {
                            Id = 6,
                            Count = 60,
                            OfferId = 6
                        },
                        new
                        {
                            Id = 7,
                            Count = 9,
                            OfferId = 7
                        });
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("OfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.ToTable("Rents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OfferId = 15
                        },
                        new
                        {
                            Id = 2,
                            OfferId = 16
                        },
                        new
                        {
                            Id = 3,
                            OfferId = 17
                        },
                        new
                        {
                            Id = 4,
                            OfferId = 18
                        },
                        new
                        {
                            Id = 5,
                            OfferId = 19
                        },
                        new
                        {
                            Id = 6,
                            OfferId = 20
                        },
                        new
                        {
                            Id = 7,
                            OfferId = 21
                        });
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.RentBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<string>("CreditCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("RentId");

                    b.ToTable("RentBills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreditCardNumber = "1234123412341234",
                            EndingDate = new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Michelle",
                            LastName = "Šarić",
                            RentId = 1,
                            StartingDate = new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreditCardNumber = "1234123412345678",
                            EndingDate = new DateTime(2020, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bože",
                            LastName = "Topić",
                            RentId = 2,
                            StartingDate = new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreditCardNumber = "1234123412341235",
                            EndingDate = new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lucia",
                            LastName = "Vukorepa",
                            RentId = 3,
                            StartingDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreditCardNumber = "1234123412341235",
                            EndingDate = new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lucia",
                            LastName = "Vukorepa",
                            RentId = 4,
                            StartingDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("OfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OfferId = 8
                        },
                        new
                        {
                            Id = 2,
                            OfferId = 9
                        },
                        new
                        {
                            Id = 3,
                            OfferId = 10
                        },
                        new
                        {
                            Id = 4,
                            OfferId = 11
                        },
                        new
                        {
                            Id = 5,
                            OfferId = 12
                        },
                        new
                        {
                            Id = 6,
                            OfferId = 13
                        },
                        new
                        {
                            Id = 7,
                            OfferId = 14
                        });
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.ServiceBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndingTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartingTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceBills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BillId = 3,
                            EmployeeId = 1,
                            EndingTime = new DateTime(1, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceId = 1,
                            StartingTime = new DateTime(1, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            BillId = 4,
                            EmployeeId = 2,
                            EndingTime = new DateTime(1, 1, 1, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceId = 1,
                            StartingTime = new DateTime(1, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            BillId = 5,
                            EmployeeId = 2,
                            EndingTime = new DateTime(1, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceId = 2,
                            StartingTime = new DateTime(1, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            BillId = 6,
                            EmployeeId = 2,
                            EndingTime = new DateTime(1, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceId = 4,
                            StartingTime = new DateTime(1, 1, 1, 1, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Bill", b =>
                {
                    b.HasOne("Arhitecture.Data.Entities.Models.Employee", null)
                        .WithMany("Bills")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.OfferPerCategory", b =>
                {
                    b.HasOne("Arhitecture.Data.Entities.Models.Category", "Category")
                        .WithMany("OfferPerCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Arhitecture.Data.Entities.Models.Offer", "Offer")
                        .WithMany("OfferPerCategories")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.OneOffBill", b =>
                {
                    b.HasOne("Arhitecture.Data.Entities.Models.Bill", "Bill")
                        .WithMany("OneOffBills")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Arhitecture.Data.Entities.Models.Product", "Product")
                        .WithMany("OneOfBills")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Product", b =>
                {
                    b.HasOne("Arhitecture.Data.Entities.Models.Offer", "Offer")
                        .WithMany("Products")
                        .HasForeignKey("OfferId");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Rent", b =>
                {
                    b.HasOne("Arhitecture.Data.Entities.Models.Offer", "Offer")
                        .WithMany("Rents")
                        .HasForeignKey("OfferId");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.RentBill", b =>
                {
                    b.HasOne("Arhitecture.Data.Entities.Models.Bill", "Bill")
                        .WithMany("RentBills")
                        .HasForeignKey("BillId");

                    b.HasOne("Arhitecture.Data.Entities.Models.Rent", "Rent")
                        .WithMany("RentBills")
                        .HasForeignKey("RentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Rent");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Service", b =>
                {
                    b.HasOne("Arhitecture.Data.Entities.Models.Offer", "Offer")
                        .WithMany("Services")
                        .HasForeignKey("OfferId");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.ServiceBill", b =>
                {
                    b.HasOne("Arhitecture.Data.Entities.Models.Bill", "Bill")
                        .WithMany("ServiceBills")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Arhitecture.Data.Entities.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Arhitecture.Data.Entities.Models.Service", "Service")
                        .WithMany("ServiceBills")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Employee");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Bill", b =>
                {
                    b.Navigation("OneOffBills");

                    b.Navigation("RentBills");

                    b.Navigation("ServiceBills");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Category", b =>
                {
                    b.Navigation("OfferPerCategories");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Employee", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Offer", b =>
                {
                    b.Navigation("OfferPerCategories");

                    b.Navigation("Products");

                    b.Navigation("Rents");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Product", b =>
                {
                    b.Navigation("OneOfBills");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Rent", b =>
                {
                    b.Navigation("RentBills");
                });

            modelBuilder.Entity("Arhitecture.Data.Entities.Models.Service", b =>
                {
                    b.Navigation("ServiceBills");
                });
#pragma warning restore 612, 618
        }
    }
}

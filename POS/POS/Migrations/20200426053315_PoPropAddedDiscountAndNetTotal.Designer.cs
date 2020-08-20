﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POS.Data;

namespace POS.Migrations
{
    [DbContext(typeof(POSDbContext))]
    [Migration("20200426053315_PoPropAddedDiscountAndNetTotal")]
    partial class PoPropAddedDiscountAndNetTotal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("POS.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandCode")
                        .IsRequired();

                    b.Property<string>("BrandName")
                        .IsRequired();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<int?>("CreateId");

                    b.Property<string>("Remarks");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("POS.Models.BrandModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Remarks");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("BrandModels");
                });

            modelBuilder.Entity("POS.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("POS.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Company_Name");

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("POS.Models.ContactPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("Designation");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<int?>("SupplierAId");

                    b.HasKey("Id");

                    b.HasIndex("SupplierAId");

                    b.ToTable("ContactPerson");
                });

            modelBuilder.Entity("POS.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Code");

                    b.Property<string>("Contact")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<int>("LoyalityPoint");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("POS.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("POS.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("DiscountPer");

                    b.Property<int>("ProductId");

                    b.Property<int>("PurchaseOrderId");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("Rate");

                    b.Property<int>("SubCategoryId");

                    b.Property<decimal>("TotalAmount");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("POS.Models.Pack", b =>
                {
                    b.Property<int>("PackId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PackQty");

                    b.Property<string>("PackSizeName")
                        .IsRequired();

                    b.Property<string>("Remarks");

                    b.HasKey("PackId");

                    b.ToTable("Pack");
                });

            modelBuilder.Entity("POS.Models.PO", b =>
                {
                    b.Property<int>("PurchaseOrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeliveryDate");

                    b.Property<string>("Description");

                    b.Property<decimal>("NetDiscount");

                    b.Property<decimal>("NetTotal");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("PurchaseOrderNo")
                        .IsRequired();

                    b.Property<int>("SupplierId");

                    b.HasKey("PurchaseOrderId");

                    b.ToTable("PO");
                });

            modelBuilder.Entity("POS.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandModelId");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Description");

                    b.Property<string>("ProductImage");

                    b.Property<string>("ProductName");

                    b.Property<int>("SubCategoryId");

                    b.Property<int>("UnitId");

                    b.HasKey("Id");

                    b.HasIndex("BrandModelId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("UnitId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("POS.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Discount");

                    b.Property<int>("ProductId");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<int>("Quantity");

                    b.Property<int>("SupplierId");

                    b.Property<decimal>("TotalPrice");

                    b.Property<double>("UnitPrice");

                    b.HasKey("PurchaseId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("POS.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Discount");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("Sales_Date");

                    b.Property<decimal>("Sales_price");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("POS.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("POS.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Address2");

                    b.Property<string>("CAddress");

                    b.Property<string>("CEmail");

                    b.Property<string>("Code");

                    b.Property<string>("Contact");

                    b.Property<string>("ContactPerson");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("POS.Models.SupplierA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Code");

                    b.Property<string>("Contact");

                    b.Property<string>("ContactPerson");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SupplierA");
                });

            modelBuilder.Entity("POS.Models.TestChild", b =>
                {
                    b.Property<int>("TestChildId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.Property<int>("TestParentId");

                    b.HasKey("TestChildId");

                    b.HasIndex("TestParentId");

                    b.ToTable("TestChilds");
                });

            modelBuilder.Entity("POS.Models.TestParent", b =>
                {
                    b.Property<int>("TestParentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("TestParentId");

                    b.ToTable("TestParent");
                });

            modelBuilder.Entity("POS.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("POS.Models.BrandModel", b =>
                {
                    b.HasOne("POS.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("POS.Models.ContactPerson", b =>
                {
                    b.HasOne("POS.Models.SupplierA", "SupplierA")
                        .WithMany()
                        .HasForeignKey("SupplierAId");
                });

            modelBuilder.Entity("POS.Models.OrderDetail", b =>
                {
                    b.HasOne("POS.Models.PO", "PO")
                        .WithMany()
                        .HasForeignKey("PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("POS.Models.Product", b =>
                {
                    b.HasOne("POS.Models.BrandModel", "BrandModel")
                        .WithMany()
                        .HasForeignKey("BrandModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("POS.Models.Company", "Company")
                        .WithMany("Products")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("POS.Models.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("POS.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("POS.Models.Purchase", b =>
                {
                    b.HasOne("POS.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("POS.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("POS.Models.Sale", b =>
                {
                    b.HasOne("POS.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("POS.Models.SubCategory", b =>
                {
                    b.HasOne("POS.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("POS.Models.TestChild", b =>
                {
                    b.HasOne("POS.Models.TestParent", "TestParent")
                        .WithMany("TestChilds")
                        .HasForeignKey("TestParentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

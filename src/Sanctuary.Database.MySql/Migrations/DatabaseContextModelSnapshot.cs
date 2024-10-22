﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sanctuary.Database;

#nullable disable

namespace Sanctuary.Database.MySql.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("DbItemDbProfile", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<ulong>("ItemsCharacterGuid")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("ProfilesId")
                        .HasColumnType("int");

                    b.Property<ulong>("ProfilesCharacterGuid")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("ItemsId", "ItemsCharacterGuid", "ProfilesId", "ProfilesCharacterGuid");

                    b.HasIndex("ProfilesId", "ProfilesCharacterGuid");

                    b.ToTable("ProfileItems", (string)null);
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbCharacter", b =>
                {
                    b.Property<ulong>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<ulong>("Guid"));

                    b.Property<int>("ActiveProfileId")
                        .HasColumnType("int");

                    b.Property<int?>("ActiveTitleId")
                        .HasColumnType("int");

                    b.Property<int>("ChatBubbleBackgroundColor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(13951728);

                    b.Property<int>("ChatBubbleForegroundColor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(408679);

                    b.Property<int>("ChatBubbleSize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("EyeColor")
                        .HasColumnType("int");

                    b.Property<string>("FacePaint")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Hair")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("HairColor")
                        .HasColumnType("int");

                    b.Property<string>("Head")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("LastLogin")
                        .HasColumnType("timestamp");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<int>("MembershipStatus")
                        .HasColumnType("int");

                    b.Property<int>("Model")
                        .HasColumnType("int");

                    b.Property<string>("ModelCustomization")
                        .HasColumnType("longtext");

                    b.Property<string>("SkinTone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("Ticket")
                        .HasColumnType("char(36)");

                    b.Property<ulong>("UserGuid")
                        .HasColumnType("bigint unsigned");

                    b.Property<float>("VipRank")
                        .HasColumnType("float");

                    b.ComplexProperty<Dictionary<string, object>>("Position", "Sanctuary.Database.Entities.DbCharacter.Position#Vector4", b1 =>
                        {
                            b1.Property<float>("W")
                                .HasColumnType("float");

                            b1.Property<float>("X")
                                .HasColumnType("float");

                            b1.Property<float>("Y")
                                .HasColumnType("float");

                            b1.Property<float>("Z")
                                .HasColumnType("float");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("Rotation", "Sanctuary.Database.Entities.DbCharacter.Rotation#Quaternion", b1 =>
                        {
                            b1.Property<float>("W")
                                .HasColumnType("float");

                            b1.Property<float>("X")
                                .HasColumnType("float");

                            b1.Property<float>("Y")
                                .HasColumnType("float");

                            b1.Property<float>("Z")
                                .HasColumnType("float");
                        });

                    b.HasKey("Guid");

                    b.HasIndex("UserGuid");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbItem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<ulong>("CharacterGuid")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("Definition")
                        .HasColumnType("int");

                    b.Property<int>("Tint")
                        .HasColumnType("int");

                    b.HasKey("Id", "CharacterGuid");

                    b.HasIndex("CharacterGuid");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbMount", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<ulong>("CharacterGuid")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsUpgraded")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id", "CharacterGuid");

                    b.HasIndex("CharacterGuid");

                    b.ToTable("Mounts");
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbProfile", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<ulong>("CharacterGuid")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("LevelXP")
                        .HasColumnType("int");

                    b.HasKey("Id", "CharacterGuid");

                    b.HasIndex("CharacterGuid");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbTitle", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<ulong>("CharacterGuid")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id", "CharacterGuid");

                    b.HasIndex("CharacterGuid");

                    b.ToTable("Titles", (string)null);
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbUser", b =>
                {
                    b.Property<ulong>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<ulong>("Guid"));

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsMember")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LastLogin")
                        .HasColumnType("timestamp");

                    b.Property<int>("MaxCharacters")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(10);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Session")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Guid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DbItemDbProfile", b =>
                {
                    b.HasOne("Sanctuary.Database.Entities.DbItem", null)
                        .WithMany()
                        .HasForeignKey("ItemsId", "ItemsCharacterGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sanctuary.Database.Entities.DbProfile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesId", "ProfilesCharacterGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbCharacter", b =>
                {
                    b.HasOne("Sanctuary.Database.Entities.DbUser", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbItem", b =>
                {
                    b.HasOne("Sanctuary.Database.Entities.DbCharacter", "Character")
                        .WithMany("Items")
                        .HasForeignKey("CharacterGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbMount", b =>
                {
                    b.HasOne("Sanctuary.Database.Entities.DbCharacter", "Character")
                        .WithMany("Mounts")
                        .HasForeignKey("CharacterGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbProfile", b =>
                {
                    b.HasOne("Sanctuary.Database.Entities.DbCharacter", "Character")
                        .WithMany("Profiles")
                        .HasForeignKey("CharacterGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbTitle", b =>
                {
                    b.HasOne("Sanctuary.Database.Entities.DbCharacter", "Character")
                        .WithMany("Titles")
                        .HasForeignKey("CharacterGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbCharacter", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Mounts");

                    b.Navigation("Profiles");

                    b.Navigation("Titles");
                });

            modelBuilder.Entity("Sanctuary.Database.Entities.DbUser", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}

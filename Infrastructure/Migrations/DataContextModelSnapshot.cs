﻿// <auto-generated />
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Champion.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AppliesOnHits")
                        .HasColumnType("bit");

                    b.Property<string>("Cooldown")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DamageScalingsId")
                        .HasColumnType("int");

                    b.Property<int>("DamageType")
                        .HasColumnType("int");

                    b.Property<int>("HealScalingsId")
                        .HasColumnType("int");

                    b.Property<double>("Level")
                        .HasColumnType("float");

                    b.Property<string>("ManaCost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnHitScaling")
                        .HasColumnType("bit");

                    b.Property<int>("ShieldScalingsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DamageScalingsId");

                    b.HasIndex("HealScalingsId");

                    b.HasIndex("ShieldScalingsId");

                    b.ToTable("Ability");
                });

            modelBuilder.Entity("Domain.Champion.AbilityScalings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AbilityPowerId")
                        .HasColumnType("int");

                    b.Property<int>("AttackDamageId")
                        .HasColumnType("int");

                    b.Property<int>("AttackSpeedId")
                        .HasColumnType("int");

                    b.Property<int>("CriticalStrikeId")
                        .HasColumnType("int");

                    b.Property<int>("HealthId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AbilityPowerId");

                    b.HasIndex("AttackDamageId");

                    b.HasIndex("AttackSpeedId");

                    b.HasIndex("CriticalStrikeId");

                    b.HasIndex("HealthId");

                    b.ToTable("AbilityScalings");
                });

            modelBuilder.Entity("Domain.Champion.Champion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ChampionAbilitiesId")
                        .HasColumnType("int");

                    b.Property<int>("ChampionStatsBaseId")
                        .HasColumnType("int");

                    b.Property<int>("ChampionStatsGrowthId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChampionAbilitiesId");

                    b.HasIndex("ChampionStatsBaseId");

                    b.HasIndex("ChampionStatsGrowthId");

                    b.ToTable("Champions");
                });

            modelBuilder.Entity("Domain.Champion.ChampionAbilities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EId")
                        .HasColumnType("int");

                    b.Property<int>("PassiveId")
                        .HasColumnType("int");

                    b.Property<int>("QId")
                        .HasColumnType("int");

                    b.Property<int>("RId")
                        .HasColumnType("int");

                    b.Property<int>("WId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EId");

                    b.HasIndex("PassiveId");

                    b.HasIndex("QId");

                    b.HasIndex("RId");

                    b.HasIndex("WId");

                    b.ToTable("ChampionAbilities");
                });

            modelBuilder.Entity("Domain.Champion.ChampionStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Armor")
                        .HasColumnType("float");

                    b.Property<double>("AttackDamage")
                        .HasColumnType("float");

                    b.Property<double>("AttackSpeed")
                        .HasColumnType("float");

                    b.Property<double>("CritDamage")
                        .HasColumnType("float");

                    b.Property<double>("Health")
                        .HasColumnType("float");

                    b.Property<double>("HealthRegen")
                        .HasColumnType("float");

                    b.Property<double>("MagicResist")
                        .HasColumnType("float");

                    b.Property<double>("Mana")
                        .HasColumnType("float");

                    b.Property<double>("ManaRegen")
                        .HasColumnType("float");

                    b.Property<double>("MovementSpeed")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ChampionStats");
                });

            modelBuilder.Entity("Domain.Champion.ChampionStatVariants", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Base")
                        .HasColumnType("float");

                    b.Property<double>("Bonus")
                        .HasColumnType("float");

                    b.Property<double>("Missing")
                        .HasColumnType("float");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ChampionStatVariants");
                });

            modelBuilder.Entity("Domain.Champion.Ability", b =>
                {
                    b.HasOne("Domain.Champion.AbilityScalings", "DamageScalings")
                        .WithMany()
                        .HasForeignKey("DamageScalingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.AbilityScalings", "HealScalings")
                        .WithMany()
                        .HasForeignKey("HealScalingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.AbilityScalings", "ShieldScalings")
                        .WithMany()
                        .HasForeignKey("ShieldScalingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DamageScalings");

                    b.Navigation("HealScalings");

                    b.Navigation("ShieldScalings");
                });

            modelBuilder.Entity("Domain.Champion.AbilityScalings", b =>
                {
                    b.HasOne("Domain.Champion.ChampionStatVariants", "AbilityPower")
                        .WithMany()
                        .HasForeignKey("AbilityPowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.ChampionStatVariants", "AttackDamage")
                        .WithMany()
                        .HasForeignKey("AttackDamageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.ChampionStatVariants", "AttackSpeed")
                        .WithMany()
                        .HasForeignKey("AttackSpeedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.ChampionStatVariants", "CriticalStrike")
                        .WithMany()
                        .HasForeignKey("CriticalStrikeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.ChampionStatVariants", "Health")
                        .WithMany()
                        .HasForeignKey("HealthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AbilityPower");

                    b.Navigation("AttackDamage");

                    b.Navigation("AttackSpeed");

                    b.Navigation("CriticalStrike");

                    b.Navigation("Health");
                });

            modelBuilder.Entity("Domain.Champion.Champion", b =>
                {
                    b.HasOne("Domain.Champion.ChampionAbilities", "ChampionAbilities")
                        .WithMany()
                        .HasForeignKey("ChampionAbilitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.ChampionStats", "ChampionStatsBase")
                        .WithMany()
                        .HasForeignKey("ChampionStatsBaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.ChampionStats", "ChampionStatsGrowth")
                        .WithMany()
                        .HasForeignKey("ChampionStatsGrowthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChampionAbilities");

                    b.Navigation("ChampionStatsBase");

                    b.Navigation("ChampionStatsGrowth");
                });

            modelBuilder.Entity("Domain.Champion.ChampionAbilities", b =>
                {
                    b.HasOne("Domain.Champion.Ability", "E")
                        .WithMany()
                        .HasForeignKey("EId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.Ability", "Passive")
                        .WithMany()
                        .HasForeignKey("PassiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.Ability", "Q")
                        .WithMany()
                        .HasForeignKey("QId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.Ability", "R")
                        .WithMany()
                        .HasForeignKey("RId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Champion.Ability", "W")
                        .WithMany()
                        .HasForeignKey("WId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("E");

                    b.Navigation("Passive");

                    b.Navigation("Q");

                    b.Navigation("R");

                    b.Navigation("W");
                });
#pragma warning restore 612, 618
        }
    }
}

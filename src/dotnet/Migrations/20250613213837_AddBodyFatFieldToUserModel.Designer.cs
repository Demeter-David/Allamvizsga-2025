﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using dotnet.Data;

#nullable disable

namespace dotnet.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250613213837_AddBodyFatFieldToUserModel")]
    partial class AddBodyFatFieldToUserModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("dotnet.DAL.AppDevicesDAL", b =>
                {
                    b.Property<int>("UDID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UDID"));

                    b.Property<DateTime>("LastUsed")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Registered")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Used")
                        .HasColumnType("double precision");

                    b.HasKey("UDID");

                    b.ToTable("AppDevices");
                });

            modelBuilder.Entity("dotnet.DAL.CaloriesDAL", b =>
                {
                    b.Property<int>("CaloriesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CaloriesID"));

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("CaloriesID");

                    b.ToTable("Calories");
                });

            modelBuilder.Entity("dotnet.DAL.CaloriesGoalsDAL", b =>
                {
                    b.Property<int>("CaloriesGoalsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CaloriesGoalsID"));

                    b.Property<double?>("BurnGoal")
                        .HasColumnType("double precision");

                    b.Property<int?>("BurnStreak")
                        .HasColumnType("integer");

                    b.Property<double?>("IntakeGoal")
                        .HasColumnType("double precision");

                    b.Property<int?>("IntakeStreak")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastBurnStreakUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LastIntakeStreakUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double?>("OverallGoal")
                        .HasColumnType("double precision");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("CaloriesGoalsID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("CaloriesGoals");
                });

            modelBuilder.Entity("dotnet.DAL.FollowingDAL", b =>
                {
                    b.Property<int>("FollowingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("FollowingID"));

                    b.Property<int>("FollowedID")
                        .HasColumnType("integer");

                    b.Property<int>("FollowerID")
                        .HasColumnType("integer");

                    b.HasKey("FollowingID");

                    b.HasIndex("FollowedID");

                    b.HasIndex("FollowerID");

                    b.ToTable("Following");
                });

            modelBuilder.Entity("dotnet.DAL.GoalCheckedDAL", b =>
                {
                    b.Property<int>("GoalID")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.HasKey("GoalID");

                    b.ToTable("GoalChecked");
                });

            modelBuilder.Entity("dotnet.DAL.GoalDAL", b =>
                {
                    b.Property<int>("GoalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GoalID"));

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("GoalID");

                    b.HasIndex("UserID");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("dotnet.DAL.HeatmapDAL", b =>
                {
                    b.Property<int>("HeatmapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("HeatmapID"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("LevelID")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("HeatmapID");

                    b.HasIndex("LevelID");

                    b.HasIndex("UserID");

                    b.ToTable("Heatmap");
                });

            modelBuilder.Entity("dotnet.DAL.MealDAL", b =>
                {
                    b.Property<int>("MealID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MealID"));

                    b.Property<int>("CaloriesID")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("MealID");

                    b.HasIndex("CaloriesID")
                        .IsUnique();

                    b.HasIndex("UserID");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("dotnet.DAL.StepsDAL", b =>
                {
                    b.Property<int>("StepsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StepsID"));

                    b.Property<int>("CaloriesID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("StepsCount")
                        .HasColumnType("integer");

                    b.HasKey("StepsID");

                    b.HasIndex("CaloriesID")
                        .IsUnique();

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("dotnet.DAL.UserDAL", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserID"));

                    b.Property<int?>("Age")
                        .HasColumnType("integer");

                    b.Property<double?>("BodyFat")
                        .HasColumnType("double precision");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("Goal")
                        .HasColumnType("text");

                    b.Property<double?>("Height")
                        .HasColumnType("double precision");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("ParentID")
                        .HasColumnType("integer");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("bytea");

                    b.Property<string>("PhoneNum")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("ProfilePhotoPath")
                        .HasColumnType("text");

                    b.Property<int?>("UDID")
                        .HasColumnType("integer");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double?>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("UserID");

                    b.HasIndex("ParentID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("dotnet.DAL.WorkoutCaloriesDAL", b =>
                {
                    b.Property<int>("WorkoutID")
                        .HasColumnType("integer");

                    b.Property<int>("CaloriesID")
                        .HasColumnType("integer");

                    b.HasKey("WorkoutID");

                    b.HasIndex("CaloriesID")
                        .IsUnique();

                    b.ToTable("WorkoutCalories");
                });

            modelBuilder.Entity("dotnet.DAL.WorkoutCategoryDAL", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("CategoryID");

                    b.ToTable("WorkoutCategories");
                });

            modelBuilder.Entity("dotnet.DAL.WorkoutDAL", b =>
                {
                    b.Property<int>("WorkoutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WorkoutID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("integer");

                    b.Property<double>("Distance")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("WorkoutID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("UserID");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("dotnet.Models.AppLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("File")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Request")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AppLogs");
                });

            modelBuilder.Entity("dotnet.Models.Conversation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SystemContext")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("dotnet.Models.Levels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("dotnet.Models.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ConversationId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ConversationId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("dotnet.Models.UserAdvice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Advice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Prompt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserAdvices");
                });

            modelBuilder.Entity("dotnet.DAL.CaloriesGoalsDAL", b =>
                {
                    b.HasOne("dotnet.DAL.UserDAL", "User")
                        .WithOne("CaloriesGoals")
                        .HasForeignKey("dotnet.DAL.CaloriesGoalsDAL", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("dotnet.DAL.FollowingDAL", b =>
                {
                    b.HasOne("dotnet.DAL.UserDAL", "Followed")
                        .WithMany("Followers")
                        .HasForeignKey("FollowedID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("dotnet.DAL.UserDAL", "Follower")
                        .WithMany("FollowingUsers")
                        .HasForeignKey("FollowerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Followed");

                    b.Navigation("Follower");
                });

            modelBuilder.Entity("dotnet.DAL.GoalCheckedDAL", b =>
                {
                    b.HasOne("dotnet.DAL.GoalDAL", "Goal")
                        .WithMany("GoalChecked")
                        .HasForeignKey("GoalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Goal");
                });

            modelBuilder.Entity("dotnet.DAL.GoalDAL", b =>
                {
                    b.HasOne("dotnet.DAL.UserDAL", "User")
                        .WithMany("Goals")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("dotnet.DAL.HeatmapDAL", b =>
                {
                    b.HasOne("dotnet.Models.Levels", "Level")
                        .WithMany("Heatmaps")
                        .HasForeignKey("LevelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("dotnet.DAL.UserDAL", "User")
                        .WithMany("Heatmaps")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");

                    b.Navigation("User");
                });

            modelBuilder.Entity("dotnet.DAL.MealDAL", b =>
                {
                    b.HasOne("dotnet.DAL.CaloriesDAL", "Calories")
                        .WithOne("Meal")
                        .HasForeignKey("dotnet.DAL.MealDAL", "CaloriesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet.DAL.UserDAL", "User")
                        .WithMany("Meals")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calories");

                    b.Navigation("User");
                });

            modelBuilder.Entity("dotnet.DAL.StepsDAL", b =>
                {
                    b.HasOne("dotnet.DAL.CaloriesDAL", "Calories")
                        .WithOne("Steps")
                        .HasForeignKey("dotnet.DAL.StepsDAL", "CaloriesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calories");
                });

            modelBuilder.Entity("dotnet.DAL.UserDAL", b =>
                {
                    b.HasOne("dotnet.DAL.UserDAL", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("dotnet.DAL.WorkoutCaloriesDAL", b =>
                {
                    b.HasOne("dotnet.DAL.CaloriesDAL", "Calories")
                        .WithOne("WorkoutCalories")
                        .HasForeignKey("dotnet.DAL.WorkoutCaloriesDAL", "CaloriesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet.DAL.WorkoutDAL", "Workout")
                        .WithOne("WorkoutCalories")
                        .HasForeignKey("dotnet.DAL.WorkoutCaloriesDAL", "WorkoutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calories");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("dotnet.DAL.WorkoutDAL", b =>
                {
                    b.HasOne("dotnet.DAL.WorkoutCategoryDAL", "Category")
                        .WithMany("Workouts")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("dotnet.DAL.UserDAL", "User")
                        .WithMany("Workouts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("dotnet.Models.Conversation", b =>
                {
                    b.HasOne("dotnet.DAL.UserDAL", "User")
                        .WithMany("Conversations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("dotnet.Models.Message", b =>
                {
                    b.HasOne("dotnet.Models.Conversation", "Conversation")
                        .WithMany("Messages")
                        .HasForeignKey("ConversationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conversation");
                });

            modelBuilder.Entity("dotnet.Models.UserAdvice", b =>
                {
                    b.HasOne("dotnet.DAL.UserDAL", "User")
                        .WithMany("UserAdvices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("dotnet.DAL.CaloriesDAL", b =>
                {
                    b.Navigation("Meal");

                    b.Navigation("Steps");

                    b.Navigation("WorkoutCalories");
                });

            modelBuilder.Entity("dotnet.DAL.GoalDAL", b =>
                {
                    b.Navigation("GoalChecked");
                });

            modelBuilder.Entity("dotnet.DAL.UserDAL", b =>
                {
                    b.Navigation("CaloriesGoals");

                    b.Navigation("Children");

                    b.Navigation("Conversations");

                    b.Navigation("Followers");

                    b.Navigation("FollowingUsers");

                    b.Navigation("Goals");

                    b.Navigation("Heatmaps");

                    b.Navigation("Meals");

                    b.Navigation("UserAdvices");

                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("dotnet.DAL.WorkoutCategoryDAL", b =>
                {
                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("dotnet.DAL.WorkoutDAL", b =>
                {
                    b.Navigation("WorkoutCalories")
                        .IsRequired();
                });

            modelBuilder.Entity("dotnet.Models.Conversation", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("dotnet.Models.Levels", b =>
                {
                    b.Navigation("Heatmaps");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Assassin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assassin.Migrations
{
    [DbContext(typeof(AssassinContext))]
    [Migration("20190522182410_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Assassin.Models.Contract", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("assassin_id");

                    b.Property<DateTime>("contract_end");

                    b.Property<DateTime>("contract_start");

                    b.Property<int>("game_id");

                    b.Property<int>("is_fulfilled");

                    b.Property<int>("target_id");

                    b.Property<string>("weapon");

                    b.HasKey("id");

                    b.ToTable("contracts");
                });

            modelBuilder.Entity("Assassin.Models.Game", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("is_end");

                    b.Property<int>("is_start");

                    b.Property<int>("latest_kill_id");

                    b.Property<string>("password");

                    b.Property<string>("team_name");

                    b.HasKey("id");

                    b.ToTable("games");
                });

            modelBuilder.Entity("Assassin.Models.Player", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("assassin_id");

                    b.Property<string>("code_name");

                    b.Property<string>("email");

                    b.Property<int>("game_id");

                    b.Property<string>("image_url");

                    b.Property<int>("is_admin");

                    b.Property<int>("is_alive");

                    b.Property<string>("name");

                    b.Property<string>("password");

                    b.Property<string>("phone_number");

                    b.Property<int>("sock_score");

                    b.Property<int>("spoon_score");

                    b.HasKey("id");

                    b.ToTable("players");
                });
#pragma warning restore 612, 618
        }
    }
}
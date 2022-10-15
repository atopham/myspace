﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myspace.Data;

#nullable disable

namespace myspace.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ContactEventPerson", b =>
                {
                    b.Property<int>("ContactEventsContactEventId")
                        .HasColumnType("int");

                    b.Property<int>("PeoplePersonId")
                        .HasColumnType("int");

                    b.HasKey("ContactEventsContactEventId", "PeoplePersonId");

                    b.HasIndex("PeoplePersonId");

                    b.ToTable("ContactEventPerson");
                });

            modelBuilder.Entity("ContactEventTag", b =>
                {
                    b.Property<int>("ContactEventsContactEventId")
                        .HasColumnType("int");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("int");

                    b.HasKey("ContactEventsContactEventId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("ContactEventTag");
                });

            modelBuilder.Entity("myspace.Data.ContactEvent", b =>
                {
                    b.Property<int>("ContactEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ContactTemplateID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeOccurred")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Impression")
                        .HasColumnType("int");

                    b.Property<int>("Medium")
                        .HasColumnType("int");

                    b.Property<bool>("NeedsFollowUp")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("ContactEventId");

                    b.HasIndex("ContactTemplateID");

                    b.ToTable("ContactEvents");

                    b.HasData(
                        new
                        {
                            ContactEventId = 1,
                            DateTimeOccurred = new DateTime(2022, 10, 14, 9, 47, 17, 897, DateTimeKind.Local).AddTicks(6550),
                            Impression = 0,
                            Medium = 4,
                            NeedsFollowUp = false,
                            Title = "Work social"
                        });
                });

            modelBuilder.Entity("myspace.Data.ContactTemplate", b =>
                {
                    b.Property<int>("ContactTemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BodyText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Greeting")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ContactTemplateId");

                    b.ToTable("ContactTemplates");

                    b.HasData(
                        new
                        {
                            ContactTemplateId = 1,
                            BodyText = "It's been too long. How are things for you? I would love to hear an update about your family, too. \n\nBest, {1}",
                            Greeting = "Hey {0}!"
                        });
                });

            modelBuilder.Entity("myspace.Data.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ContactEventID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("NoteId");

                    b.HasIndex("ContactEventID");

                    b.HasIndex("PersonId");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            NoteId = 1,
                            CreatedDate = new DateTime(2022, 10, 15, 9, 47, 17, 897, DateTimeKind.Local).AddTicks(6500),
                            PersonId = 1,
                            Text = "John is awesome!"
                        });
                });

            modelBuilder.Entity("myspace.Data.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageFile")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<long?>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.HasKey("PersonId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            FirstName = "John",
                            ImageFile = "test1.jpeg",
                            LastName = "Test",
                            PhoneNumber = 8773012998L
                        },
                        new
                        {
                            PersonId = 2,
                            FirstName = "Charles",
                            ImageFile = "test2.jpeg",
                            LastName = "Test",
                            PhoneNumber = 8783022999L
                        });
                });

            modelBuilder.Entity("myspace.Data.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            TagId = 1,
                            Text = "School"
                        },
                        new
                        {
                            TagId = 2,
                            Text = "Work"
                        });
                });

            modelBuilder.Entity("PersonTag", b =>
                {
                    b.Property<int>("PeoplePersonId")
                        .HasColumnType("int");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("int");

                    b.HasKey("PeoplePersonId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("PersonTag");
                });

            modelBuilder.Entity("ContactEventPerson", b =>
                {
                    b.HasOne("myspace.Data.ContactEvent", null)
                        .WithMany()
                        .HasForeignKey("ContactEventsContactEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("myspace.Data.Person", null)
                        .WithMany()
                        .HasForeignKey("PeoplePersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContactEventTag", b =>
                {
                    b.HasOne("myspace.Data.ContactEvent", null)
                        .WithMany()
                        .HasForeignKey("ContactEventsContactEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("myspace.Data.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("myspace.Data.ContactEvent", b =>
                {
                    b.HasOne("myspace.Data.ContactTemplate", null)
                        .WithMany("ContactEvents")
                        .HasForeignKey("ContactTemplateID");
                });

            modelBuilder.Entity("myspace.Data.Note", b =>
                {
                    b.HasOne("myspace.Data.ContactEvent", null)
                        .WithMany("Notes")
                        .HasForeignKey("ContactEventID");

                    b.HasOne("myspace.Data.Person", null)
                        .WithMany("Notes")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("PersonTag", b =>
                {
                    b.HasOne("myspace.Data.Person", null)
                        .WithMany()
                        .HasForeignKey("PeoplePersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("myspace.Data.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("myspace.Data.ContactEvent", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("myspace.Data.ContactTemplate", b =>
                {
                    b.Navigation("ContactEvents");
                });

            modelBuilder.Entity("myspace.Data.Person", b =>
                {
                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using AspnetBr.Api.Models;

namespace AspnetBr.Api.Migrations
{
    [DbContext(typeof(AspnetBrContext))]
    partial class jdfahsduf
    {
        public override string Id
        {
            get { return "20151010232100_jdfahsduf"; }
        }

        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Annotation("ProductVersion", "7.0.0-beta7-15540");

            modelBuilder.Entity("AspnetBr.Api.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventId");

                    b.Property<string>("Text");

                    b.Property<string>("Type");

                    b.Key("Id");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("Edition");

                    b.Property<int?>("LocalId");

                    b.Property<string>("Title");

                    b.Key("Id");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Local", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("MapsUrl");

                    b.Property<string>("Name");

                    b.Key("Id");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Key("Id");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.ScheduleItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Finish");

                    b.Property<int>("Order");

                    b.Property<int?>("ScheduleId");

                    b.Property<DateTime>("Start");

                    b.Property<int?>("TalkId");

                    b.Property<string>("TimeInfo");

                    b.Property<string>("Title");

                    b.Key("Id");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<string>("Fullname");

                    b.Property<string>("PhotoUrl");

                    b.Property<int?>("TalkId");

                    b.Property<string>("Title");

                    b.Key("Id");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Sponsor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventId");

                    b.Property<string>("Level");

                    b.Property<string>("Name");

                    b.Key("Id");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Talk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Key("Id");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Track", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("Day");

                    b.Property<string>("Description");

                    b.Property<int?>("EventId");

                    b.Property<string>("Room");

                    b.Property<string>("Title");

                    b.Key("Id");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Contact", b =>
                {
                    b.Reference("AspnetBr.Api.Models.Event")
                        .InverseCollection()
                        .ForeignKey("EventId");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Event", b =>
                {
                    b.Reference("AspnetBr.Api.Models.Local")
                        .InverseCollection()
                        .ForeignKey("LocalId");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.ScheduleItem", b =>
                {
                    b.Reference("AspnetBr.Api.Models.Schedule")
                        .InverseCollection()
                        .ForeignKey("ScheduleId");

                    b.Reference("AspnetBr.Api.Models.Talk")
                        .InverseCollection()
                        .ForeignKey("TalkId");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Speaker", b =>
                {
                    b.Reference("AspnetBr.Api.Models.Talk")
                        .InverseCollection()
                        .ForeignKey("TalkId");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Sponsor", b =>
                {
                    b.Reference("AspnetBr.Api.Models.Event")
                        .InverseCollection()
                        .ForeignKey("EventId");
                });

            modelBuilder.Entity("AspnetBr.Api.Models.Track", b =>
                {
                    b.Reference("AspnetBr.Api.Models.Event")
                        .InverseCollection()
                        .ForeignKey("EventId");

                    b.Reference("AspnetBr.Api.Models.Schedule")
                        .InverseReference()
                        .ForeignKey("AspnetBr.Api.Models.Track", "Id");
                });
        }
    }
}

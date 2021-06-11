﻿// <auto-generated />
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackEnd.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Aluno");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Marta",
                            sobrenome = "Kent",
                            telefone = "33225555"
                        },
                        new
                        {
                            id = 2,
                            nome = "Paula",
                            sobrenome = "Isabela",
                            telefone = "3354288"
                        },
                        new
                        {
                            id = 3,
                            nome = "Laura",
                            sobrenome = "Antonia",
                            telefone = "55668899"
                        },
                        new
                        {
                            id = 4,
                            nome = "Luiza",
                            sobrenome = "Maria",
                            telefone = "6565659"
                        },
                        new
                        {
                            id = 5,
                            nome = "Lucas",
                            sobrenome = "Machado",
                            telefone = "565685415"
                        },
                        new
                        {
                            id = 6,
                            nome = "Pedro",
                            sobrenome = "Alvares",
                            telefone = "456454545"
                        },
                        new
                        {
                            id = 7,
                            nome = "Paulo",
                            sobrenome = "José",
                            telefone = "9874512"
                        });
                });

            modelBuilder.Entity("BackEnd.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("alunoId")
                        .HasColumnType("int");

                    b.Property<int>("disciplinaId")
                        .HasColumnType("int");

                    b.HasKey("alunoId", "disciplinaId");

                    b.HasIndex("disciplinaId");

                    b.ToTable("AlunoDisciplina");

                    b.HasData(
                        new
                        {
                            alunoId = 1,
                            disciplinaId = 2
                        },
                        new
                        {
                            alunoId = 1,
                            disciplinaId = 4
                        },
                        new
                        {
                            alunoId = 1,
                            disciplinaId = 5
                        },
                        new
                        {
                            alunoId = 2,
                            disciplinaId = 1
                        },
                        new
                        {
                            alunoId = 2,
                            disciplinaId = 2
                        },
                        new
                        {
                            alunoId = 2,
                            disciplinaId = 5
                        },
                        new
                        {
                            alunoId = 3,
                            disciplinaId = 1
                        },
                        new
                        {
                            alunoId = 3,
                            disciplinaId = 2
                        },
                        new
                        {
                            alunoId = 3,
                            disciplinaId = 3
                        },
                        new
                        {
                            alunoId = 4,
                            disciplinaId = 1
                        },
                        new
                        {
                            alunoId = 4,
                            disciplinaId = 4
                        },
                        new
                        {
                            alunoId = 4,
                            disciplinaId = 5
                        },
                        new
                        {
                            alunoId = 5,
                            disciplinaId = 4
                        },
                        new
                        {
                            alunoId = 5,
                            disciplinaId = 5
                        },
                        new
                        {
                            alunoId = 6,
                            disciplinaId = 1
                        },
                        new
                        {
                            alunoId = 6,
                            disciplinaId = 2
                        },
                        new
                        {
                            alunoId = 6,
                            disciplinaId = 3
                        },
                        new
                        {
                            alunoId = 6,
                            disciplinaId = 4
                        },
                        new
                        {
                            alunoId = 7,
                            disciplinaId = 1
                        },
                        new
                        {
                            alunoId = 7,
                            disciplinaId = 2
                        },
                        new
                        {
                            alunoId = 7,
                            disciplinaId = 3
                        },
                        new
                        {
                            alunoId = 7,
                            disciplinaId = 4
                        },
                        new
                        {
                            alunoId = 7,
                            disciplinaId = 5
                        });
                });

            modelBuilder.Entity("BackEnd.Models.Disciplina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("professorId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("professorId");

                    b.ToTable("Disciplina");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Matemática",
                            professorId = 1
                        },
                        new
                        {
                            id = 2,
                            nome = "Física",
                            professorId = 2
                        },
                        new
                        {
                            id = 3,
                            nome = "Português",
                            professorId = 3
                        },
                        new
                        {
                            id = 4,
                            nome = "Inglês",
                            professorId = 4
                        },
                        new
                        {
                            id = 5,
                            nome = "Programação",
                            professorId = 5
                        });
                });

            modelBuilder.Entity("BackEnd.Models.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Professor");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Lauro"
                        },
                        new
                        {
                            id = 2,
                            nome = "Roberto"
                        },
                        new
                        {
                            id = 3,
                            nome = "Ronaldo"
                        },
                        new
                        {
                            id = 4,
                            nome = "Rodrigo"
                        },
                        new
                        {
                            id = 5,
                            nome = "Alexandre"
                        });
                });

            modelBuilder.Entity("BackEnd.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("BackEnd.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("alunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Models.Disciplina", "Disciplina")
                        .WithMany("AlunoDisciplinas")
                        .HasForeignKey("disciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("BackEnd.Models.Disciplina", b =>
                {
                    b.HasOne("BackEnd.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("professorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("BackEnd.Models.Aluno", b =>
                {
                    b.Navigation("AlunosDisciplinas");
                });

            modelBuilder.Entity("BackEnd.Models.Disciplina", b =>
                {
                    b.Navigation("AlunoDisciplinas");
                });

            modelBuilder.Entity("BackEnd.Models.Professor", b =>
                {
                    b.Navigation("Disciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}

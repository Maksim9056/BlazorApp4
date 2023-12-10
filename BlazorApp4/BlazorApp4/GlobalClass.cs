using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore;
using BlazorApp3.Components.ClassType;
using System;
using BlazorApp4.Components.ClassType;
using Microsoft.Identity.Client;
namespace BlazorApp4
{
    public class GlobalClass
    {


        /// <summary>
        /// https://metanit.com/sharp/efcore/1.2.php
        /// </summary>
        public class ApplicationContext : DbContext
        {

            public DbSet<LessonType> LessonTypes { get; set; } = null!;
            public DbSet<Teacher> Teachers { get; set; } = null!;
            public DbSet<Classroom> Classrooms { get; set; } = null!;
            public DbSet<Student> Students { get; set; } = null!;
            public DbSet<Group> Group { get; set; } = null!;


            public DbSet<StudentGroup> _StudentGroup { get; set; } = null!;
            public DbSet<ClassroomTeacherLink> _ClassroomTeacherLink { get; set; } = null!;
            public DbSet<StudentTeacherSubjectLink> _StudentTeacherSubjectLink { get; set; } = null!;
            public DbSet<Subject> _Subject { get; set; } = null!;

            public DbSet<Lesson> _Lesson { get; set; } = null!;
            public DbSet<LessonSchedule> _LessonSchedule { get; set; } = null!;

            public ApplicationContext()
            {
                // Database.EnsureDeleted(); // гарантируем, что бд удалена
                Database.EnsureCreated(); // гарантируем, что бд будет созд
                                          // Database.Migrate();  // миграция
                                          // Database.MigrateAsync(); // асинхронный метод для миграции
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                switch (2)
                {
                    case 1: // Postgres
                        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=leson;Username=postgres;Password=1");
                        break;
                    case 2: // SQLite
                        optionsBuilder.UseSqlite("Data Source=leson.db");
                        break;
                    case 3: // SQL Server
                        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=lesons;Trusted_Connection=True;");
                        break;
                }
            }
        }

        public void CreateDatabase()
        {
            using (var context = new ApplicationContext())
            {

            }
        }

        public void Add()
        {
            //// Создание объекта типа LessonType
            //var lessonType = new LessonType
            //{
            //    Id = 1, // Уникальный идентификатор типа занятия
            //    Name = "Математика", // Название типа занятия
            //    Status = "Активен" // Статус типа занятия
            //};

            //// Добавление объекта в базу данных
            //using (var context = new ApplicationContext())
            //{
            //    context.LessonTypes.Add(lessonType); // Добавление объекта в DbSet LessonTypes
            //    context.SaveChanges(); // Сохранение изменений в базе данных
            //}

            //Console.WriteLine("LessonType добавлен в базу данных.");


            //// Создание объекта типа Classroom
            //var classroom = new Classroom
            //{
            //    Id = 1, // Уникальный идентификатор кабинета
            //    Name = "101", // Название кабинета
            //    Address = "Улица Пушкина, 10", // Адрес кабинета
            //    Status = "Активен" // Статус кабинета
            //};

            //// Добавление объекта в базу данных
            //using (var context = new ApplicationContext())
            //{
            //    context.Classrooms.Add(classroom); // Добавление объекта в DbSet Classrooms
            //    context.SaveChanges(); // Сохранение изменений в базе данных
            //}

            //Console.WriteLine("Classroom добавлен в базу данных.");



            //// Создание объекта типа Student
            //var student = new Student
            //{
            //    Id = 1, // Уникальный идентификатор студента
            //    FirstName = "Иван", // Имя студента
            //    LastName = "Иванов", // Фамилия студента
            //    Email = "ivan@example.com", // Адрес электронной почты студента
            //    ContactNumber = "123456789", // Контактный номер студента
            //    GroupName = "Группа A", // Название группы студента
            //    Status = "Активен" // Статус студента
            //};

            //// Добавление объекта в базу данных
            //using (var context = new ApplicationContext())
            //{
            //    context.Students.Add(student); // Добавление объекта в DbSet Students
            //    context.SaveChanges(); // Сохранение изменений в базе данных
            //}

            //Console.WriteLine("Student добавлен в базу данных.");


            ////// Создание объекта типа LessonSchedule
            ////var lessonSchedule = new LessonSchedule
            ////{
            ////    Id = 1, // Уникальный идентификатор расписания занятий
            ////    LessonID = 1, // Уникальный идентификатор занятия
            ////    TeacherID = 1, // Уникальный идентификатор преподавателя
            ////    StudentID = 1, // Уникальный идентификатор студента
            ////    SubjectID = 1, // Уникальный идентификатор предмета
            ////    LessonTypeID = 1, // Уникальный идентификатор типа занятия
            ////    ClassroomID = 1, // Уникальный идентификатор кабинета
            ////    Date = DateTime.Now, // Дата занятия
            ////    Time = "10:00", // Время занятия
            ////    Status = "Активно" // Статус занятия
            ////};

            //// Добавление объекта в базу данных
            ////using (var context = new ApplicationContext())
            ////{
            ////    context.Database.EnsureCreated(); // Создание базы данных, если она не существует
            ////    context._LessonSchedule.Add(lessonSchedule); // Добавление объекта в DbSet LessonSchedules
            ////    context.SaveChanges(); // Сохранение изменений в базе данных
            ////}

            //Console.WriteLine("LessonSchedule добавлен в базу данных.");

            //// Создание объекта типа Lesson
            //var lesson = new Lesson
            //{
            //    Id = 1, // Уникальный идентификатор занятия
            //    TeacherID = 1, // Уникальный идентификатор преподавателя
            //    StudentID = 1, // Уникальный идентификатор студента
            //    Group = "GroupA", // Уникальный идентификатор для группы
            //    LessonTypeID = 1, // Уникальный идентификатор типа занятия
            //    ClassroomID = 1, // Уникальный идентификатор кабинета
            //    Status = "Активно" // Статус занятия
            //};

            //// Добавление объекта в базу данных
            //using (var context = new ApplicationContext())
            //{
            //    context._Lesson.Add(lesson); // Добавление объекта в DbSet Lessons
            //    context.SaveChanges(); // Сохранение изменений в базе данных
            //}

            //Console.WriteLine("Lesson добавлен в базу данных.");


            //// Создание объекта типа Subject
            //var subject = new Subject
            //{
            //    Id = 1, // Уникальный идентификатор предмета
            //    Name = "Математика", // Название предмета
            //    Status = "Активен" // Статус предмета
            //};

            //// Добавление объекта в базу данных
            //using (var context = new ApplicationContext())
            //{
            //    context.Database.EnsureCreated(); // Создание базы данных, если она не существует
            //    context._Subject.Add(subject); // Добавление объекта в DbSet Subjects
            //    context.SaveChanges(); // Сохранение изменений в базе данных
            //}

            //Console.WriteLine("Subject добавлен в базу данных.");


            DateTime localDateTime = DateTime.Now;
            using (var context = new ApplicationContext())
            {
                // Заполнение данных для таблицы Classroom
                var classroom = new Classroom
                {
                    Name = "Classroom 101",
                    Address = "123 Main Street",
                    Status = "Active"
                };
                context.Classrooms.Add(classroom);

                // Заполнение данных для таблицы ClassroomTeacherLink
                var classroomTeacherLink = new ClassroomTeacherLink
                {
                    ClassroomID = 1, // ID кабинета, который уже существует
                    TeacherID = 1     // ID преподавателя, который уже существует
                };
                context._ClassroomTeacherLink.Add(classroomTeacherLink);

                // Заполнение данных для таблицы Group
                var group = new Group
                {
                    _Group = "Group A"
                };
                context.Group.Add(group);


                // Заполнение данных для таблицы Lesson
                var lesson = new Lesson
                {
                    TeacherID = 1, // ID преподавателя, который уже существует
                    StudentID = 1, // ID студента, который уже существует
                    Group = "Group A",
                    LessonTypeID = 1, // ID типа занятия, который уже существует
                    ClassroomID = 1, // ID кабинета, который уже существует
                    Status = "Active"
                };

                context._Lesson.Add(lesson);

                // Заполнение данных для таблицы LessonSchedule
                var lessonSchedule = new LessonSchedule
                {
                    LessonID = 1, // ID занятия, которое уже существует
                    TeacherID = 1, // ID преподавателя, который уже существует
                    StudentID = 1, // ID студента, который уже существует
                    GroupId = "Group A",
                    SubjectID = 1, // ID предмета, который уже существует
                    LessonTypeID = 1, // ID типа занятия, который уже существует
                    ClassroomID = 1, // ID кабинета, который уже существует
                    Weekday = "Понедельник",
                    Time = "10:00 AM",
                    Status = "Active"
                };
                context._LessonSchedule.Add(lessonSchedule);

                // Заполнение данных для таблицы LessonType
                var lessonType = new LessonType
                {
                    Name = "Lecture",
                    Status = "Active"
                };
                context.LessonTypes.Add(lessonType);

                // Заполнение данных для таблицы Student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john@example.com",
                    ContactNumber = "123-456-7890",
                    GroupName = "Group A",
                    Status = "Active"
                };
                context.Students.Add(student);

                // Заполнение данных для таблицы StudentGroup
                var studentGroup = new StudentGroup
                {
                    GroupName = "Group A",
                    _StudentGroup = 1, // ID студента, который уже существует
                    Status = "Active" // Укажите значение для столбца Status


                };
                context._StudentGroup.Add(studentGroup);

                // Заполнение данных для таблицы StudentTeacherSubjectLink
                var studentTeacherSubjectLink = new StudentTeacherSubjectLink
                {
                    GroudId = "Group A",
                    StudentID = 1, // ID студента, который уже существует
                    TeacherID = 1, // ID преподавателя, который уже существует
                    SubjectID = 1 // ID предмета, который уже существует
                };
                context._StudentTeacherSubjectLink.Add(studentTeacherSubjectLink);

                // Заполнение данных для таблицы Subject
                var subject = new Subject
                {
                    Name = "Mathematics",
                    Status = "Active"
                };
                context._Subject.Add(subject);

                // Заполнение данных для таблицы Teacher
                var teacher = new Teacher
                {
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane@example.com",
                    ContactNumber = "987-654-3210",
                    Status = "Active"
                };
                context.Teachers.Add(teacher);

                // Сохранение всех изменений в базе данных
                context.SaveChanges();
            }

        }

        public class Studyschedule
        {
            /// <summary>
            /// Уникальный идентификатор расписание занятий 
            /// </summary>
            public List<int> Id { get; set; }  = new List<int>();

            /// <summary>
            /// Уникальный идентификатор занятия
            /// </summary>
            public List<Lesson> LessonID { get; set; } = new List<Lesson>();

            /// <summary>
            /// Уникальный идентификатор преподавателя
            /// </summary>
            public List<Teacher> TeacherID { get; set; } = new List<Teacher>();
            /// <summary>
            /// Уникальный идентификатор студента
            /// </summary>
            public List<Student> StudentID { get; set; } = new List<Student>();


            /// <summary>
            /// Уникальный идентификатор Группы
            /// </summary>
            public List<Group> GroupId { get; set; } = new List<Group>();
            /// <summary>
            /// Уникальный идентификатор предмета
            /// </summary>
            public List<Subject> SubjectID { get; set; } = new List<Subject>();

            /// <summary>
            /// Уникальный идентификатор типа занятия
            /// </summary>
            public List<LessonType> LessonTypeID { get; set; } = new List<LessonType>();
            /// <summary>
            /// Уникальный идентификатор кабинета
            /// </summary>
            public List<Classroom> ClassroomID { get; set; } = new List<Classroom>();
            /// <summary>
            /// Дата занятия
            /// </summary>
            public List<string> Date { get; set; } = new List<string>();
            /// <summary>
            /// Время занятия
            /// </summary>
            public List<string> Time { get; set; } = new List<string>();

            /// <summary>
            /// Статус занятия (например, "Активно" или "Отменено")
            /// </summary>
            public List<string> Status { get; set; } = new List<string>();

        }

        //public  List<LessonSchedule> Select()
        //{

        //    List < LessonSchedule > lessonSchedules = new List< LessonSchedule >();

        //    using (var context = new ApplicationContext())
        //    {
        //        lessonSchedules =    context._LessonSchedule.ToList();

        //        var sd = context.Teachers.Find();

        //        Studyschedule studyschedule = new Studyschedule();
        //        List<int> id = new List<int>();
        //        List<DateTime> Date = new List<DateTime>();

        //        List<string> Time = new List<string>();


        //        List<string> Status = new List<string>();
        //        for (int  i = 0; i < lessonSchedules.Count; i++)
        //        {

        //            id.Add(lessonSchedules[i].Id);


        //          var leson =      context._Lesson.Find(lessonSchedules[i].LessonID);
        //           var teacher =    context.Teachers.Find( lessonSchedules[i].TeacherID);
        //            var student = context.Students.Find(lessonSchedules[i].StudentID);
        //            var group =      context.Group.Find(lessonSchedules[i].GroupId);
        //            //var group = context.Group.Find(lessonSchedules[i].GroupId);
        //            var Subject = context._Subject.Find(lessonSchedules[i].SubjectID);
        //            var lessonTypes = context.LessonTypes.Find(lessonSchedules[i].LessonTypeID);
        //            var classrooms = context.Classrooms.Find(lessonSchedules[i].ClassroomID);

        //            studyschedule.LessonID.Add(leson);
        //            studyschedule.TeacherID.Add(teacher);
        //            studyschedule.StudentID.Add(student);
        //            studyschedule.GroupId.Add(group);
        //            studyschedule.SubjectID.Add(Subject);
        //            studyschedule.LessonTypeID.Add(lessonTypes);
        //            studyschedule.ClassroomID.Add(classrooms);

        //            Date.Add(lessonSchedules[i].Date);
        //            Time.Add(lessonSchedules[i].Time);
        //            Status.Add(lessonSchedules[i].Status);
        //            //studyschedule.LessonID.Add(leson);


        //            //var Clas =  context.Classrooms.Find(lessonSchedules[i].ClassroomID);


        //        }




        //    }

        //    return lessonSchedules;
        //}
        public Studyschedule Select()
        {
         Studyschedule studyschedule = new Studyschedule();

            List<LessonSchedule> lessonSchedules = new List<LessonSchedule>();

            using (var context = new ApplicationContext())
            {
                lessonSchedules = context._LessonSchedule.ToList();

                List<int> id = new List<int>();
                List<string> Date = new List<string>();

                List<string> Time = new List<string>();


                List<string> Status = new List<string>();
                for (int i = 0; i < lessonSchedules.Count; i++)
                {

                    id.Add(lessonSchedules[i].Id);


                    var leson = context._Lesson.FirstOrDefault(ue =>ue.Id == lessonSchedules[i].LessonID);
                    var teacher = context.Teachers.FirstOrDefault(ue => ue.Id  == lessonSchedules[i].TeacherID);
                    var student = context.Students.FirstOrDefault(ue => ue.Id == lessonSchedules[i].StudentID);
                    var group = context.Group.FirstOrDefault(ue => ue._Group == lessonSchedules[i].GroupId);
                    //var group = context.Group.Find(lessonSchedules[i].GroupId);
                    var Subject = context._Subject.FirstOrDefault(ue => ue.Id == lessonSchedules[i].SubjectID);
                    var lessonTypes = context.LessonTypes.FirstOrDefault(ue => ue.Id ==  lessonSchedules[i].LessonTypeID);
                    var classrooms = context.Classrooms.FirstOrDefault(ue => ue.Id == lessonSchedules[i].ClassroomID);

                    studyschedule.LessonID.Add(leson);
                    studyschedule.TeacherID.Add(teacher);
                    studyschedule.StudentID.Add(student);
                    studyschedule.GroupId.Add(group);
                    studyschedule.SubjectID.Add(Subject);
                    studyschedule.LessonTypeID.Add(lessonTypes);
                    studyschedule.ClassroomID.Add(classrooms);

                    Date.Add(lessonSchedules[i].Weekday);
                    Time.Add(lessonSchedules[i].Time);
                    Status.Add(lessonSchedules[i].Status);
                    //studyschedule.LessonID.Add(leson);


                    //var Clas =  context.Classrooms.Find(lessonSchedules[i].ClassroomID);


                }
                studyschedule.Id = id;
                studyschedule.Date  = Date;

                studyschedule.Time = Time;
                studyschedule.Status = Status;

            }

            return studyschedule;
        }

        //public class LessonType
        //{
        //    public int LessonTypeID { get; set; }
        //    public string Name { get; set; }
        //    public string Status { get; set; }
        //}

        //public class Teacher
        //{
        //    public int TeacherID { get; set; }
        //    public string FirstName { get; set; }
        //    public string LastName { get; set; }
        //    public string Email { get; set; }
        //    public string ContactNumber { get; set; }
        //    public string Status { get; set; }
        //}

        //public class Student
        //{
        //    public int StudentID { get; set; }
        //    public string FirstName { get; set; }
        //    public string LastName { get; set; }
        //    public string Email { get; set; }
        //    public string ContactNumber { get; set; }
        //    public string GroupName { get; set; }
        //    public string Status { get; set; }
        //}

        //public class Classroom
        //{
        //    public int ClassroomID { get; set; }
        //    public string Name { get; set; }
        //    public string Address { get; set; }
        //    public string Status { get; set; }
        //}

        //public class ClassroomTeacherLink
        //{
        //    public int ClassroomID { get; set; }
        //    public int TeacherID { get; set; }
        //}

        //public class StudentTeacherSubjectLink
        //{
        //    public int StudentID { get; set; }
        //    public int TeacherID { get; set; }
        //    public int SubjectID { get; set; }
        //}

        //public class Lesson
        //{
        //    public int LessonID { get; set; }
        //    public int TeacherID { get; set; }
        //    public int StudentID { get; set; }
        //    public int LessonTypeID { get; set; }
        //    public int ClassroomID { get; set; }
        //    public string Status { get; set; }
        //}

        //public class Subject
        //{
        //    public int SubjectID { get; set; }
        //    public string Name { get; set; }
        //    public string Status { get; set; }
        //}

        //public class StudentGroup
        //{
        //    public string GroupName { get; set; }
        //    public string Status { get; set; }
        //}

        //public class LessonSchedule
        //{
        //    public int LessonID { get; set; }
        //    public int TeacherID { get; set; }
        //    public int StudentID { get; set; }
        //    public int SubjectID { get; set; }
        //    public int LessonTypeID { get; set; }
        //    public int ClassroomID { get; set; }
        //    public DateTime Date { get; set; }
        //    public string Time { get; set; }
        //    public string Status { get; set; }
        //}
    }
}

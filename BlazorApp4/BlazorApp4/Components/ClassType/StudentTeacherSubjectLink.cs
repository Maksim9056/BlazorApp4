namespace BlazorApp4.Components.ClassType
{
    // Класс, представляющий связь между студентами, преподавателями и предметами
    public class StudentTeacherSubjectLink
    {
        public int Id { get; set; } // Уникальный идентификатор студента
        public string GroudId { get; set; } // Уникальный идентификатор Группа
        public int StudentID { get; set; } // Уникальный идентификатор студента
        public int TeacherID { get; set; } // Уникальный идентификатор преподавателя
        public int SubjectID { get; set; } // Уникальный идентификатор предмета
    }
}

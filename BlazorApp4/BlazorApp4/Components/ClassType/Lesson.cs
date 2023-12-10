namespace BlazorApp4.Components.ClassType
{
    // Класс, описывающий занятия
    public class Lesson
    {
        public int Id { get; set; } // Уникальный идентификатор занятия
        public int TeacherID { get; set; } // Уникальный идентификатор преподавателя
        public int StudentID { get; set; } // Уникальный идентификатор студента
        public string Group { get; set; }// Уникальный идентификатор для группы
        public int LessonTypeID { get; set; } // Уникальный идентификатор типа занятия
        public int ClassroomID { get; set; } // Уникальный идентификатор кабинета
        public string Status { get; set; } // Статус занятия (например, "Активно" или "Отменено")
    }
}

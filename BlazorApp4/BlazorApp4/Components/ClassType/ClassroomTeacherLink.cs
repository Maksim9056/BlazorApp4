namespace BlazorApp4.Components.ClassType
{
    // Класс, представляющий связь между кабинетами и преподавателями
    public class ClassroomTeacherLink
    {
        public int Id { get; set; } // Уникальный идентификатор   представляющий связь между кабинетами и преподавателями

        public int ClassroomID { get; set; } // Уникальный идентификатор кабинета
        public int TeacherID { get; set; } // Уникальный идентификатор преподавателя
    }
}

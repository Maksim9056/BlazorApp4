namespace BlazorApp3.Components.ClassType
{
    // Класс, представляющий группы студентов
    public class StudentGroup
    {
        public int Id { get; set; } // Уникальный идентификатор студентов

        public string GroupName { get; set; } // Название группы студентов
        public int _StudentGroup { get; set; } // Уникальный идентификатор студентов

        public string Status { get; set; } // Статус группы студентов (например, "Активна" или "Неактивна")
    }
}

namespace BlazorApp4.Components.ClassType
{
    // Класс описывающий типы занятий
    public class LessonType
    {
        public int Id { get; set; } // Уникальный идентификатор типа занятия
        public string Name { get; set; } // Название типа занятия
        public string Status { get; set; } // Статус типа занятия (например, "Активен" или "Неактивен")
    }
}

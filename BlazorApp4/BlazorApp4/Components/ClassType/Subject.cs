namespace BlazorApp3.Components.ClassType
{
    // Класс, описывающий предметы
    public class Subject
    {
        public int Id { get; set; } // Уникальный идентификатор предмета
        public string Name { get; set; } // Название предмета
        public string Status { get; set; } // Статус предмета (например, "Активен" или "Неактивен")
    }
}

namespace BlazorApp4.Components.ClassType
{
    // Класс, описывающий кабинет
    public class Classroom
    {
        public int Id { get; set; } // Уникальный идентификатор кабинета
        public string Name { get; set; } // Название кабинета
        public string Address { get; set; } // Адрес кабинета
        public string Status { get; set; } // Статус кабинета (например, "Активен" или "Неактивен")
    }
}

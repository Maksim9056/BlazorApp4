namespace BlazorApp4.Components.ClassType
{
    // Класс, представляющий преподавателя
    public class Teacher
    {
        public int  Id { get; set; } // Уникальный идентификатор преподавателя
        public string FirstName { get; set; } // Имя преподавателя
        public string LastName { get; set; } // Фамилия преподавателя
        public string Email { get; set; } // Адрес электронной почты преподавателя
        public string ContactNumber { get; set; } // Контактный номер преподавателя
        public string Status { get; set; } // Статус преподавателя (например, "Активен" или "Неактивен")
    }
}

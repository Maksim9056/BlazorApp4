namespace BlazorApp4.Components.ClassType
{
    // Класс, представляющий студента
    public class Student
    {
        public int Id { get; set; } // Уникальный идентификатор студента
        public string FirstName { get; set; } // Имя студента
        public string LastName { get; set; } // Фамилия студента
        public string Email { get; set; } // Адрес электронной почты студента
        public string ContactNumber { get; set; } // Контактный номер студента
        public string GroupName { get; set; } // Название группы студента
        public string Status { get; set; } // Статус студента (например, "Активен" или "Неактивен")
    }
}

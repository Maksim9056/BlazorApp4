namespace BlazorApp4.Components.ClassType
{

    /// <summary>
    /// Класс, описывающий расписание занятий
    /// </summary>
    public class LessonSchedule
    {
        public int Id { get; set; } // Уникальный идентификатор расписание занятий

        /// <summary>
        /// Уникальный идентификатор занятия
        /// </summary>
        public int LessonID { get; set; }

        /// <summary>
        /// Уникальный идентификатор преподавателя
        /// </summary>
        public int TeacherID { get; set; }
        /// <summary>
        /// Уникальный идентификатор студента
        /// </summary>
        public int StudentID { get; set; }


        /// <summary>
        /// Уникальный идентификатор Группы
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// Уникальный идентификатор предмета
        /// </summary>
        public int SubjectID { get; set; }
        /// <summary>
        /// Уникальный идентификатор типа занятия
        /// </summary>
        public int LessonTypeID { get; set; }
        /// <summary>
        /// Уникальный идентификатор кабинета
        /// </summary>
        public int ClassroomID { get; set; }
        /// <summary>
        /// Дата занятия
        /// </summary>
        /// 
        public string Weekday { get; set; } // Уникальный идентификатор  день недели


        /// <summary>
        /// Время занятия
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Статус занятия (например, "Активно" или "Отменено")
        /// </summary>
        public string Status { get; set; } 

    }

}

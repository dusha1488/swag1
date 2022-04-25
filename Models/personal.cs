using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore.Models
{
    public class personal
    {
        public int id_Персонал { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public int Возраст { get; set; }
        public DateTime Дата_рождения { get; set; }
        public string Пол { get; set; }
        public string Адрес { get; set; }
        public int Серия_номер_паспорта { get; set; }
        public int Зарплата { get; set; }
    }
}

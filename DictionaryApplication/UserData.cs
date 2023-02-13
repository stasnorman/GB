using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApplication
{
    /// <summary>
    /// Обработка данных в заглавные буквы
    /// </summary>
    public class UserData
    {
        /// <summary>
        /// Имя данных
        /// </summary>
        private string Data { get; set; }

        /// <summary>
        /// Принимает значения ручного ввода и преобразует его
        /// </summary>
        /// <param name="name">Введите слово или строку</param>
        public UserData(string name) { 
            Data = name;
        }

        /// <summary>
        /// Вывод информации
        /// </summary>
        /// <returns>Возвращает слово в виде заглавных букв</returns>
        public void MethodUpper() => Console.WriteLine(Data.ToUpper());

        /// <summary>
        /// Деструкторизация класса
        /// </summary>
        ~UserData()
        {
            Console.WriteLine("Память очищена!");
        }
    }
}

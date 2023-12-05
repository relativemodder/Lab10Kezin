using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Kezin
{
    public class Document
    {
        public string LastName { get; set; }

        public virtual bool Equals(Document other)
        {
            return LastName == other.LastName;
        }
    }

    public class Passport : Document
    {
        // something else, but it's not imporant in this task
    }

    public class StudentCard : Document
    {
        // something else, but it's not imporant in this task
    }

    internal class Task2
    {
        public static void Run()
        {
            Document[] documents = new Document[]
            {
                new Passport { LastName = "Иванов" },
                new StudentCard { LastName = "Петров" },
                new Passport { LastName = "Иванов" }
            };

            Console.Write("Введите фамилию (вводите правильно и точно): ");
            string lastName = Console.ReadLine();

            int documentCount = documents.Where(x => x.LastName == lastName).Count();

            Console.WriteLine($"Количество документов на фамилию {lastName}: {documentCount}");

            /* Example output 1:
             * Введите фамилию (вводите правильно и точно): Иванов
             * Количество документов на фамилию Иванов: 2
             */

            /* Example output 2:
             * Введите фамилию (вводите правильно и точно): Петров
             * Количество документов на фамилию Иванов: 1
             */

            /* Example output 3:
             * Введите фамилию (вводите правильно и точно): Кезин
             * Количество документов на фамилию Иванов: 0
             */
        }
    }
}

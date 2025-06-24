using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сlasswork_24._06_delegate
{/*     Задание 1
Создайте приложение, отображающее текстовое
сообщение. Используйте механизм делегатов. Делегат
должен возвращать void и принимать один параметр
типа string (текст сообщения). Для тестирования приложения создайте различные методы для вызова через
делегата.*/
    internal static class StringShow
    {
        public static void Print (string message)
        {
            Console.WriteLine(message);
        }
        public static void PrintUpper(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
        public static void PrintLower(string message)
        {
            Console.WriteLine(message.ToLower());
        }

        public static void PrintCat(string message)
        {
            message += " Cat";
            Console.WriteLine(message);
        }



    }
}

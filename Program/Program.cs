using System;

namespace Project
{
    class Program
    {
        // Главный метод программы 
        static void Main(string[] args)
        {
            // Запрос на ввод
            Console.WriteLine("Введите символы: ");

            // Считывание строки со значением цветов объектов
            string objectsColor = Console.ReadLine(); // ССЗСКЗЗЗККСЗССКЗ

            // Создание объекта класса, производящего сортировку
            SortStrColor sortStrColor = new SortStrColor(objectsColor);

            // Получение массива симолов
            char[] Obj1Color = sortStrColor.GetObj1Color();

            // Печать результатов сортировки
            PrintArrayObj1Color(Obj1Color);

            // Чтобы окно быстро не закрылось 
            Console.ReadKey();
        }

        // Метод, печатающий сортированный массив символов
        public static void PrintArrayObj1Color(char[] obj1Color)
        {
            // Комментарий к выводимой информации
            Console.WriteLine("Результат сортировки: ");

            // Объявление переменной, отображающей индекс отсортированного массива
            int n = 0;

            // Объявление переменной, подсчитывающей количество некорректно введенных символов
            int nDefective = 0;

            // Вывод элементов отсортированного массива символов
            foreach (int obj in obj1Color)
            {
                // Если символ равен 'З', 'С' или 'К'
                if (obj1Color[n] != 'Б')
                {
                    // Вывод на экран
                    Console.Write(obj1Color[n]);
                } else // Некорректный символ
                {
                    // Увеличение значения
                    nDefective++;                
                }

                // Увеличение индекса элемента
                n++;
            }

            // Перевод строки
            Console.Write("\n");

            // Отображение количества некорректных символов
            Console.WriteLine("Введено некорректных символов: \n" + nDefective); 
        }
    }
}

using System;

namespace Project
{
    // Класс, производящий сортировку 
    public class SortStrColor
    {
        // Массив символов (сортированный)
        private char[] obj1Color;

        // Пустой конструктор
        public SortStrColor()
        {

        }

        // Конструктор
        public SortStrColor(string objectsColor)
        {
            // Создание массива символов
            obj1Color = objectsColor.ToCharArray();

            // Перечисление для кодирования цвета
            char[] codeColor = { 'З', 'С', 'К', 'Б'};

            // Определение количества объектов
            int nObjMax = objectsColor.Length;

            // Создание массива для присвоения кодов элементов
            int[] obj1CodeColor = new int[nObjMax];


            // Замена недопустимых символов
            ChangeDefectiveSymbol(nObjMax, ref obj1Color, codeColor);

            // Заполнение массива кодов
            FillArrayObj1CodeColor(nObjMax, obj1Color, ref obj1CodeColor, codeColor);

            // Пузырьковая сортировка
            SortBubble(obj1CodeColor);

            // Заполнение декодированного массива
            FillArrayObj1Color(ref obj1Color, obj1CodeColor, codeColor);
        }

        public char[] GetObj1Color()
        {
            return obj1Color;
        }  

        // Метод, заменяющий дефектные символы на символ 'Б'
        public static void ChangeDefectiveSymbol(int nObjMax, ref char[] obj1Color, char[] codeColor)
        {
            // Перебор элементов в массиве символов
            for (int nObj = 0; nObj < nObjMax; nObj++)
            {
                // Замена любых символов, не соответствующих 'З', 'С', 'К' на 'Б' - безцветный (бракованный)
                if ((obj1Color[nObj] != codeColor[0]) && (obj1Color[nObj] != codeColor[1]) && (obj1Color[nObj] != codeColor[2]))
                {
                    // Замена символов в строке
                    obj1Color[nObj] = codeColor[3];
                }
            }
        }

        // Метод, заполняющий массив кодов
        public static void FillArrayObj1CodeColor(int nObjMax, char[] obj1Color, ref int[] obj1CodeColor, char[] codeColor)
        {
            // Перебор элементов в массиве символов
            for (int nObj = 0; nObj < nObjMax; nObj++)
            {         
                // Перебор значений кодов
                for (int nCode = 0; nCode <= 3; nCode++)
                {
                    // Заполнение закодированного массива
                    if (obj1Color[nObj] == codeColor[nCode])
                    {
                        obj1CodeColor[nObj] = nCode;
                    }
                }
            }
        }

        // Метод, сортирующий массив целых чисел (по возрастанию)
        public static void SortBubble(int[] obj1CodeColor)
        {
            // Основной цикл (количество повторений равно количеству элементов массива)
            for (int i = 0; i < obj1CodeColor.Length; i++)
            {
                // Вложенный цикл (количество повторений, равно количеству элементов массива минус 1 и минус количество выполненных повторений основного цикла)
                for (int j = 0; j < obj1CodeColor.Length - 1 - i; j++)
                {
                    // Если элемент массива с индексом j больше следующего за ним элемента
                    if (obj1CodeColor[j] > obj1CodeColor[j + 1])
                    {
                        // Меняем местами элемент массива с индексом j и следующий за ним
                        Swap(ref obj1CodeColor[j], ref obj1CodeColor[j + 1]);
                    }
                }
            }
        }

        // Вспомогательный метод, "меняет местами" два элемента
        public static void Swap(ref int aFirstArg, ref int aSecondArg)
        {
            // Временная (вспомогательная) переменная, хранит значение первого элемента
            int tmpParam = aFirstArg;

            // Первый аргумент получил значение второго
            aFirstArg = aSecondArg;

            // Второй аргумент, получил сохраненное ранее значение первого
            aSecondArg = tmpParam;
        }

        // Метод, заполняющий декодированный массив
        public static void FillArrayObj1Color(ref char[] obj1Color, int[] obj1CodeColor, char[] codeColor)
        {
            // Заполнение элементов декодированного массива
            int n = 0;
            foreach (int obj in obj1CodeColor)
            {
                // Заполнение декодированного массива
                obj1Color[n] = codeColor[obj];

                // Увеличение индекса элемента
                n++;
            }
        }         
    }
}

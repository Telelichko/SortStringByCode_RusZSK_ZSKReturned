using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Project;
//using namespace Project;

namespace Project
{
    [TestClass]
    public class SortStrColorTests
    {

        [TestMethod]
        public void GetObj1Color_RusZ_rusZReturned() // Не совсем правильный, так как проверяет все методы класса
        {
            // Arrange - присвоение переменных
            string inputValue = "З"; // Вводимая переменная

            char expectedValue = 'З'; // Ожидаемая переменная

            // Act - выполнение действий с классом
            SortStrColor obj = new SortStrColor(inputValue); // Получение объекта класса
            char[] outputValue = obj.GetObj1Color(); // Выводимый массив объектов

            char actualValue = outputValue[0]; // Получаемая переменная

            // Assert - проверка
            Assert.AreEqual(expectedValue, actualValue); // Сравнение ожидаемого и полученного результата
        }

        [TestMethod]
        public void GetObj1Color_RusS_rusSReturned() // Не совсем правильный, так как проверяет все методы класса
        {
            // Arrange - присвоение переменных
            string inputValue = "С"; // Вводимая переменная

            char expectedValue = 'С'; // Ожидаемая переменная

            // Act - выполнение действий с классом
            SortStrColor obj = new SortStrColor(inputValue); // Получение объекта класса
            char[] outputValue = obj.GetObj1Color(); // Выводимый массив объектов

            char actualValue = outputValue[0]; // Получаемая переменная

            // Assert - проверка
            Assert.AreEqual(expectedValue, actualValue); // Сравнение ожидаемого и полученного результата
        }

        [TestMethod]
        public void GetObj1Color_RusK_rusKReturned() // Не совсем правильный, так как проверяет все методы класса
        {
            // Arrange - присвоение переменных
            string inputValue = "К"; // Вводимая переменная

            char expectedValue = 'К'; // Ожидаемая переменная

            // Act - выполнение действий с классом
            SortStrColor obj = new SortStrColor(inputValue); // Получение объекта класса
            char[] outputValue = obj.GetObj1Color(); // Выводимый массив объектов

            char actualValue = outputValue[0]; // Получаемая переменная

            // Assert - проверка
            Assert.AreEqual(expectedValue, actualValue); // Сравнение ожидаемого и полученного результата
        }

        [TestMethod]
        public void GetObj1Color_1_rusBReturned() // Не совсем правильный, так как проверяет все методы класса
        {
            // Arrange - присвоение переменных
            string inputValue = "1"; // Вводимая переменная

            char expectedValue = 'Б'; // Ожидаемая переменная

            // Act - выполнение действий с классом
            SortStrColor obj = new SortStrColor(inputValue); // Получение объекта класса
            char[] outputValue = obj.GetObj1Color(); // Выводимый массив объектов

            char actualValue = outputValue[0]; // Получаемая переменная

            // Assert - проверка
            Assert.AreEqual(expectedValue, actualValue); // Сравнение ожидаемого и полученного результата
        }

        [TestMethod]
        public void GetObj1Color_V_rusBReturned() // Не совсем правильный, так как проверяет все методы класса
        {
            // Arrange - присвоение переменных
            string inputValue = "V"; // Вводимая переменная

            char expectedValue = 'Б'; // Ожидаемая переменная

            // Act - выполнение действий с классом
            SortStrColor obj = new SortStrColor(inputValue); // Получение объекта класса
            char[] outputValue = obj.GetObj1Color(); // Выводимый массив объектов

            char actualValue = outputValue[0]; // Получаемая переменная

            // Assert - проверка
            Assert.AreEqual(expectedValue, actualValue); // Сравнение ожидаемого и полученного результата
        }

        [TestMethod]
        public void GetObj1Color_InputLength1_Length1Returned() // Не совсем правильный, так как проверяет все методы класса
        {
            // Arrange - присвоение переменных
            string inputValue = "V"; // Вводимая переменная

            int expectedValue = 1; // Ожидаемая переменная

            // Act - выполнение действий с классом
            SortStrColor obj = new SortStrColor(inputValue); // Получение объекта класса
            char[] outputValue = obj.GetObj1Color(); // Выводимый массив объектов

            int actualValue = outputValue.Length; // Получаемая переменная

            // Assert - проверка
            Assert.AreEqual(expectedValue, actualValue); // Сравнение ожидаемого и полученного результата
        }

        [TestMethod]
        public void ChangeDefectiveSymbol_RusZ_ZReturned() 
        {
            // Arrange - присвоение переменных
            char[] inputValue = {'З'}; // Вводимая переменная
            int expectedValue = 'З'; // Ожидаемая переменная

            int nObjMax = 1; // Дополнительные данные, необходимые для выполнения метода
            char[] codeColor = { 'З', 'С', 'К', 'Б'};

            // Act - выполнение действий с классом
            SortStrColor.ChangeDefectiveSymbol(nObjMax, ref inputValue, codeColor); // Выполнение метода ChangeDefectiveSymbol класса
            char[] outputValue = inputValue; // Выводимый массив объектов

            char actualValue = outputValue[0]; // Получаемая переменная

            // Assert - проверка
            Assert.AreEqual(expectedValue, actualValue); // Сравнение ожидаемого и полученного результата
        }

        [TestMethod]
        public void ChangeDefectiveSymbol_R_RusBReturned() 
        {
            // Arrange - присвоение переменных
            char[] inputValue = { 'V' }; // Вводимая переменная
            int expectedValue = 'Б'; // Ожидаемая переменная

            int nObjMax = inputValue.Length; // Дополнительные данные, необходимые для выполнения метода
            char[] codeColor = { 'З', 'С', 'К', 'Б' };

            // Act - выполнение действий с классом
            SortStrColor.ChangeDefectiveSymbol(nObjMax, ref inputValue, codeColor); // Выполнение метода ChangeDefectiveSymbol класса
            char[] outputValue = inputValue; // Выводимый массив объектов

            char actualValue = outputValue[0]; // Получаемая переменная

            // Assert - проверка
            Assert.AreEqual(expectedValue, actualValue); // Сравнение ожидаемого и полученного результата
        }

        [TestMethod]
        public void FillArrayObj1CodeColor_RusZSKB_0123Returned() 
        {
            // Arrange - присвоение переменных
            char[] inputValue = { 'З', 'С', 'К', 'Б' }; // Вводимая переменная
            int[] expectedValue = { 0, 1, 2, 3 }; // Ожидаемый массив

            int nObjMax = inputValue.Length; // Дополнительные данные, необходимые для выполнения метода
            char[] codeColor = { 'З', 'С', 'К', 'Б' };
            int[] obj1CodeColor = { 0, 0, 0, 0 };

            // Act - выполнение действий с классом
            SortStrColor.FillArrayObj1CodeColor(nObjMax, inputValue, ref obj1CodeColor, codeColor);// Выполнение метода FillArrayObj1CodeColor класса
            int[] outputValue = obj1CodeColor; // Выводимый массив объектов

            int[] actualValue = obj1CodeColor; // Получаемый массив

            // Assert - проверка
            Assert.AreEqual(expectedValue[0], actualValue[0]); // Сравнение ожидаемого и полученного результата
            Assert.AreEqual(expectedValue[1], actualValue[1]);
            Assert.AreEqual(expectedValue[2], actualValue[2]);
            Assert.AreEqual(expectedValue[3], actualValue[3]);  
        }

        [TestMethod]
        public void SortBubble_2301_0123Returned()
        {
            // Arrange - присвоение переменных
            int[] inputValue = { 2, 3, 0, 1 }; // Вводимая переменная
            int[] expectedValue = { 0, 1, 2, 3 }; // Ожидаемый массив

            // Act - выполнение действий с классом
            SortStrColor.SortBubble(inputValue);// Выполнение метода SortBubble класса
            int[] outputValue = inputValue; // Выводимый массив объектов

            int[] actualValue = outputValue; // Получаемый массив

            // Assert - проверка
            Assert.AreEqual(expectedValue[0], actualValue[0]); // Сравнение ожидаемого и полученного результата
            Assert.AreEqual(expectedValue[1], actualValue[1]);
            Assert.AreEqual(expectedValue[2], actualValue[2]);
            Assert.AreEqual(expectedValue[3], actualValue[3]);
        }

        [TestMethod]
        public void Swap_2and1_1And2Returned()
        {
            // Arrange - присвоение переменных
            int inputValue1 = 1; // Вводимая переменная1
            int inputValue2 = 2; // Вводимая переменная2

            int expectedValue1 = 2; // Ожидаемая переменная1
            int expectedValue2 = 1; // Ожидаемая переменная2        

            // Act - выполнение действий с классом
            SortStrColor.Swap(ref inputValue1, ref inputValue2); // Выполнение метода Swap по перемещению переменных
            int actualValue1 = inputValue1; // Получаемая переменная1
            int actualValue2 = inputValue2; // Получаемая переменная2


            // Assert - проверка
            Assert.AreEqual(expectedValue1, actualValue1); // Сравнение ожидаемого и полученного результата по первым переменным
            Assert.AreEqual(expectedValue2, actualValue2); // Сравнение ожидаемого и полученного результата по первым переменным
        }

        [TestMethod]
        public void FillArrayObj1Color_Rus2301_KBZSReturned()
        {
            // Arrange - присвоение переменных
            int[] inputValue = { 2, 3, 0, 1 };  // Вводимая переменная
            char[] expectedValue = { 'К', 'Б', 'З', 'С' }; // Ожидаемый массив

            char[] codeColor = { 'З', 'С', 'К', 'Б' }; // Дополнительные данные, необходимые для выполнения метода        
            char[] obj1Color = { ' ', ' ', ' ', ' ' };

            // Act - выполнение действий с классом
            SortStrColor.FillArrayObj1Color(ref obj1Color, inputValue, codeColor);// Выполнение метода FillArrayObj1Color класса
            char[] outputValue = obj1Color; // Выводимый массив объектов

            char[] actualValue = outputValue; // Получаемый массив

            // Assert - проверка
            Assert.AreEqual(expectedValue[0], actualValue[0]); // Сравнение ожидаемого и полученного результата
            Assert.AreEqual(expectedValue[1], actualValue[1]);
            Assert.AreEqual(expectedValue[2], actualValue[2]);
            Assert.AreEqual(expectedValue[3], actualValue[3]);
        }
        
         
    }
}

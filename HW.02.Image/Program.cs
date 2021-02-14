using System;
using System.IO;

namespace HW._02.Image
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            //1 считываем весь текст из заданного адреса
            //2 считываем все символы до конца потока и сохраняем результаты в переменной типа string
            //3 разбиваем строку на основе разделителя ' ', сохраняем в строчном массиве
            //4 выделяем в памяти место под байтовый массив, равный числу элементов строчного массива
            //5 запускаем цикл,где каждый элемент текстового массива интерпретируем в двоичном виде,и сохраняем в байтовый массив
            //6 создаем новый файл в формате .png,записываем указанный массив и закрываем
            //7 сборщик мусора
            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
            textReader.Dispose();
        }
    }
}


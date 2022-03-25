/* (*) Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail адрес.
Разделителем между ФИО и адресом электронной почты является символ &:
Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич &
Pasha@mail.ru Сформировать новый файл, содержащий список адресов
электронной почты. Предусмотреть метод, выделяющий из строки адрес почты.
Методу в качестве параметра передается символьная строка s, e-mail
возвращается в той же строке s: public void SearchMail (ref string s). */

namespace Lesson3
{
    class WorkString
    {
        public string ReadPath { get; set; } = $@"C:\Лекция 3\пример.txt";
        public string PathSaveMail { get; set; } = $@"C:\Лекция 3\mail.txt";
        public string MassivMailString { get; set; } = string.Empty;



        public string[] FileString(string ReadPathUser)
        {

            //получаем из файла массив строк
            string[] fileLines = File.ReadAllLines(ReadPathUser);
            for (int i = 0; i < fileLines.Length; i++)
            {
                string? MassivMailString = fileLines[i];
                SearchMail(ref MassivMailString);
                fileLines[i] = MassivMailString;

            }
            return fileLines;
        }
        public void SearchMail(ref string MassivMailString)
        {
            var numberIndex = MassivMailString.IndexOf('&');
            var saveSubsting = MassivMailString.Substring(numberIndex + 2);
            MassivMailString = saveSubsting;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var pathFile = new WorkString();
            var save = pathFile.FileString(pathFile.ReadPath);
            Console.ReadLine();
        }

    }

}
namespace Задание_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Необходимо составить список из 20 фамилий."); //объявить лист. ввод в лист данных с клавиатуры
                
                List<string> surname = new List<string>();
                int valueSurname = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= valueSurname; i++)
                {
                    Console.Write($"Фамилия №{i}: ");
                    surname.Add(Console.ReadLine());
                    Console.WriteLine();
                }
                for (int i = 0; i < surname.Count; i++) 
                {
                    //for (int letter = 0; letter < surname[i].Length; letter++)
                    //{

                 if (surname[i][0] == 'А') || 'У' || 'Е' || 'Ы' || 'О' || 'Э' || "Я" || "И" || "Ю")  //массив символов, затем пробежать на повторение 
                {
                    surname.Remove(surname[i]);
                    string ch = surname.First(value => value == "э");

                }
                    //}
                    Console.WriteLine(surname);
            }
        }
    }
}
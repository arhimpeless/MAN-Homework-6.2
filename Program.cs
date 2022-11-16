namespace Задание_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Необходимо составить список из 20 фамилий."); //объявить лист. ввод в лист данных с клавиатуры
                string surnameString = string.Empty; //через функцию
                string s1;
                s1 = Console.ReadLine();
                string s2;
                s2 = Console.ReadLine();
                string s3;
                s3 = Console.ReadLine();
                string s4;
                s4 = Console.ReadLine();
                string s5;
                s5 = Console.ReadLine();
                string s6;
                s6 = Console.ReadLine();
                string s7;
                s7 = Console.ReadLine();
                string s8;
                s8 = Console.ReadLine();
                string s9;
                s9 = Console.ReadLine();
                string s10;
                s10 = Console.ReadLine();
                string s11;
                s11 = Console.ReadLine();
                string s12;
                s12 = Console.ReadLine();
                string s13;
                s13 = Console.ReadLine();
                string s14;
                s14 = Console.ReadLine();
                string s15;
                s15 = Console.ReadLine();
                string s16;
                s16 = Console.ReadLine();
                string s17;
                s17 = Console.ReadLine();
                string s18;
                s18 = Console.ReadLine();
                string s19;
                s19 = Console.ReadLine();
                string s20;
                s20 = Console.ReadLine();
                Console.WriteLine("Готово.");

                string[] values = new string[] { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 };

                List<string> surname = new List<string>();
                int valueSurname = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= valueSurname; i++)
                {
                    surname.Add(Console.ReadLine());
                }

                foreach (string s in surname)  //или идти через foreach, или через for
                                               //идти по листу, если совпадают символы, то удалять
                {

                }

                for (int i = 0; i < surname.Lenght; i++)  //лист не содержит длину?
                {
                    for (int letter = 0; letter < surname[i].Length; letter++)
                    {

                        if (surname[i][letter] == "А" || "У" || "Е" || "Ы" || "О" || "Э" || "Я" || "И" || "Ю")
                        {
                            surname.Remove(surname[i][letter]);
                        }
                    }

                    //surnameString = string.Join(" ", values);
                    //Console.WriteLine(surnameString);
                    Console.WriteLine(surname);
                }
        }
    }
}
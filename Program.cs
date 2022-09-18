using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {

        //---------block starts Side calculations--------------


        static void Print(Dictionary<string, List<int>> Diary)
        {
            foreach (string i in Diary.Keys)
            {
                foreach (int it in Diary[i])
                {
                    Console.WriteLine(it);
                }
                Console.WriteLine("--------------------------------------");
            }
        }



        //====== Copying a String list
        static List<string> CopyingListString(List<string> Original)
        {
            List<string> Duplicate = new List<string>();

            foreach (string item in Original)
            {
                Duplicate.Add(item);
            }

            return Duplicate;
        }



        static int ItemLength(List<string> Item) 
        {
            int S = Item[0].Length;


            foreach(string i in Item)
            {
                if (S < i.Length) S = i.Length;
            }

            return S;
        }



        //---------block ends Side calculations------------------



































        //---------block starts Dialog boxesn--------------


        //====== Dialog Menu
        static int DialogMenu(string JournalName)
        {
            Console.WriteLine($"////Добро пожаловать в журнал \"{JournalName}\"////");
            Console.WriteLine();

            int i;

            while (true)
            {
                Console.WriteLine("Выберите операцию: ");
                Console.WriteLine("Если хотите просмотреть список студентов, введите - 0");
                Console.WriteLine("Если хотите просмотреть информацию о студенте, введите - 1");
                Console.WriteLine("Если хотите просмотреть информацию о всех студентах, введите - 2");
                Console.WriteLine("Если хотите добавить студента, введите - 3");
                Console.WriteLine("Если хотите удалить студента, введите - 4");
                Console.WriteLine("Если хотите изменнить информацию студента, введите - 5");
                Console.WriteLine("Если хотите если хотите завершить работу, введите - 6");
                Console.Write("Номер операции: ");
                i = Convert.ToInt32(Console.ReadLine());

                if (i >= 0 && i <= 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Введите коректный номер!");
                    Console.WriteLine();
                    continue;
                }
            }
            return i;
        }






        //====== Choosing a student to output grades
        static int ChoosingStudent(List<Student> Journal, string string1)
        {

            int a;

            do
            {
                Console.WriteLine(string1);
                OutputStudentsNames(Journal);
                Console.Write("Выберите студента ");
                a = Convert.ToInt32(Console.ReadLine());

                if (a > Journal.Count || a <= 0) Console.WriteLine("Введите коретно номер студента!\n");

            } while (a > Journal.Count || a <= 0);

            Console.WriteLine();

            return a -= 1;
        }





        //====== Choosing which subject to fill in
        static int ChoosingSubjectFilling(string string1, string string2, List<string> item)
        {
            int it;

            do
            {
                Console.WriteLine(string1);

                for (int u = 0; u < item.Count; u++)
                {
                    if (u != item.Count - 1) Console.WriteLine($"{u}. {item[u]},");
                    else Console.WriteLine($"{u}. {item[u]}.");
                }

                Console.WriteLine($"{item.Count}. " + string2);

                Console.Write("Введите нужный вам номер ");
                it = Convert.ToInt32(Console.ReadLine());

                if (it > item.Count) Console.WriteLine("Такого номера нет!\nВвдите правильно!\n");


            } while (it > item.Count);

            Console.WriteLine();

            return it;
        }

        static int ChoosingSubjectFilling1(string string1, List<string> item)
        {
            int it;

            do
            {
                Console.WriteLine(string1);

                for (int u = 0; u < item.Count; u++)
                {
                    if (u != item.Count - 1) Console.WriteLine($"{u}. {item[u]},");
                    else Console.WriteLine($"{u}. {item[u]}.");
                }

                Console.Write("Введите нужный вам номер ");
                it = Convert.ToInt32(Console.ReadLine());

                if (it >= item.Count) Console.WriteLine("Такого номера нет!\nВвдите правильно!\n");


            } while (it >= item.Count);

            Console.WriteLine();

            return it;
        }



        //====== Dialog Completion of the operation
        static void Success()
        {
            Console.WriteLine();
            Console.WriteLine("Операция выполнена успешно, возврашаемся в главное меню!");
            Console.WriteLine("\n\n\n");


        }

        //---------block ends Dialog boxes--------------














































        //---------block starts Entering initial information--------------


        //====== Name Input, Journal name or Student name
        static string NameInput(int i)
        {
            if (i == 0)
            {
                Console.Write("Введите название журнала ");
            }
            else
            {
                Console.Write("Введите имя студента ");
            }
            return Console.ReadLine();
        }


        //====== Number of study days
        static long NumberOfStudydays()
        {
            Console.Write("Введите количество учебных дней: ");
            return Convert.ToInt32(Console.ReadLine());
        }



        //====== Input the subjects you lead
        static List<string> Items()
        {
            List<string> items = new List<string>();
            string i = "";

            Console.WriteLine("Введите предмты которые вы будете вести: ");
            Console.WriteLine();

            do
            {
                i = Console.ReadLine();
                if (i != "") items.Add(i);
            } while (i != "");

            if (items.Count == 0)
            {
                Console.WriteLine("Вы не ввели ни олного предмета!\nЧто вы за преподаватель такой!!!");
                return Items();
            }
            else return items;
        }


        static List<int> In_specialProcess(long size)
        {
            Console.WriteLine("Введите набор чисел в строку, разделяя их поробелами");
            string x = Console.ReadLine();
            string x1 = "";
            List<int> m = new List<int>();

            for (int i = 0; i < x.Length && m.Count <= size; i++)
            {
                if (x[i] == 'n' || x[i] == 'v' || x[i] == '2' || x[i] == '3' || x[i] == '4' || x[i] == '5')
                {
                    x1 += x[i];
                }
                if (x1.Length != 1)
                {
                    x1 = "";
                }
                if (i == x.Length - 1)
                {
                    if (x1 != "") 
                    {
                        if (x1 == "n") x1 = "0";
                        if (x1 == "v") x1 = "1";

                        m.Add(Convert.ToInt32(x1));
                        x1 = null;
                    }
                }
                else
                {
                    if (x[i] == ' ' && x[i + 1] != ' ' && x1 != "")
                    {
                        if (x1 == "n") x1 = "0";
                        if (x1 == "v") x1 = "1";

                        m.Add(Convert.ToInt32(x1));
                        x1 = "";
                    }
                }
            }

            for (int i = m.Count; i < size + 1; i++)
            {
                m.Add(0);
            }

            return m;
        }


        //====== Student Diary
        static Dictionary<string, List<int>> In_special(long size, List<string> Items)
        {

            List<string> ItemsInstance = CopyingListString(Items);

            string string1 = "Выберите по какому предмету будут заполнятся оценки: ";
            string string2 = "Закончить ввод оценок по предмеу.";

            int i = 0;
            Dictionary<string, List<int>> Diary = new Dictionary<string, List<int>>();

            while(i != ItemsInstance.Count + 1 && ItemsInstance.Count != 0)
            {
                i = ChoosingSubjectFilling(string1, string2, ItemsInstance);

                if (i == ItemsInstance.Count) i++;

                Console.WriteLine();

                if (i != ItemsInstance.Count + 1)
                {
                    if (Diary.ContainsKey(ItemsInstance[i])) Diary[ItemsInstance[i]] = In_specialProcess(size);
                    else Diary.Add(ItemsInstance[i], In_specialProcess(size));
                    ItemsInstance.RemoveAt(i);

                    Console.WriteLine();

                }
            }

            return Diary;

        }


        //---------block ends Entering initial information--------------

















































        //---------block starts Working with class instances-------------


        //====== Adding a new student to the journal
        static void AddingStudentJournal(ref List<Student> Journal, long Days, List<string> Items)
        {
            string Name = NameInput(1);
            Console.WriteLine();
            Dictionary<string, List<int>> Diary = In_special(Days - 1, Items);
            Student student = new Student(Name, Days, Diary);

            //Print(student.Diary);

            Journal.Add(student);
        }


        //====== Deletion student to the journal
        static void DeletionStudentJournal(ref List<Student> Journal)
        {
            if (Journal.Count == 0) Console.WriteLine("В журнале нет студентов.");
            else
            {
                string string1 = "Выберите студента на удаление\n";
                int a = ChoosingStudent(Journal, string1);

                Journal.RemoveAt(a);
            }
        }
        

        //====== Changing ratings
        static void ChangingRatings(ref List<Student> Journal)
        {
            if (Journal.Count == 0) Console.WriteLine("В журнале нет студентов.\n");
            else
            {
                string string3 = "Оценки кокого студента нужно изменить: \n";
                int a = ChoosingStudent(Journal, string3);

                string string1 = "Выбирите предмет, по которому надо изменить оценки:";

                List<string> NameSubject = new List<string>();

                foreach (string item in Journal[a].Diary.Keys)
                {
                    NameSubject.Add(item);
                }

                int i = ChoosingSubjectFilling1(string1, NameSubject);

                Journal[a].Diary[NameSubject[i]] = In_specialProcess(Journal[a].Days - 1);

                Journal[a].Diar = Journal[a].Diary;
            }
        }


        //---------block ends Working with class instances-------------



















































        //---------block starts Information output-------------


        //====== Names of all students
        static void OutputStudentsNames(List<Student> Journal)
        {
            if (Journal.Count == 0) Console.WriteLine("В журнале нет студентов.");
            else
            {
                for (int i = 1, u = 0; u < Journal.Count; u++, i++)
                {
                    if (u != Journal.Count - 1) Console.WriteLine($"{i}. {Journal[u].Name},");
                    else Console.WriteLine($"{i}. {Journal[u].Name}.");
                }
            }
        }


        static void OutputInformation(Student Journal, string keySubject)
        {
            string NameStudent = Journal.Name;
            List<int> Diary = Journal.Diary[keySubject];
            double Average = Journal.Average[keySubject];
            int evalFunc = Journal.evalFunc[keySubject];

            string PercentString = $"Проценент посещаемости равен {Journal.Percent[keySubject]}%.";


            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth / 2) - (keySubject.Length / 2), Console.CursorTop);
            Console.WriteLine(keySubject);
            Console.WriteLine();


            Console.SetCursorPosition((((int)Journal.Days/ 2) - (8 / 2)) + 8, Console.CursorTop);
            Console.WriteLine("Оценки: ");

            Console.SetCursorPosition(8, Console.CursorTop);
            for (int i = 1; i <= Journal.Days; i++) Console.Write($"{i} ");
            Console.WriteLine("  Средний балл:");

            
            Console.SetCursorPosition(8, Console.CursorTop);
            for (int i = 0; i < Diary.Count; i++)
            {
                if (i >= 10) 
                {
                    Console.Write(" ");
                }

                if (Diary[i] != 0 && Diary[i] != 1) Console.Write($"{Diary[i]} ");
                else if (Diary[i] == 0) Console.Write("n ");
                else Console.Write("v ");

            }
            Console.WriteLine("   {0:#.##}\n", Average);
            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth / 2) - (PercentString.Length / 2), Console.CursorTop);
            Console.WriteLine(PercentString);
            

            Console.SetCursorPosition((Console.WindowWidth / 2) - (PercentString.Length / 2), Console.CursorTop);
            if (evalFunc != 0) Console.WriteLine($"Ваша оценка на данный момент = \"{evalFunc}\"");
            else Console.WriteLine($"Для выстовления оценки вы нуждаетесь в дополнительных вопросах\n\n\n");
            Console.WriteLine();

        }


        static void OutputInformation(Student Journal, List<string> Item)
        {

            int ItemLen = ItemLength(Item);

            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth / 2) - (Journal.Name.Length / 2), 0);
            Console.WriteLine(Journal.Name);

            Console.SetCursorPosition((((int)Journal.Days / 2) - (Journal.Name.Length / 2)) + ItemLen + 1, Console.CursorTop);
            Console.WriteLine("Оценки: ");

            Console.SetCursorPosition(ItemLen + 1 , Console.CursorTop);
            for (int i = 1; i <= Journal.Days; i++) Console.Write($"{i} ");
            Console.Write("  Средний балл:\t");
            Console.WriteLine("  Процент посешаемости:");


            for(int i = 0; i < Item.Count; i++)
            {
                Console.Write(Item[i]);

                for (int u = 0; u <= ItemLen - Item[i].Length; u++) Console.Write(" ");


                for(int o = 0; o < Journal.Diary[Item[i]].Count; o++)
                {
                    if (o >= 10)
                    {
                        Console.Write(" ");
                    }

                    if (Journal.Diary[Item[i]][o] != 0 && Journal.Diary[Item[i]][o] != 1) Console.Write($"{Journal.Diary[Item[i]][o]} ");
                    else if (Journal.Diary[Item[i]][o] == 0) Console.Write("n ");
                    else Console.Write("v ");
                }

                Console.Write("\t{0:##}\t\t\t", Journal.Average[Item[i]]);
                Console.Write("{0:##}%", Journal.Percent[Item[i]]);

                Console.WriteLine();
            }

            Console.WriteLine();

        }

        static void OutputInformation(List<Student> Journal, string keySubject)
        {

            List<string> NameOnSubject = new List<string>();

            for(int i = 0; i < Journal.Count; i++)
            {
                foreach(string item in Journal[i].Diary.Keys)
                {
                    if (keySubject == item) NameOnSubject.Add(Journal[i].Name);
                }
            }

            if(NameOnSubject.Count == 0)
            {
                Console.WriteLine("Нет ни одного стдента с оценами по этому предмету");
                Console.WriteLine();
            }
            else
            {
                int ItemLen = ItemLength(NameOnSubject);

                Console.Clear();
                Console.SetCursorPosition((Console.WindowWidth / 2) - (keySubject.Length / 2), 0);
                Console.WriteLine(keySubject);

                Console.SetCursorPosition(((int)Journal[0].Days / 2) - (8 / 2) + ItemLen + 1, Console.CursorTop);
                Console.WriteLine("Оценки: ");

                Console.SetCursorPosition(ItemLen + 1, Console.CursorTop);
                for (int i = 1; i <= Journal[0].Days; i++) Console.Write($"{i} ");
                Console.Write("  Средний балл:\t");
                Console.WriteLine("  Процент посешаемости:");

                int u = 0;

                while (u < NameOnSubject.Count)
                {
                    for (int i = 0; i < Journal.Count; i++)
                    {
                        if (NameOnSubject.Contains(Journal[i].Name))
                        {
                            Console.Write(NameOnSubject[u]);


                            for (int o = 0; o <= ItemLen - NameOnSubject[u].Length; o++) Console.Write(" ");

                            for (int p = 0; p < Journal[i].Diary[keySubject].Count; p++)
                            {
                                if (p >= 10)
                                {
                                    Console.Write(" ");
                                }

                                if (Journal[i].Diary[keySubject][p] != 0 && Journal[i].Diary[keySubject][p] != 1) Console.Write($"{Journal[i].Diary[keySubject][p]} ");
                                else if (Journal[i].Diary[keySubject][p] == 0) Console.Write("n ");
                                else Console.Write("v ");
                            }

                            Console.Write("\t{0:##}\t\t\t", Journal[i].Average[keySubject]);
                            Console.Write("{0:##}%", Journal[i].Percent[keySubject]);

                            Console.WriteLine();

                            u++;
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
        
        static void OutputInformationNoCleaning(List<Student> Journal, string keySubject) //no cleaning
        {

            List<string> NameOnSubject = new List<string>();

            for (int i = 0; i < Journal.Count; i++)
            {
                foreach (string item in Journal[i].Diary.Keys)
                {
                    if (keySubject == item) NameOnSubject.Add(Journal[i].Name);
                }
            }

            if (NameOnSubject.Count == 0)
            {
                Console.WriteLine("Нет ни одного стдента с оценами по этому предмету");
                Console.WriteLine();
            }
            else
            {
                int ItemLen = ItemLength(NameOnSubject);

                
                Console.SetCursorPosition((Console.WindowWidth / 2) - (keySubject.Length / 2), Console.CursorTop);
                Console.WriteLine(keySubject);

                Console.SetCursorPosition(((int)Journal[0].Days / 2) - (8 / 2) + ItemLen + 1, Console.CursorTop);
                Console.WriteLine("Оценки: ");

                Console.SetCursorPosition(ItemLen + 1, Console.CursorTop);
                for (int i = 1; i <= Journal[0].Days; i++) Console.Write($"{i} ");
                Console.Write("  Средний балл:\t");
                Console.WriteLine("  Процент посешаемости:");

                int u = 0;

                while (u < NameOnSubject.Count)
                {
                    for (int i = 0; i < Journal.Count; i++)
                    {
                        if (NameOnSubject.Contains(Journal[i].Name))
                        {
                            Console.Write(NameOnSubject[u]);


                            for (int o = 0; o <= ItemLen - NameOnSubject[u].Length; o++) Console.Write(" ");

                            for (int p = 0; p < Journal[i].Diary[keySubject].Count; p++)
                            {
                                if (p >= 10)
                                {
                                    Console.Write(" ");
                                }

                                if (Journal[i].Diary[keySubject][p] != 0 && Journal[i].Diary[keySubject][p] != 1) Console.Write($"{Journal[i].Diary[keySubject][p]} ");
                                else if (Journal[i].Diary[keySubject][p] == 0) Console.Write("n ");
                                else Console.Write("v ");
                            }

                            Console.Write("\t\t{0:##}\t\t\t", Journal[i].Average[keySubject]);
                            Console.Write("{0:##}%", Journal[i].Percent[keySubject]);

                            Console.WriteLine();

                            u++;
                        }
                    }

                    Console.WriteLine();
                }
            }
        }

        //====== Output of student's grades
        static void OutputInformationAboutStudent(List<Student> Journal, List<string> Item)
        {

            if (Journal.Count == 0) Console.WriteLine("В журнале нет студентов.\n");
            else
            {
                string string3 = "Оценки, какого стдента вывести: \n";
                int a = ChoosingStudent(Journal, string3);

                string string1 = "Выбирите предмет, по которому выведутся оценки ";
                string string2 = "Вывести оценки по всем предметам.";

                List<string> NameSubject = new List<string>();

                foreach (string item in Journal[a].Diary.Keys)
                {
                    NameSubject.Add(item);
                }


                int i = ChoosingSubjectFilling(string1, string2, NameSubject);
                
                if(i != NameSubject.Count) OutputInformation(Journal[a], NameSubject[i]);
                else OutputInformation(Journal[a], NameSubject);


            }
        }



        //====== Output of all grades on the subject
        static void OutputInformationAboutStudents(List<Student> Journal, List<string> Item)
        {

            if (Journal.Count == 0) Console.WriteLine("В журнале нет студентов.\n");
            else
            {

                string string1 = "Выбирите предмет, по которому выведутся оценки ";
                string string2 = "Вывести оценки по всем предметам.";

                List<string> NameSubject = CopyingListString(Item);


                int i = ChoosingSubjectFilling(string1, string2, NameSubject);

                if (i != NameSubject.Count) OutputInformation(Journal, NameSubject[i]);
                else
                {
                    
                    for (int u = 0; u < Item.Count; u++)
                    {
                        
                        OutputInformationNoCleaning(Journal, NameSubject[u]);
                        Console.WriteLine("-----------------------------------------------------------------------");
                    }
                    
                }
               


            }
        }



        //---------block ends Information output-------------






















































        static void Main(string[] args)
        {

            List<Student> Journal = new List<Student>();

            string JournalName = NameInput(0);
            List<string> Item = Items();
            long Days = NumberOfStudydays();

            Console.WriteLine();

            int a;

            do
            {
                a = DialogMenu(JournalName);
                Console.WriteLine();

                if (a == 0)
                {
                    OutputStudentsNames(Journal);
                    Success();
                }
                else if (a == 1)
                {
                    OutputInformationAboutStudent(Journal, Item);
                    Success();
                }
                else if (a == 2)
                {
                    OutputInformationAboutStudents(Journal, Item);

                }
                else if (a == 3)
                {
                    AddingStudentJournal(ref Journal, Days, Item);
                    Success();
                }
                else if (a == 4)
                {
                    DeletionStudentJournal(ref Journal);
                    Success();
                }
                else
                {
                    ChangingRatings(ref Journal);
                    Success();

                }

            } while (a != 6);








            foreach (Student i in Journal)
            {
                Console.WriteLine(i.Name);
                Console.WriteLine(i.Days);
                Console.WriteLine(i.Average);
                Console.WriteLine(i.VisitedDays);
                Console.WriteLine(i.Percent);
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine();
            }




            //string Name = NameInput(1);
            //List<int> Diary = In_special(Days-1);
            //Student student = new Student(Name, Days, Diary);

            //Print(student.Diary);



            ////========= percent of visited days
            //double percent = (100 * student.VisitedDays) / student.Days;
            //double average = evalAverage(arr);



            ////===========
            //int evalFunc = Evaluation(percent, average);

            //if (student.evalFunc != 0) Console.WriteLine($"Your evaluation = \"{student.evalFunc}\"");
            //else Console.WriteLine($"You need several questions..\nYour percent = {student.evalFunc}\nYour average = {student.evalFunc}");

            //Console.WriteLine(student.Name);
            //Console.WriteLine(student.Days);
            //Console.WriteLine(student.Evals);
            //Console.WriteLine(student.VisitedDays);

        }
    }
}

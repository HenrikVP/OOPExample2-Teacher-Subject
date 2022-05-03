namespace OOPExample2
{
    internal class Menu
    {
        Data data = new();
        public Menu()
        {
            Teacher t = new() {
                Id = 1,
                Name = "Flemming",
                DoB = new DateTime(1967, 8, 25),
                Subject = data.subjectList[2]
            };

            AddTeacher(t);

            Start();
        }

        private void Start()
        {
            while (true)
            {
                Console.WriteLine("*** Lærerstyring ***");
                Console.WriteLine("1. Tilføj en lærer");
                Console.WriteLine("2. Se liste");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        AddTeacher();
                        break;
                    case ConsoleKey.D2:
                        ShowTeacherList();
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;

                    default:
                        Console.WriteLine("Prøv igen.");
                        break;
                }
            }
        } 

        private void AddTeacher(Teacher teacher)
        {
            data.teacherList.Add(teacher);
        }

        private void AddTeacher()
        {
            Console.Write("Id : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name : ");
            string? name = Console.ReadLine();
            Console.Write("Fødselsdag (yyyy-mm-dd) : ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            //Teacher teacher = new();
            //teacher.Name = name;
            //teacher.Id = id;
            //teacher.DoB = dateTime;

            Teacher teacher = new()
            {
                Name = name,
                Id = id,
                DoB = dateTime
            };
            
            ShowSubjectList();
            Console.Write("Vælg fag fra liste : ");
            int subjectNumber = int.Parse(Console.ReadLine());

            teacher.Subject = data.subjectList[subjectNumber];
            data.teacherList.Add(teacher);
        }
        private void ShowTeacherList()
        {
            Console.WriteLine("*** Teacher List ***");
            foreach (Teacher teacher in data.teacherList)
            {
                Console.WriteLine(
                    $"Id: {teacher.Id} " +
                    $"Navn: {teacher.Name} " +
                    $"Fødselsdag: {teacher.DoB.ToString("dd/MM-yyyy")} " +
                    $"Fag: {teacher.Subject.Name}");
            }
        }
        private void ShowSubjectList()
        {
            Console.WriteLine("*** Fagliste ***");
            for (int i = 0; i < data.subjectList.Count; i++)
            {
                Console.WriteLine($"{i} {data.subjectList[i].Name}");
            }
        }
    }
}

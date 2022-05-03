using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample2
{
    internal class Data
    {
        public List<Teacher> teacherList = new();
        public List<Subject> subjectList = new();

        public Data()
        {
            AddToSubjectList();
        }
        void AddToSubjectList()
        {
            Subject BasicProgramming = new()
            {
                Id = 1,
                Name = "Grundlæggende Programmering",
                Niveau = Level.Rutineret
            };
            Subject OOP = new()
            {
                Id = 2,
                Name = "Objekt-Orienteret Programmering",
                Niveau = Level.Rutineret
            };
            Subject DatabaseProgramming = new()
            {
                Id = 3,
                Name = "Database Programmering",
                Niveau = Level.Avanceret
            };

            subjectList.Add(BasicProgramming);
            subjectList.Add(OOP);
            subjectList.Add(DatabaseProgramming);
        }
    }
}

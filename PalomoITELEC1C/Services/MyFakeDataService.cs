using System;
using PalomoITELEC1C.Services;
using PalomoITELEC1C.Models;

namespace PalomoITELEC1C.Services

{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }

        //constructor
        public MyFakeDataService() {

            StudentList = new List<Student>() {
            new Student()
                {
                    Id= 1,FirstName="Jakob",
                    LastName="Palomo",
                    Birthday=DateTime.Parse("12/08/2002"),
                    Major=Major.BSIT,
                    Email="jakob@gmail.com"
            },
            new Student()
                {
                    Id= 2,FirstName="Edmond",
                LastName="Garraton",
                Birthday=DateTime.Parse("12/12/2002"),
                Major=Major.BSIT,
                Email="fhourze@gmail.com"
            }
            };

            InstructorList = new List<Instructor>() {
            new Instructor()
                {
                Id= 1,
                FirstName="Jakob",
                LastName="Palomo",
                IsTenured=true,
                Rank=Rank.Professor,
                HiringDate=DateTime.Parse("05/05/2023")
            },
            new Instructor()
                {
                    Id= 2,
                FirstName="Zeke",
                LastName="Gonzalez",
                IsTenured=true,
                Rank=Rank.AssistantProfessor,
                HiringDate=DateTime.Parse("05/05/2023")
            }

            };

        }

    }
}

using System;
namespace Console_Lab_3
{
	public class Identification
	{
		private string FirstName;
        private string LastName;
        private int Age;
        private string Group;
        private int Course;
        private string Email;

		public Identification(string FirstName, string LastName, int Age, string Group, int Course, string Email)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Age = Age;
			this.Group = Group;
			this.Course = Course;
			this.Email = Email;
		}

        public string MyName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        public string MySurname
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        public int MyAge
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            }
        }
        public string MyGroup
        {
            get
            {
                return Group;
            }
            set
            {
                Group = value;
            }
        }
        public int MyCourse
        {
            get
            {
                return Course;
            }
            set
            {
                Course = value;
            }
        }
        public string MyEmail
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        public void outputIdentification(Identification myInfo)
        {
            Console.WriteLine($"First name: {myInfo.FirstName}");
            Console.WriteLine($"Last name: {myInfo.LastName}");
            Console.WriteLine($"Age: {myInfo.Age}");
            Console.WriteLine($"Group: {myInfo.Group}");
            Console.WriteLine($"Course: {myInfo.Course}");
            Console.WriteLine($"Email: {myInfo.Email}");
        }
    }
}


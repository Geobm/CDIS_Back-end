using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{

     class Student
    {
        private static Random random = new Random();
        public int Id;
        public string Name;
        public int Age;
        public string password;
        public double tuition_fee;
        public string aux;
        public string aux2;
        public string aux3;
        public double scolarship;
       
        public Student() {

            Id = 1740584;
            Name = "Geovani Benita";
            Age = 20;
            password = "Zj65lM9b";
            tuition_fee = 0;
        }

        public Student(int Id, string Name, int Age,int tuition_fee) {

            this.Id = Id;
            this.Name = Name;
            SetAge(Age);
            SetPassword(8,true);
            this.tuition_fee = tuition_fee;
            
        }

        public virtual string ShowMenu()
        {
            string message = "\n\tAdmitted Students\n\nId: " + this.Id + "\nName: " + this.Name +
                "\nAge: " + this.Age + "\nPassword: " + this.password;

            return message;

        }

        public virtual double Scolarship(double scolarship){
            if(this.scolarship != 0)
            {
           
                return this.tuition_fee;

            }
            else
            {
                return 0;
            }
           
        }

        //Random password assign method
        public string SetPassword(int size, bool lowerCase){
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(2, true));
            builder.Append(RandomNumber(10, 99));
            builder.Append(RandomString(2, true));
            builder.Append(RandomNumber(10, 99));
            return builder.ToString();

            }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {   
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        public int RandomNumber(int min, int max){
            Random random = new Random();
            return random.Next(min, max);
        }


        public int SetAge(int Age){

            Age = int.Parse(Console.ReadLine());
            if (Age < 15){
                Age = 15;
            }
            else if (Age >= 90){
                Age = 90;
            }
            else {
                this.Age = Age;
            }
            return Age;
        }

    }

}

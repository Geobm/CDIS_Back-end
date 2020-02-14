using System;

namespace Student
{
    class Program 
    {
        static void Main(string[] args)
        {
            //input validation flag
            bool flag = true;
            
            int size;
            
            Console.WriteLine("How many students do you want to add?");
            size = int.Parse(Console.ReadLine());
            
            //objects
            Student[] Students = new Student[size];
            Undergraduate[] U_student = new Undergraduate[size];
            Graduate[] G_student = new Graduate[size];

            for (int i = 0; i < Students.Length; i++)
            {
                //objects initialization
                Students[i] = new Student();
               U_student[i] = new Undergraduate();
               G_student[i] = new Graduate();

                while (flag) {
                    try
                    {
                        Console.WriteLine("\nType the student #" + (i + 1) + " enrollment ID : ");
                        Students[i].Id = int.Parse(Console.ReadLine());
                        flag = false;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Type only numbers ");
                    }

                }

                        Console.WriteLine("\nType student #" + (i + 1) + " name");
                        Students[i].Name = Console.ReadLine();

                flag = true;
                while (flag) {
                    try
                    {
                        Console.WriteLine("\nType the student #" + (i + 1) + " age: ");
                        Students[i].Age = Students[i].SetAge(Students[i].Age);
                        flag = false;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Type only numbers");
                    }
                
                }
                flag = true;
                Students[i].password = Students[i].SetPassword(8, true);

                while (flag) {
                    try
                    {
                        Console.WriteLine("\nType the tuition fee of student # " + (i + 1));
                        Students[i].tuition_fee = int.Parse(Console.ReadLine());
                        flag = false;
                    }
                    catch (System.FormatException)
                    {

                        Console.WriteLine("Type only numbers");
                    }
                
                }

                        Console.WriteLine("\nIs the student an undergraduate (u) or graduate (g) student?");
                        Students[i].aux = Console.ReadLine();
                       
                ///// Due to cast error
                G_student[i].Id = Students[i].Id;
                G_student[i].Name = Students[i].Name;
                G_student[i].Age = Students[i].Age;
                G_student[i].password = Students[i].password;
                G_student[i].tuition_fee = Students[i].tuition_fee;

                ///// Due to cast error 
                U_student[i].Id = Students[i].Id;
                U_student[i].Name = Students[i].Name;
                U_student[i].Age = Students[i].Age;
                U_student[i].password = Students[i].password;
                U_student[i].tuition_fee = Students[i].tuition_fee;
                

                if (Students[i].aux == "g")
                {
                    Console.WriteLine("\nType the SNI level: ");
                    flag = true;

                    while (flag) {

                        try
                        {
                            G_student[i].SNI_level = int.Parse(Console.ReadLine());
                            flag = false;
                        }
                        catch (System.FormatException)
                        {

                            Console.WriteLine("Type only numbers");
                        }
                    }
                  
                    G_student[i].Check_SNI(G_student[i].SNI_level);

                    if (G_student[i].Check_SNI(G_student[i].SNI_level) == true)
                    {

                        Console.WriteLine("\nDoes the student have a scholarship? (type yes or no)");
                        G_student[i].aux3 = Console.ReadLine();

                        flag = true;

                        while (flag)
                        {
                            try
                            {
                                Console.WriteLine("\nType the porcentage of the scolarship: ");
                                G_student[i].scolarship = int.Parse(Console.ReadLine());
                                flag = false;
                            }
                            catch (System.FormatException)
                            {

                                Console.WriteLine("Type only numbers");
                            }

                        }
           
                        G_student[i].Scolarship(G_student[i].scolarship);


                    }
                    else {
                        Console.WriteLine("Entre al else");
                    }
                    
                }
                else if (Students[i].aux == "u"){
                    Console.WriteLine("\nDoes the student perform his/her social service? (type yes or no)");
                    U_student[i].aux2 = Console.ReadLine();

                    Console.WriteLine("\nDoes the student have a scholarship? (type yes or no)");
                    U_student[i].aux3 = Console.ReadLine();

                    if (U_student[i].aux3 == "yes") { 
                 
                        flag = true;

                        while (flag)
                        {
                            try
                            {
                                Console.WriteLine("\nType the porcentage of the scolarship: ");
                                U_student[i].scolarship = int.Parse(Console.ReadLine());
                                flag = false;
                            }
                            catch (System.FormatException)
                            {

                                Console.WriteLine("Type only numbers");
                            }

                        }
                        U_student[i].Scolarship(U_student[i].scolarship);
                    }
                }
                

                Console.Clear();

            }

            for (int j = 0; j < Students.Length; j++)
          {
                if (Students[j].aux == "u") {
                    
                    Console.WriteLine(U_student[j].ShowMenu());
                } 

                else if (Students[j].aux == "g"){

                    Console.WriteLine(G_student[j].ShowMenu());
                }

                Console.Write("\n");

          }
          Console.ReadLine();
          
        }
    }
}

using System;

namespace CDIS_Bank
{
    class Program
    {
       //Comments are just to check flags;;

        static void Main(string[] args)
        {
            int op, b500, b200, b100, b50, b20, m10, m5, m1;
                int value,temp, withdraw,aux = 0, i,j;
            int[] withdrawals = new int[10];
            int[] bills = new int[10];
            int[] coins = new int[10];

            do {
                
            do
            {
                    b500 = 0; b50 = 0;m5 = 0;
                    b200 = 0; b20 = 0;m1 = 0;
                    b100 = 0; m10 = 0; 
                
                    value = 0;
                   
                    Console.WriteLine("--------------------CDIS BANK--------------------");
                Console.WriteLine("1.- Type the number of withdrawals made by the user");
                Console.WriteLine("2.- Check the amount of bills and coins delivered");
                Console.WriteLine("\nType the option: ");
                    op = int.Parse(Console.ReadLine());

            }
            while (op < 1 || op > 2);

            if (op == 1)
            {
                    
                    Console.Clear();
                    for (i = 0; i < 10; i++)
                    {
                        withdrawals[i] = 0;
                    }
                do
                {
                    Console.WriteLine("How many withdrawals were made (Max 10) ");
                    withdraw = int.Parse(Console.ReadLine());
                        aux = withdraw;
                }
                while (withdraw < 1 || withdraw > 10);
                    do
                    {

                            for (i = 0; i < withdraw; i++)
                    {
                        Console.WriteLine("Type the ammount withdrawn #" + (i+1) );
                        withdrawals[i] = int.Parse(Console.ReadLine());
                    }
                } while (withdrawals[i] < 0 || withdrawals[i] > 50000);   
                }
            if (op == 2)
            {
                    if (withdrawals[0] == 0) {
                    Console.WriteLine("No withdraw has been made");
                        Console.ReadLine();
                }
                else
                    {
                        for (i = 0; i < aux; i++)
                        {
                            value = withdrawals[i];

                            //500bills
                           if (value >= 500)
                            {
                                b500 = value / 500;
                                temp = value % 500;
                                value = temp;
                                //Console.WriteLine("Withdraw # "+(i+1));
                                //Console.WriteLine("bills "+bills[i]+"coins "+coins[i]);
                                      Console.WriteLine("Billetes de 500: " + b500);
                            }
                            //200bills
                            if (value >= 200)
                            {
                                b200 = value / 200;
                                temp = value % 200;
                                value = temp;
                                  Console.WriteLine("Billetes de 200: " + b200);
                            }
                            //100bills
                            if (value >= 100)
                            {
                                b100 = value / 100;
                                temp = value % 100;
                                value = temp;
                                      Console.WriteLine("Billetes de 100: " + b100);
                            }
                            //50bills
                            if (value >= 50)
                            {
                                b50 = value / 50;
                                temp = value % 50;
                                value = temp;
                                      Console.WriteLine("Billetes de 50: " + b50);
                            }
                            //20bills
                            if (value >= 20)
                            {
                                b20 = value / 20;
                                temp = value % 20;
                                value = temp;
                                     Console.WriteLine("Billetes de 20: " + b20);
                            }

                            //10 coins
                            if (value >= 10)
                            {
                                m10 = value / 10;
                                temp = value % 10;
                                value = temp;
                                      Console.WriteLine("Monedas de 10: " + m10);
                            }
                            //5 coins
                            if (value >= 5)
                            {
                                m5 = value / 5;
                                temp = value % 5;
                                value = temp;
                                     Console.WriteLine("Monedas de 5: " + m5);
                            }
                            //1 coins
                            if (value >= 4)
                            {
                                m1 = value / 4;
                                temp = value % 4;
                                value = temp;
                                m1 *= 4;
                                Console.WriteLine("monedas de 1 "+m1);
                            }
                            if (value >= 3) {
                            
                            m1 = value / 3;
                            temp = value % 3;
                            value = temp;
                                m1 *= 3;
                                Console.WriteLine("monedas de 1 " + m1);
                            }
                            if (value >= 2)
                            {
                                m1 = value / 2;
                                temp = value % 2;
                                value = temp;
                                m1 *= 2;

                                   Console.WriteLine("monedas de 1 " + m1);
                            }
                            if (value >= 1)
                            {
                                m1 = value / 1;
                                temp = value % 1;
                                value = temp;
                                m1 *= 1;
                               break;
                                   Console.WriteLine("monedas de 1 " + m1);
                            }
                         
                            bills[i] = b500 + b200 + b100 + b50 + b20;
                            coins[i] = m10 + m5 + m1;

                        }

                       

                        for (j = 0; j < aux; j++)
                        {
                            Console.WriteLine("\n\tWithdraw # "+(j));
                            Console.WriteLine("Bills: " + bills[j] + "\nCoins: " + coins[j]);

                        }

                        
                        Console.WriteLine("Type enter to continue...");
                        Console.ReadLine();
                        Console.Clear();

                    }
                }
           
            }
            while (true);	
        }
    }
}

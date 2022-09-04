using System;

namespace chapter_sample
{
    class Program
    {
        static void Main(string[] args)
        {
          //   Console.WriteLine("Hello World!");

          //   string username = "Teejay";
          //  string password = "adewale123";
           
          //   Console.WriteLine(" USERNAME");
          //   string name = Console.ReadLine();
            
          //   Console.WriteLine("PASSWORD");
          //   string pass = Console.ReadLine();

          //   int  attempt = 3;

          //   while (!(attempt < 1))
          //   {
          //     if (username != name && password != pass)
          //     {
          //       Console.WriteLine("TRY AGAIN " + attempt-- + "  attempt left");
          //       Console.WriteLine("enter username again");
          //       Console.ReadLine();
          //       Console.WriteLine("enter password again");
          //        Console.ReadLine();
          //     } 
          //     else
          //     {
          //       Console.WriteLine("log in succesful....welcome ");
          //     } 
          //     if (attempt == 0)
          //     {
          //       Console.WriteLine("you wan collect");

          //       break;

          //     }

          //   }
                

                // int acct = 0264527689;
                // string bank = "gtb";
                // int balance = 30000;
                // Console.WriteLine("INPUT ACCOUNT NUMBER");
                // int acctnumber = int.Parse(Console.ReadLine());
                // Console.WriteLine("INPUT BANK NAME");
                // string bankname= Console.ReadLine();
                // int attempt = 3;
                // int PINCODE=1234;

                // while (!(attempt < 1))
                // {
                //   if (acctnumber == acct && bankname == bank)
                
                //   {
                //     Console.WriteLine("TIJANI AHMAD ADEWALE");
                //     Console.WriteLine("INPUT AMOUNT");
                //    int amount = int.Parse(Console.ReadLine());
                //    Console.Clear();
                //    if (amount > balance)
                //    {
                //     Console.WriteLine("INSUFFICIENT BALANCE....TRY AGAIN  "+ attempt-- + "attempt ");
                //     Console.WriteLine("ENTER AMOUNT AGAIN");
                //     Console.ReadLine();
                    
                //     Console.Clear();
                    
                    
                //    }
                //    else
                //    {
                //     Console.WriteLine("INPUT PIN");git init
                //     int PIN =int.Parse(Console.ReadLine());
                //     Console.Clear();
                //     if (PINCODE!=PIN)
                //     {
                //       Console.WriteLine("INCORRECT PIN....TRYAGAIN");
                //     }
                //     else
                //     {
                //       Console.WriteLine($"TRANSFER SUCCESSFULL YOUR BALANCE IS {balance - amount}");
                //       break;

                //     }
                //    }
                //        if (attempt==0)
                //        {
                //         Console.WriteLine("You have been locked out");
                //         break;
                //        }
                //   }else
                //   {
                //     Console.WriteLine($"INCORRECT DETAILS ....TRY AGAIN {attempt--} attempt left");
                //     Console.WriteLine("enter acct number again");
                //     Console.ReadLine();
                //     Console.WriteLine("enter bank name again");
                //     Console.ReadLine();
                //     if (attempt==0)
                //     {
                //       Console.WriteLine(" YOU HAVE BEEN LOCKED OUT....TRY AGAIN IN 72HRS");
                //     }

                //   }
                // }


                //       // Console.WriteLine("practice");
                //       // int n = int.Parse(Console.ReadLine());
                //       // decimal  f = 1;

                //       // for (int x = 1; x <= n; x++)
                //       // {
                //       //   f *= x;
                //       // }
                //       //  Console.WriteLine(f);

           
                  int n = int.Parse(Console.ReadLine());

                  for (int row = 0; row <= n ; row++)
                  {
                    for (int col = 0; col <= row; col++)
                    {
                      Console.Write(col + " ");
                    }
                    Console.WriteLine();
                  }  

                  
        }
             
    }
}

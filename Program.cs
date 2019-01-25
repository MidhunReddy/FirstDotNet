using System;

namespace FirstDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Student Grade Calculator*******");
            Console.WriteLine("Enter the Student Name");
            string sName = Console.ReadLine();
            Console.WriteLine("Enter how many courses student has enrolled");
            int cNum = Convert.ToInt32(Console.ReadLine());
            double per = 0.0;
            double tMarks = 0.0;
            
            for (int i=1; i<cNum+1; i++)
            {
                Console.WriteLine($"Enter the marks scored in number {i} course:");
                double cMarks = Convert.ToDouble(Console.ReadLine());
                tMarks = tMarks+cMarks;
                
            }
                per = Per(tMarks,cNum);
               if (per<=40){    
               Console.WriteLine("You have scored Grade F");}
               else if (per>40 && per<=60){
               
               Console.WriteLine("You have scored Grade E");}
               else if (per>60 && per<=70){
               Console.WriteLine("You have scored Grade D");}
               else if (per>70 && per<=80){
               Console.WriteLine("You have scored Grade C");}
               else if (per>80 && per<=90){
               Console.WriteLine("You have scored Grade B");}
               else if (per>90 && per<=100){
               Console.WriteLine("You have scored Grade A");}
                else {
               Console.WriteLine(" You are not qualified ");}

               Console.WriteLine("Please rate us :");
               Console.WriteLine("a. excellent");
               Console.WriteLine("b. good");
               Console.WriteLine("c. bad");
               char rate = Convert.ToChar(Console.ReadLine());
               switch(rate)
               {
                   case 'a':
                   Console.WriteLine("Thank you so much");
                   break;
                   case 'b':
                   Console.WriteLine("We will try to improve next time");
                   break;
                   case 'c':
                   Console.WriteLine("Please leave your suggestion");
                   string sug = Console.ReadLine();
                   break;
                   default :
                   Console.WriteLine("Its Okay");
                   break;

               }


        }
        static double Per(double tMarks, double cNum) {
        return tMarks/cNum;
        }
    
    }  
    
}

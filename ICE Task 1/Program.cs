 using System;

 namespace ICE_Task_1
 {

     class Program
     {
         public static float finalSubtotal;

         public static float subTotal;
         // public static float singleSubtotal;
         
         public static void Main(String[] args)
         {
             Console.WriteLine("Please enter the total number of scripts: ");
             float totalScripts = int.Parse(Console.ReadLine()!);
             
                while (totalScripts < 1)
                {
                 Console.WriteLine("Incorrect value please enter the total number of scripts: ");
                 totalScripts = int.Parse(Console.ReadLine()!);
                 
                }
             
             Console.WriteLine("Please enter the number of questions in the test: ");
             int numQuestions = int.Parse(Console.ReadLine()!);
             
                while (numQuestions < 1 || numQuestions > 10 )
                {
                    Console.WriteLine("Incorrect value please enter the number of questions in the test: ");
                    numQuestions = int.Parse(Console.ReadLine()!);
                 
                }

             Console.WriteLine("Please enter the subtotal of each question: ");
             
             
             for (int i = 1; i <= numQuestions; i++) 
             {
                 Console.WriteLine("Please enter the subtotal for question " + (i) + ".");
                 subTotal = int.Parse(Console.ReadLine()!); 
                 finalSubtotal += subTotal;
                 
                 while (subTotal < 1 )
                 {
                     Console.WriteLine("Incorrect value please enter the subtotal of each question: ");
                     subTotal = int.Parse(Console.ReadLine()!);
                     
                 
                 }

                 subTotal = 0;
             }
             
             Console.WriteLine("Please enter the number of lecturers marking the scripts: ");
             float numLecturers = int.Parse(Console.ReadLine()!);
             
                while (numLecturers < 1 )
                {
                    Console.WriteLine("Incorrect value please enter the number of lecturers marking the scripts: ");    
                    numLecturers = int.Parse(Console.ReadLine()!);
                 
                }

                if (totalScripts % numLecturers != 0 )
                {
                    Console.WriteLine("The number of scripts each lecture is going to mark: " + Math.Floor(totalScripts/numLecturers));
                    Console.WriteLine("The number of scripts the last lecturer will mark: " + Math.Floor(totalScripts/numLecturers + totalScripts % numLecturers));
                    Console.WriteLine("The last lecturer will mark " + totalScripts % numLecturers + " additional papers." );
                    
                }
                else
                {
                    Console.WriteLine("The number of scripts each lecture is going to mark: " + Math.Floor(totalScripts/numLecturers));
                }


                int secMark = 2;
                float min = 60;
                float hrs = 3600;
                
                Console.WriteLine("The estimated time it will take each lecturer to finish marking the allocated scripts is: " + finalSubtotal*secMark/hrs/numLecturers + " hours, " + finalSubtotal*secMark/min/numLecturers + " minutes or " + finalSubtotal*secMark/numLecturers + " seconds." );
                Console.WriteLine("The estimated time it will take to finish marking all the allocated scripts is: " + finalSubtotal*secMark/hrs + " hours, " + finalSubtotal*secMark/min + " minutes or " + finalSubtotal*secMark + " seconds.");
         }
     }
}
// See https://aka.ms/new-console-template for more information

using System;
class Employee
{
    public void employeedetails()
    {
        //Taking Inputs from the user........
        Console.WriteLine("Taking inputs");
        Console.WriteLine("Enter ID:");
       string inputid=Console.ReadLine();
       Console.WriteLine("Enter Name:");
       string name=Console.ReadLine();
       Console.WriteLine("Enter Salary");
       string inputsalary=Console.ReadLine();
        
        //converting the inputid,inputsalary into string...
        int id=Convert.ToInt32(inputid);
        int salary=Convert.ToInt32(inputsalary);

        if (salary<=25000)
        {
            Console.WriteLine("Associate Engineer Trainee =>"+id+". "+""+name);
        }
        else if (salary>=100000)
        {
                Console.WriteLine("Mern Dev =>"+id+"."+" "+name);
        }

        
        
    }

   public void stringprogramming()
   {
    Console.WriteLine("Taking inputs");
    Console.WriteLine("Enter name");
          string name=Console.ReadLine();
           int len=name.Length;
           name.ToLower();
           int vowel_count=0;
           int consonent_count=0;

    for (int i = 0; i < len; i++)
    {
        if (name[i]=='a' || name[i]=='e' || name[i]=='i' || name[i]=='o' || name[i]=='u')
        {
              vowel_count++;              
        }
        else{
consonent_count++;
        }

    }   

    Console.WriteLine("the string "+name+" is having "+vowel_count+" number of vowels "+ consonent_count+" number of consonent.");



   } 

    public static void Main()
    {
        Console.WriteLine("Enter the CHOICE 1 or 2 ");
        Console.WriteLine("Enter 1 for Employee Details");
        Console.WriteLine("Enter 2 for string program");
 

         string menu=Console.ReadLine();

         int choice=Convert.ToInt32(menu);
         switch (choice)
         {
            case 1:
            Employee obj1=new Employee();
      obj1.employeedetails();
       break;
          
          case 2:
  Employee obj2=new Employee();
     obj2.stringprogramming();
     break;

            default:
            Console.WriteLine("ERROR");
            break;
         }

      
    
    

    }
    
}



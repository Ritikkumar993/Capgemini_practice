


class Program
{    public static void Main()
    {
        // //tasks
        // Tasks tk=new Tasks();
        // tk.task1();
        // tk.task2();
        




        // mediSureClinic
        PatientBill msc=new PatientBill();
        bool check=true;
        Console.WriteLine("================== MediSure Clinic Billing ==================");
        while (check)
        {
            // 1.	1. Create New Bill (Enter Patient Details)
            Console.WriteLine("1. Create New Bill (Enter Patient Details)\n2. View Last Bill\n3. Clear Last Bill\n4. Exit\nEnter your option: ");
            
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    msc.CreateNewBill();
                    PatientBill.LastBill=msc;
                    PatientBill.HasLastBill=true;
                    break;
                case 2:
                    msc.ViewLastBill();
                    break;
                case 3:
                    msc.ClearLastBill();
                    break;
                case 4:
                    check=false;
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;
                default:
                    break;
            }
       
        }








    }
}
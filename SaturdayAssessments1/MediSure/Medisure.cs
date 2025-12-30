class PatientBill
{
    public string BillId{get;set;}
    public string PatientName{get;set;}
    public bool HasInsurance{get;set;}
    public decimal ConsultationFee{get;set;}
    public decimal LabCharges{get;set;}
    public decimal MedicineCharges{get;set;}
    public decimal GrossAmount; 
    public decimal DiscountAmount; 
    public decimal FinalPayable; 


    public static PatientBill? LastBill;

    public static bool HasLastBill=false;
    


    public void CreateNewBill()
    {
      
        Console.Write("\nEnter Bill Id:");
        BillId=Console.ReadLine();
        if (BillId == "")
        {
            Console.WriteLine("");
            return;
        }


        Console.Write("\nEnter Customer Name: ");
        PatientName=Console.ReadLine();

        Console.Write("\nIs the patient insured? (Y/N): ");
        char ch=char.Parse(Console.ReadLine());
        Char.ToLower(ch);
        HasInsurance= ch=='y';
        Console.Write("\nEnter Consultation Fee: ");
        ConsultationFee=decimal.Parse(Console.ReadLine());
        

        Console.Write("\nEnter Lab Charges: ");
        LabCharges=decimal.Parse(Console.ReadLine());

        Console.Write("\nEnter Medicine Charges: ");
        MedicineCharges=decimal.Parse(Console.ReadLine());
        if(ConsultationFee<=0 && LabCharges<0 && MedicineCharges < 0)
        {
            Console.Write("Invalid parameter ");
            string messg;
            if (ConsultationFee <= 0)
            {
                messg="Consultation Fee";
            }
            else if(LabCharges<0)
            {
                messg="Lab Charges";
            }
            else
            {
                messg="MedicineCharges";
            }
            Console.Write(messg);
            return ;
        }
        Console.WriteLine("\nBill created successfully.");

        GrossAmount=ConsultationFee+LabCharges+MedicineCharges;
        Console.WriteLine("Gross Amount: "+GrossAmount.ToString("F2"));;
      
        
        DiscountAmount=GrossAmount*0.10m;
        Console.WriteLine("Discount Amount: "+DiscountAmount.ToString("F2"));

        FinalPayable=GrossAmount-DiscountAmount;
        Console.WriteLine("Final Payable: "+FinalPayable.ToString("F2"));
        
    }

    public void ViewLastBill()
    {
        if (HasLastBill)
        { 
            Console.WriteLine("----------- Last Bill -----------");
            Console.WriteLine("BillId: "+LastBill.BillId);
            Console.WriteLine("Patient: "+LastBill.PatientName);
            string show=LastBill.HasInsurance?"Yes":"No";
            Console.WriteLine("Insured: "+show);
            Console.WriteLine("Consultation Fee: "+LastBill.ConsultationFee);
            Console.WriteLine("Lab Charges: "+LastBill.LabCharges);
            Console.WriteLine("Medicine Charges: "+LastBill.MedicineCharges);
            Console.WriteLine("Gross Amount: "+LastBill.GrossAmount);
            Console.WriteLine("Discount Amount: "+LastBill.DiscountAmount);
            Console.WriteLine("Final Payable: "+LastBill.FinalPayable);
        }
        else
        {
            Console.WriteLine("No Bills");
        }
    }
    public void ClearLastBill()
    {
        if (HasLastBill)
        {
            LastBill=null;
            HasLastBill=false;
            Console.WriteLine("Last Bill is Cleared");
        }
        else
        {
            Console.WriteLine("No Last Bills to Cleared" );
        }
    }
}
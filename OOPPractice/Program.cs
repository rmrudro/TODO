// See https://aka.ms/new-console-template for more information






//First One 



//2nd One 
//var medicalAppointment = new MedicalAppointment(
//    "Rifat Murtuza", new DateTime(2024, 5, 7));
//medicalAppointment.Reschedule(new DateTime(2024, 8, 1));

//Console.ReadKey();

//class MedicalAppointMentPrinter
//{
//    public void Print(MedicalAppointment appointment)
//    {
//        Console.WriteLine(
//            "Appointment will take place on " + appointment.GetDate());
//    }
//}





//class MedicalAppointment
//{

//    private string _patientName;
//    private DateTime _date;


//    public MedicalAppointment(string patientName, DateTime date)
//    {
//        _patientName = patientName;
//        _date = date;
//    }
//    public MedicalAppointment(string patientName,int daysFromNow=7)
//    {
//        _patientName = patientName;
//        _date = DateTime.Now.AddDays(daysFromNow);
//    }
//    //public MedicalAppointment(string patientName):
//    //    this(patientName,7)
//    //{

//    //}
//    public DateTime GetDate() => _date;

//    public void Reschedule(DateTime date)
//    {
//        _date = date;
//        var printer = new MedicalAppointMentPrinter();
//        printer.Print(this);
//    }
//    public void OverWriteMonthAndDay(int month,int day)
//    {
//        _date = new DateTime(_date.Year, month, day);

//    }
//    public void MoveByMonthsAndDay(int monthsToAdd, int daysToAdd)
//    {
//        _date = new DateTime(
//            _date.Year,
//            _date.Month+monthsToAdd,
//            _date.Day+daysToAdd);
//    }

//}
namespace lab_1_c_
{
    
    interface IPerson
    {
        int CardNumber { get; }
        string Name { get; }
        DateTime Bithday { get; }
        public int calcAge(DateTime Thisdate);
    }
    public class Person : IPerson
    {
        private int cardNumber;
        private string name;
        private DateTime date;

        public Person()
        {
            cardNumber = 0;
            name = " ";
            date = DateTime.MinValue;
        }

        public Person(int cardNumberThis, string nameThis ,DateTime dateThis)
        {
            cardNumber = cardNumberThis;
            name = nameThis;
            date = dateThis;
        }
        public int CardNumber
        {
            get
            {
                return cardNumber;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public DateTime Bithday
        {
            get
            {
                return date;
            }
        }
        public int calcAge(DateTime thisDate)
        {
            if (date == DateTime.MinValue)
            {
                return 0;
            }
           
            if (thisDate.Month > date.Month)
            {
                return thisDate.Year - date.Year;
            }
            else if (thisDate.Month == date.Month)
            {
                if (thisDate.Day >= date.Day) { return thisDate.Year - date.Year; }
                else { return (thisDate.Year - date.Year - 1); }
            }
            else { return thisDate.Year - date.Year - 1; }
        }

        public string trans()
        {
            return name + " " + calcAge(DateTime.Now).ToString();
        }

        public void load(int numner, string names, DateTime Datethis)
        {
            cardNumber = numner;
            name = names;
            date = Datethis;
        }
    }

    public static class Date
    {
        public static bool examforchoice = false;
        public static bool exam = false;
        public static int Cardnumber= 00000;
        public static DateTime dr = DateTime.Now;
        public static string name = "name";
    }

   
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        
    }
}



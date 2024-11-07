namespace lab_1_c_
{
    
    interface IPerson
    {
        int CardNumber { get; }
        string Name { get; }
        DateTime Bithday { get; }
        public int calcAge(DateTime Thisdate);
    }
    class Person : IPerson
    {
        public int cardNumber;
        private string name;
        private DateTime date;

        public Person()
        {
            cardNumber = 0;
            name = "пользователь отсутствует";
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
                return thisDate.Year - date.Month;
            }
            else if (thisDate.Month == date.Month)
            {
                if (thisDate.Day >= date.Day) { return thisDate.Year - date.Year; }
                else { return (thisDate.Year - date.Year - 1); }
            }
            else { return thisDate.Year - date.Year - 1; }
        }
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



namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Console.WriteLine();
            //can not convert null to a datetime becuase it is a non-nullable value type
            //DateTime date = null;

            Nullable<DateTime> date = null;
            Console.WriteLine($"date= {date}");

            //short hand of nullable value type
            DateTime? birthDate = null;
            Console.WriteLine($"birthDate HasValue= {birthDate.HasValue}");
            Console.WriteLine($"birthDate GetValueOrDefault= {birthDate.GetValueOrDefault()}");
            //The following will throw exception so you should check birthDate.HasValue first.
            //Console.WriteLine($"birthDate Value= {birthDate.Value}");

            //DateTime date2 = birthDate;
            DateTime date2 = birthDate.GetValueOrDefault();
            Console.WriteLine($"date2 ={date2}");

            //null coalescing operator
            DateTime date3 = date ?? birthDate.GetValueOrDefault();

            //ternary conditional operator
            DateTime date4 = (date != null) ? birthDate.GetValueOrDefault() : DateTime.Now;


            Console.WriteLine();
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}

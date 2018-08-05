namespace Ch10Examples
{
    public class Person
    {
        public Person(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person()
        {
            Increment();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static int Count { get; private set; }

        private static void Increment()
        {
            Count++;
        }
    }
}
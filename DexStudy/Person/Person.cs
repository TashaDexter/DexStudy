namespace Person
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static implicit operator Person(string s)
        {
            string[] initials = s.Split(' ');
            return new Person { FirstName = initials[0], LastName = initials[1] };
        }

        public static implicit operator string(Person person)
        {
            return person.FirstName + " " + person.LastName;
        }
    }
}
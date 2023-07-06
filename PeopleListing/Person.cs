namespace PeopleListing
{
    class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string City { get; private set; }
        public string PESEL { get; private set; }

        public Person() { }

        public Person(string name, string surname, string city, string pesel)
        {
            Name = name;
            Surname = surname;
            City = city;
            PESEL = pesel;
        }

        public override string ToString()
        {
            return $"| {Name} {Surname} | {City}";
        }
    }
}

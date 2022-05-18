namespace SocialniDavky
{
    public class Human
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Ration { get; set; }

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
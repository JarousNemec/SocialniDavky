namespace SocialniDavky
{
    public class Human
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Ration { get; set; }
        public int Gender { get; private set; }

        public Human(string name, string surname, int gender)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
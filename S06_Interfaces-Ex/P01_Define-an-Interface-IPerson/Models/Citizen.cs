namespace PersonInfo
{
    public class Citizen : IPerson
    {
        private string _name;
        private int _age;

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Age
        {
            get => _age;
            set => _age = value;
        }
    }
}
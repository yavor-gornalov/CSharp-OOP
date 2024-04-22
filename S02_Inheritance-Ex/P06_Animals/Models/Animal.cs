namespace Animals.Models
{
    public abstract class Animal
    {
        private string _name;
        private int _age;
        private string _gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException();
                _name = value;
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                _age = value;
            }
        }
        public string Gender
        {
            get => _gender;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException();
                _gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{this.GetType().Name}\n{Name} {Age} {Gender}\n{ProduceSound()}";
        } 
    }
}

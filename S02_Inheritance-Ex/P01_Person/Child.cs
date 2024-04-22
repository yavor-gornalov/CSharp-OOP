namespace People
{
    public class Child : Person
    {
        //private int age;

        public Child(string name, int age) : base(name, age)
        {
            this.Age = age;
            this.Name = name;
        }

        //public int Age
        //{
        //    set
        //    {
        //        if (value > 15)
        //            throw new InvalidOperationException();
        //        this.age = value;
        //    }
        //}
    }
}

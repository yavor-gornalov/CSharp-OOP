namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var animal = new Animal();
            animal.Eat();

            var dog = new Dog();
            dog.Eat();
            dog.Bark();
        }
    }
}

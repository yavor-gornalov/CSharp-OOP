namespace BirthdayCelebrations.Interfaces
{
    public interface IBirthable
    {
        public string Birthdate { get; set; }
        void PrintBirthdate() => Console.WriteLine(Birthdate);
    }
}

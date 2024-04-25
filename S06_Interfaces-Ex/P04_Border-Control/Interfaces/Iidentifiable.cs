namespace BorderControl.Interfaces
{
    public interface Iidentifiable
    {
        public string Id { get; set; }

        void PrintId() => Console.WriteLine(Id);
    }
}

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;

        public RandomList()
        {
            this.rnd = new Random();
        }

        private int GetRandomIndex() => rnd.Next(0, this.Count);

        public string RemoveRandomElement()
        {
            int index = this.GetRandomIndex();
            string str = this[index];
            this.RemoveAt(index);
            return str;
        }

        public string RandomString()
        {
            return this[this.GetRandomIndex()];
        }
    }
}

namespace CollectionHierarchy.Models
{
    public abstract class Collection
    {
        protected Collection()
        {
            Data = new List<string>();
        }

        public List<string> Data { get; private set; }
    }
}

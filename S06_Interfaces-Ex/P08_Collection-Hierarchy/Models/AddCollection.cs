using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class AddCollection : Collection, IAddCollection
    {
        public int Add(string item)
        {
            int idx = Data.Count;
            Data.Add(item);
            return idx;
        }
    }
}

using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection : Collection, IAddRemoveCollection
    {
        public int Add(string item)
        {
            int idx = 0;
            Data.Insert(idx, item);
            return idx;
        }
        public string Remove()
        {
            int idx = Data.Count - 1;
            string item = Data[idx];
            Data.RemoveAt(idx);
            return item;
        }
    }
}

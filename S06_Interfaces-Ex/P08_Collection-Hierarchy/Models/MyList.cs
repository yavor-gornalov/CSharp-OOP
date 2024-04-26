using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class MyList : Collection, IMyList
    {
        public int Add(string item)
        {
            int idx = 0;
            Data.Insert(idx, item);
            return idx;
        }

        public string Remove()
        {
            int idx = 0;
            string item = Data[idx];
            Data.RemoveAt(idx);
            return item;
        }

        public int Used() => Data.Count;
    }
}

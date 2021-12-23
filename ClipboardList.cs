using System.Collections.Generic;
using System.Linq;

namespace ClipboardHistory
{

    class ClipboardList
    {
        private readonly List<ICopyable> copyables = new();

        public bool IsLast(ICopyable item) 
        {
            if (copyables.Count == 0) return false;
            ICopyable element = copyables.First();
            if (item.Equals(element)) 
            {
                return true;
            }
            return false;
        }
        
        public bool Add(ICopyable item) 
        {
            if (IsLast(item)) 
            {
                return false;
            }
            copyables.Insert(0, item);
            return true;
            
        }

        public bool PushInClipboard(int index) 
        {
            if (index < 0 || index > copyables.Count - 1) return false;
            copyables[index].Push();
            return true;
        }

        public ICopyable GetById(int index) 
        {
            if (index < 0 || index > copyables.Count - 1) return null;
            return copyables[index];
        }
    }
}

using System.Collections.Generic;

namespace PackerTracker.Models {
    public class PackList {
        public static Dictionary<string, PackList> Lists {get;} = new Dictionary<string, PackList>();
        private List<PackItem> PackingList {get; set;}
        public string Name {get; set;}

        public PackList(string name) {
            Name = name;
            Lists.Add(Name, this);
        }

        public void AddItem(PackItem item) {
            PackingList.Add(item);
        }

        public List<PackItem> GetList() {
            return PackingList;
        }
    }
}
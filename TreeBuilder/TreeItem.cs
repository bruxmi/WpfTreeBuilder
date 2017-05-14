using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBuilder
{
    public class TreeItem
    {
        public TreeItem()
        {
            Children = new ObservableCollection<TreeItem>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public ObservableCollection<TreeItem> Children { get; set; }
    }
}

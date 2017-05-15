using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TreeBuilder
{
    public class TreeViewModel: ViewModelBase
    {
        public TreeViewModel()
        {
            this.LoadTreeCommand = new DelegateCommand(a => LoadTree());
        }

        private void LoadTree()
        {
            this.TreeItems = new ObservableCollection<TreeItem>();
            var dataProvider = new DataProvider();
            var treeData = dataProvider.GetData();
            var treeBuilder = new TreeBuilderService();
            var tree = treeBuilder.BuildTree(treeData, new List<string> { "Kategorie", "Kundenart", "Sparte", "Status"});
            foreach (var item in tree)
            {
                this.TreeItems.Add(item);
            }
        }

        public ObservableCollection<TreeItem> TreeItems
        {
            get { return GetValue<ObservableCollection<TreeItem>>(); }
            set { SetValue(value); }
        }

        public ICommand LoadTreeCommand { get; set; }
    }
}

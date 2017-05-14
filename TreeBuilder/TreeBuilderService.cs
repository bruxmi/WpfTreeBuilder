using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBuilder
{
    public class TreeBuilderService
    {
        public ObservableCollection<TreeItem> BuildTree(List<Data> treeData)
        {
            var roots = new ObservableCollection<TreeItem>();

            foreach (var groupKategorie in treeData.GroupBy(a => a.Kategorie))
            {
                var kategorie = new TreeItem { Bezeichnung = groupKategorie.Key };
                foreach (var groupKundenart in groupKategorie.GroupBy(a => a.Kundenart))
                {
                    var kundenart = new TreeItem { Bezeichnung = groupKundenart.Key };
                    foreach (var groupSparte in groupKundenart.GroupBy(a => a.Sparte))
                    {
                        var sparte = new TreeItem { Bezeichnung = groupSparte.Key };
                        foreach (var groupStatus in groupSparte.GroupBy(a => a.Status))
                        {
                            var status = new TreeItem { Bezeichnung = groupStatus.Key };
                            foreach (var item in groupStatus)
                            {
                                status.Children.Add(new TreeItem { Bezeichnung = item.Bezeichnung });
                            }
                            sparte.Children.Add(status);
                        }
                        kundenart.Children.Add(sparte);
                    }
                    kategorie.Children.Add(kundenart);
                }
                roots.Add(kategorie);
            }

            return roots;
        }

        public ObservableCollection<TreeItem> BuildTree(List<Data> treeData, List<string> propertyNames)
        {
            var roots = new ObservableCollection<TreeItem>();
            var count = 0;

            var toOrder = treeData.ToList();

            while (count != propertyNames.Count)
            {
                foreach (var propertyName in propertyNames)
                {
                    var grouping = GroupByPropertyName(toOrder, propertyName);
                    foreach (var groupedList in grouping)
                    {
                        var treeItem = new TreeItem { Bezeichnung = groupedList.Key };
                    }
                }
            }


            return roots;
        }

        public ObservableCollection<TreeItem> DoSomething(List<Data> source, List<string> propertyNames)
        {
            var tmpSource = source.ToList();
            var firstPropertyName = propertyNames.First();
            var treeItems = new ObservableCollection<TreeItem>();

            return treeItems;
        }

        private TreeItem AddChildrenToParent(TreeItem parent, List<TreeItem> children)
        {
            foreach (var item in children)
            {
                parent.Children.Add(item);
            }
            return parent;
        }

        private IEnumerable<IGrouping<string, T>> GroupByPropertyName<T>(List<T> items, string propertyName)
        {
            var grouped = items.GroupBy(x => GetPropertyValue(x, propertyName));
            return grouped;
        }

        private string GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null) as string;
        }
    }
}

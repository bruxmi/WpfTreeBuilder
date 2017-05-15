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
        public ObservableCollection<TreeItem> BuildTree(List<Data> treeData, List<string> propertyNames)
        {
            var roots = new ObservableCollection<TreeItem>();
            var itemsToGroup = treeData.ToList();

            foreach (var grouping in GroupByPropertyName(itemsToGroup, propertyNames.First()))
            {
                var parent = new TreeItem { Bezeichnung = grouping.Key };
                var newPropertyNames = propertyNames.Except(new List<string> { propertyNames.First() }).ToList();
                var children = OrganizeTree(newPropertyNames, grouping.ToList(), newPropertyNames.First(), parent, false);
                parent.Children.Add(children);
                roots.Add(parent);
            }

            return roots;
        }

        private TreeItem OrganizeTree(List<string> propertyNames, List<Data> itemsToGroup, string propertyName, TreeItem parent, bool isLastGrouping)
        {
            foreach (var grouping in GroupByPropertyName(itemsToGroup, propertyName))
            {
                var treeItem = new TreeItem { Bezeichnung = grouping.Key };
                if (isLastGrouping)
                {
                    foreach (var item in grouping)
                    {
                        treeItem.Children.Add(new TreeItem { Bezeichnung = item.Bezeichnung });
                    }
                    parent.Children.Add(treeItem);
                }
                else
                {
                    var newPropertyNames = propertyNames.Except(new List<string> { propertyName }).ToList();
                    return OrganizeTree(newPropertyNames, grouping.ToList(), newPropertyNames.First(), treeItem, newPropertyNames.Count == 1);
                }
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

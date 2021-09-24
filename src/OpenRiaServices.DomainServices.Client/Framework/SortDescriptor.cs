using System.Windows;

namespace OpenRiaServices.Controls
{
    public class ListSortDirection
    {
    }

    public class SortDescriptor : DependencyObject
    {
        public ListSortDirection Direction { get; set; }

        public string PropertyPath { get; set; }
    }
}

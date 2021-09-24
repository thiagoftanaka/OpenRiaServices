using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using OpenRiaServices.DomainServices.Client;

namespace OpenRiaServices.Controls
{
    public class DomainDataSourceView : IEditableCollectionView
    {
        public NewItemPlaceholderPosition NewItemPlaceholderPosition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CanAddNew => throw new NotImplementedException();

        public bool IsAddingNew => throw new NotImplementedException();

        public object CurrentAddItem => throw new NotImplementedException();

        public bool CanRemove => throw new NotImplementedException();

        public bool CanCancelEdit => throw new NotImplementedException();

        public bool IsEditingItem => throw new NotImplementedException();

        public object CurrentEditItem => throw new NotImplementedException();

        public object AddNew()
        {
            throw new NotImplementedException();
        }

        public void CancelEdit()
        {
            throw new NotImplementedException();
        }

        public void CancelNew()
        {
            throw new NotImplementedException();
        }

        public void CommitEdit()
        {
            throw new NotImplementedException();
        }

        public void CommitNew()
        {
            throw new NotImplementedException();
        }

        public void EditItem(object item)
        {
            throw new NotImplementedException();
        }

        public void Remove(object item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }

    public class DomainDataSource : Control
    {
        public bool AutoLoad { get; set; }

        public IEnumerable DesignData { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public event EventHandler<LoadedDataEventArgs> LoadedData;

        public string Name { get; set; }

        public string QueryName { get; set; }

        public int PageSize { get; set; }

        public int LoadSize { get; set; }

        public DomainDataSourceView DataView { get; set; }

        public DomainContext DomainContext { get; set; }

        public SortDescriptorCollection SortDescriptors { get; set; }
    }

    public class SortDescriptorCollection : DependencyObjectCollection<SortDescriptor>
    {
    }


    public class DependencyObjectCollection<T> : ICollection<T> where T : DependencyObject
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

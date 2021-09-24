using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using OpenRiaServices.DomainServices.Client;

namespace OpenRiaServices.Data.DomainServices
{
    public class DomainCollectionView<TEntity> : ICollectionView where TEntity : Entity
    {
        public DomainCollectionView(DomainCollectionViewLoader<TEntity> collectionViewLoader, IEnumerable source)
        {
        }

        public event CurrentChangingEventHandler CurrentChanging;
        public event EventHandler CurrentChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public bool MoveToFirstPage()
        {
            return default(bool);
        }

        public virtual int PageSize { get; set; }

        public virtual object CurrentItem { get; }

        public bool CanAddNew { get; }

        public int TotalItemCount { get; }

        public CultureInfo Culture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable SourceCollection => throw new NotImplementedException();

        public Predicate<object> Filter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CanFilter => throw new NotImplementedException();

        public SortDescriptionCollection SortDescriptions => throw new NotImplementedException();

        public bool CanSort => throw new NotImplementedException();

        public bool CanGroup => throw new NotImplementedException();

        public ObservableCollection<GroupDescription> GroupDescriptions => throw new NotImplementedException();

        public ReadOnlyObservableCollection<object> Groups => throw new NotImplementedException();

        public bool IsEmpty => throw new NotImplementedException();

        public int CurrentPosition => throw new NotImplementedException();

        public bool IsCurrentAfterLast => throw new NotImplementedException();

        public bool IsCurrentBeforeFirst => throw new NotImplementedException();

        public void SetTotalItemCount(int itemCount)
        {
        }

        public void Refresh()
        {
        }

        public bool Contains(object item)
        {
            throw new NotImplementedException();
        }

        public IDisposable DeferRefresh()
        {
            throw new NotImplementedException();
        }

        public bool MoveCurrentToFirst()
        {
            throw new NotImplementedException();
        }

        public bool MoveCurrentToLast()
        {
            throw new NotImplementedException();
        }

        public bool MoveCurrentToNext()
        {
            throw new NotImplementedException();
        }

        public bool MoveCurrentToPrevious()
        {
            throw new NotImplementedException();
        }

        public bool MoveCurrentTo(object item)
        {
            throw new NotImplementedException();
        }

        public bool MoveCurrentToPosition(int position)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

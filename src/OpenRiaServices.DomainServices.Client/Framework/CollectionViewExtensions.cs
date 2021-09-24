using System.ComponentModel;
using OpenRiaServices.DomainServices.Client;

namespace OpenRiaServices.Data.DomainServices
{
    public static class CollectionViewExtensions
    {
        public static EntityQuery<TEntity> SortAndPageBy<TEntity>(this EntityQuery<TEntity> query, ICollectionView collectionView) where TEntity : Entity
        {
            return default(EntityQuery<TEntity>);
        }

        public static QueryBuilder<TEntity> SortAndPageBy<TEntity>(this QueryBuilder<TEntity> query, ICollectionView collectionView) where TEntity : Entity
        {
            return default(QueryBuilder<TEntity>);
        }
    }
}

using System;
using OpenRiaServices.DomainServices.Client;

namespace OpenRiaServices.Data.DomainServices
{
    public class DomainCollectionViewLoader<TEntity> where TEntity : Entity
    {
        public DomainCollectionViewLoader(Func<LoadOperation<TEntity>> load, Action<LoadOperation<TEntity>> onLoadCompleted)
        {
        }
    }
}

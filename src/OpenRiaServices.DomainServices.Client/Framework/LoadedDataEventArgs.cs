using System;
using System.Collections.Generic;
using OpenRiaServices.DomainServices.Client;

namespace OpenRiaServices.Controls
{
    public class LoadedDataEventArgs
    {
        public LoadedDataEventArgs(IEnumerable<Entity> entities, IEnumerable<Entity> allEntities, int totalEntityCount, bool cancelled, Exception error)
        {
        }

        public bool HasError { get; }

        public Exception? Error { get; }

        public void MarkErrorAsHandled()
        {
        }
    }
}

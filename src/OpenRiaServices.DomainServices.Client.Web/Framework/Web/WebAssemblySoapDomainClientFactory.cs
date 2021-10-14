using System;
using System.ServiceModel.Channels;

namespace OpenRiaServices.DomainServices.Client.Web
{
    /// <summary>
    /// For connecting to services from Blazor application.
    /// This class is necessary to bypass client initialization logic.
    /// </summary>
    public class WebAssemblySoapDomainClientFactory : SoapDomainClientFactory
    {
        /// <summary>
        /// Generates a Binding. The result is not used because we do not have full support of WCF in WebAssembly
        /// </summary>
        /// <param name="endpoint">Absolute service URI</param>
        /// <param name="requiresSecureEndpoint"><c>true</c> if communication must be secured, otherwise <c>false</c></param>
        /// <returns>A <see cref="Binding"/></returns>
        protected override Binding CreateBinding(Uri endpoint, bool requiresSecureEndpoint)
        {
            return new CustomBinding();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Catalog.API
{
    // TODO: Rename CatalogSettings for consistency?
    public class Settings
    {
        public string ExternalCatalogBaseUrl {get;set;}
        public string EventBusConnection { get; set; }
    }
}

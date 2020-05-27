using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor;

namespace SyncfusionWasmLocalization.Shared
{
    public class SyncfusionLocalizer : ISyncfusionStringLocalizer
    {
        // To get the locale key from mapped resources file
        public string Get(string key)
        {
            return this.Manager.GetString(key);
        }

        // To access the resource file and get the exact value for locale key

        public System.Resources.ResourceManager Manager
        {
            get
            {
                // Replace the ApplicationNamespace with your application name.
                return SyncfusionWasmLocalization.Resources.SfResources.ResourceManager;
            }
        }
    }
}

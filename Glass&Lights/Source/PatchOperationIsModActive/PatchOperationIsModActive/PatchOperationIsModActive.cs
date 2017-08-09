using System.Linq;
using System.Xml;
using Verse;

namespace PatchOperationIsModActive
{
    internal class PatchOperationIsModActive : PatchOperation
    {
        private string mod;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if(mod.NullOrEmpty())
            {
                return false;
            }

            return ModsConfig.ActiveModsInLoadOrder.Any(activeMod => activeMod.Name == mod);
        }
    }
}

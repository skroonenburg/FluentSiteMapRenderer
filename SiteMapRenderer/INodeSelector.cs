using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteMapRenderer
{
    public interface INodeSelector
    {
        IEnumerable<MvcSiteMapNode> SelectNodes(MvcSiteMapNode rootNode);
    }
}

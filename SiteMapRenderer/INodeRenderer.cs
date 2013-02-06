using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MvcSiteMapProvider;

namespace SiteMapRenderer
{
    public interface INodeRenderer
    {
        IHtmlString Render(MvcSiteMapNode node);
    }
}

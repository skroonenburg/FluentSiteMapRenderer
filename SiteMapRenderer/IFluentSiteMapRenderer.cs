using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SiteMapRenderer
{
    public interface IFluentSiteMapRenderer : IHtmlString
    {
        IIncludeConfigurer Include { get; }
        IRenderConfigurer Render { get; }
        INodesConfigurer Nodes { get; }
    }

}

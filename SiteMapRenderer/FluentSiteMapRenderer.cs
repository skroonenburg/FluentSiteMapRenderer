using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteMapRenderer
{
    public class FluentSiteMapRenderer : IFluentSiteMapRenderer
    {
        public string ToHtmlString()
        {
            throw new NotImplementedException();
        }

        public IIncludeConfigurer Include
        {
            get { throw new NotImplementedException(); }
        }

        public IRenderConfigurer Render
        {
            get { throw new NotImplementedException(); }
        }

        public INodesConfigurer Nodes
        {
            get { throw new NotImplementedException(); }
        }
    }
}

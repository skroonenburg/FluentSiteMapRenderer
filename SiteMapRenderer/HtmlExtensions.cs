using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteMapRenderer
{
    public class HtmlExtensions
    {
        public IFluentSiteMapRenderer SiteMap()
        {
            return new FluentSiteMapRenderer();
        }
    }
}

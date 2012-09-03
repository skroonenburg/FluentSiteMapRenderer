FluentSiteMapRenderer
=====================

An extensible utility that makes it simple and easy to render MVC site map structures to HTML.

The rendering process works in 3 stages:

 1.  Node selection: select the nodes from the site map tree that will be rendered to HTML. 
 2. Site Map Rendering: The site map is rendered to HTML, in a form defined by the site map renderer.
 3. Node Rendering: Each site map node is rendered to HTML, in a form defined by the node renderer.

### Interfaces

Any class implementing the interfaces below, can be plugged into the renderer to provide this functionality:

    public interface INodeSelector
    {
        IEnumerable<MvcSiteMapNode> SelectNodes(MvcSiteMapNode rootNode);
    }

    public interface ISiteMapRenderer
    {
        IHtmlString Render(MvcSiteMapNode rootNode, IEnumerable<MvcSiteMapNode> nodesToRender)
    }

    public interface INodeRenderer
    {
        IHtmlString Render(MvcSiteMapNode node)
    }

### Basic usage
    @Html.SiteMap(INodeSelector nodeSelector, ISiteMapRenderer siteMapRenderer, INodeRenderer nodeRenderer)

    eg.
    @Html.SiteMap(AllNodes.ToDepth(3), Render.AsList, Nodes.AsLinks)

### Fluent usage

    @Html.SiteMap()
        .Include.AllNodes.ToDepth(3)   // configures an “AllNode” INodeSelector
        .Render.AsList // configures a “ListSiteMapRenderer” ISiteMapRenderer
        .Nodes.AsLinks // configures a “LinkNodeRenderer”

Out of the box
--------------

The system is designed to be completely extensible. Some basic renderers and selectors are provided out of the box:

Selectors:
  - AllNodesToDepthSelector
  - AllNodesSelector
  - RootToCurrentNodePath

Site Map Renderers
  - ListRenderer (renders tree as a series of <ul><li> statements)
  - GridRenderer (renders nodes as a grid)

Node Renderers:
  - LinkRenderer (renders nodes a hypertext links)
  - ImageRenderer (renders nodes as image-links)

 


                 

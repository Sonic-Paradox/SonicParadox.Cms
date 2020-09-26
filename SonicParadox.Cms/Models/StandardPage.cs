using Piranha.AttributeBuilder;
using Piranha.Models;

namespace SonicParadox.Cms.Models
{
    [PageType(Title = "Standard page")]
    [PageTypeRoute(Title = "Default", Route = "/page")]
    [PageTypeRoute(Title = "Wide Content", Route = "/page/wide")]
    public class StandardPage : Page<StandardPage>
    {
    }
}
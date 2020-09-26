using Piranha.Extend;

namespace SonicParadox.Blocks.Creations
{
    [BlockGroupType(Name = "Creation Carousel", Category = "Creations", Icon = "fas fa-th-large")]
    [BlockItemType(Type = typeof(CreationBlock))]
    public class CarouselBlock : BlockGroup
    {
        public override string GetTitle() => "Creation Carousel";
    }
}

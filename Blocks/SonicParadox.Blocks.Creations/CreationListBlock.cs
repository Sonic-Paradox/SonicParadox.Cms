using Piranha.Extend;
using Piranha.Extend.Fields;

namespace SonicParadox.Blocks.Creations
{
    [BlockGroupType(Name = "Creation List", Category = "Creations", Icon = "fas fa-stream")]
    [BlockItemType(Type = typeof(CreationBlock))]
    public class CreationListBlock : BlockGroup
    {
        public StringField Title { get; set; }

        [Field(Title = "Tile Size")]
        public SelectField<TileSizes> TileSize { get; set; }

        public enum TileSizes
        {
            Large,
            Small
        }
    }
}

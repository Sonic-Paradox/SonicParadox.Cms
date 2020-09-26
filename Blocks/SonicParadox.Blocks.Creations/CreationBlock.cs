using Piranha.Extend;
using Piranha.Extend.Fields;

namespace SonicParadox.Blocks.Creations
{
    [BlockType(Name = "Creation", Category = "Creations", Icon = "fas fa-film")]
    public class CreationBlock : Block
    {
        public StringField Title { get; set; }
        public StringField Description { get; set; }
        public ImageField Image { get; set; }

        // not doing a list for URLs because CMS does not support nested groups
        [Field(Title="YouTube URL")]
        public StringField YoutubeUrl { get; set; }

        [Field(Title = "Newgrounds URL")]
        public StringField NewgroundsUrl { get; set; }

        public override string GetTitle() => Title;
    }
}

using Piranha.Extend;
using Piranha.Extend.Fields;

namespace SonicParadox.Blocks.Staff
{
    [BlockType(Name = "Staff Member", Category = "People", Icon = "fas fa-user")]
    public class StaffBlock : Block
    {
        [Field(Title = "Display Name")]
        public StringField DisplayName { get; set; }

        public ImageField Avatar { get; set; }

        public MarkdownField Biography { get; set; }

        [Field(Title = "Accent Color")]
        public StringField AccentColor { get; set; }

        public override string GetTitle() => DisplayName;
    }
}

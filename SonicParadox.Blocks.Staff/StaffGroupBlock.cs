using Piranha.Extend;
using Piranha.Extend.Fields;

namespace SonicParadox.Blocks.Staff
{
    [BlockGroupType(Name = "Staff Group", Category = "People", Icon = "fas fa-users")]
    [BlockItemType(Type = typeof(StaffBlock))]
    public class StaffGroupBlock : BlockGroup
    {
        public StringField Label { get; set; }

        public override string GetTitle() => Label;
    }
}

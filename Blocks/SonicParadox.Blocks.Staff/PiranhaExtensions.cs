using Piranha.Runtime;

namespace SonicParadox.Blocks.Staff
{
    public static class PiranhaExtensions
    {
        public static void AddStaffBlocks(this AppBlockList blockList)
        {
            blockList.Register<StaffBlock>();
            blockList.Register<StaffGroupBlock>();
        }
    }
}

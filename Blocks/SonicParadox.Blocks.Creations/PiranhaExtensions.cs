using Piranha.Runtime;

namespace SonicParadox.Blocks.Creations
{
    public static class PiranhaExtensions
    {
        public static void AddCreationBlocks(this AppBlockList blockList)
        {
            blockList.Register<CreationBlock>();
            blockList.Register<CarouselBlock>();
            blockList.Register<CreationListBlock>();
        }
    }
}

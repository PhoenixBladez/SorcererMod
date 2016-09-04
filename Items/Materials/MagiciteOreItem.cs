using Terraria.ID;
using Terraria.ModLoader;

namespace SorcererMod.Items.Materials
{
    public class MagiciteOreItem : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Magicite Ore";
            item.width = 16; item.height = 14;
            item.maxStack = 999;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.value = 50;
            item.rare = 2;
            item.createTile = mod.TileType("MagiciteOre");
        }
    }
}

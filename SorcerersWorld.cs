using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System.Linq;

namespace SorcererMod
{
    public class SorcerersWorld : ModWorld
    {
		public static bool Magicite = false;
 public override void Initialize()
        {
            if (NPC.downedBoss1 == true)
            {
                Magicite = true;
            }
            else
            {
                Magicite = false;
            }
		}
        public override void PostUpdate() 
	{
            if (NPC.downedBoss1 == true)
            {
			if (Magicite == false)
			{
			Magicite = true;
			Main.NewText("Magicite has graced your land", Color.Orange.R, Color.Orange.G, Color.Orange.B);
			for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * (6E-05) / 2); k++)
					{
						WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY), (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("MagiciteOre"), false, 0f, 0f, false, true);
					}
    }  
}  

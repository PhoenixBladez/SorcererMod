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

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1)
			{
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Example Mod Ores", delegate (GenerationProgress progress)
				{
					progress.Message = "Adding magicite";

					for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
					{
						WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY), (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("MagiciteOre"), false, 0f, 0f, false, true);
					}
				}));
			}

        } 
    }  
}  

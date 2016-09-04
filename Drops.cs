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
    class Drops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            { // I don't know if this is necessary, but i won't remove it just in case - Voxel
                if (npc.type == NPCID.ZombieEskimo)
                {
                    if (Main.rand.Next(8) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Snowflake"), 1);
                    }
                } 

                if (npc.type == NPCID.GoblinSorcerer && Main.hardMode)
                {
                    if (Main.rand.Next(10) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ShadowflameStaff"), 1);
                    }
                    if (Main.rand.Next(15) == 2)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ShadowflameBook"), 1);
                    }
                }
                
                //Gen for Magicite ore :P
                if (npc.type == NPCID.EyeofCthulhu)
                {
                    Main.NewText("A Magic Aura spreads through the land", 219, 68, 227);
                    for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
                    {
                        WorldGen.OreRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY), (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("MagiciteOre"));
                    }
                }


                //seperating to make it easier to see - Voxel

            } 
        } // End of NPCLoot - Voxel
    } // End of Class
} // End of Script

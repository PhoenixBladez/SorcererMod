using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SorcererMod
{
    class Drops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            {
                if (npc.type == NPCID.ZombieEskimo)
                {
                    if (Main.rand.Next(8) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Snowflake"), 1);
                    }
                }
            }
        }
    }
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

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
                /* Just doing this until i fix it
                if (npc.type == NPCID.GoblinSorcerer && main.hardMode) // IDK IF THIS IS CORRECT, CHANGE LATER - Voxel
                {
                    if (Main.rand.Next(10) == 1)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.postition.Y, npc.width, npc.height, mod.ItemType("ShadowflameStaff"), 1);
                    }
                    if (Main.rand.Next(15) == 2)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ShadowflameBook"), 1);
                    }
                }
                */
                
                
                //seperating to make it easier to see - Voxel

            } 
        } // End of NPCLoot - Voxel
    } // End of Class
} // End of Script
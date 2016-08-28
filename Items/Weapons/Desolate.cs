using Terraria;
using System;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace SorcererMod.Items.Weapons
{
    public class Desolate : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Desolation"; //slightly changed the name :P
            item.damage = 17;
            item.magic = true;
            item.mana = 15;
            item.width = 46;
            item.height = 46;
            item.useTime = 7;
            item.useAnimation = 27;
            item.useStyle = 5;
            Item.staff[item.type] = true;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 20000;
            item.rare = 3;
            item.useSound = 34;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("Sandstorm");
            item.shootSpeed = 20f;
            item.toolTip = "Fires a sandstorm at your enemies";
            item.autoReuse = true;
        }
        

        public override void AddRecipes()
        {
            //UUUHHHHH
        }
    }
}

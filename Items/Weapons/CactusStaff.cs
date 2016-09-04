using Terraria;
using System;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace SorcererMod.Items.Weapons
{
    public class CactusStaff : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cactus Staff"; 
            item.damage = 9;
            item.magic = true;
            item.mana = 11;
            item.width = 40;
            item.height = 40;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 5;
            Item.staff[item.type] = true;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 20000;
            item.rare = 3;
            item.useSound = 34;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("CactusProj");
            item.shootSpeed = 8f;
            item.toolTip = "Shoot a slow, thorny Cactus Ball at foes!";
            item.autoReuse = false;
        }


      public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cactus, 22);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}

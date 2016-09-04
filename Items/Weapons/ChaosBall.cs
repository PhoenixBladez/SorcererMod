using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace SorcererMod.Items.Weapons
{
	public class ChaosBall : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "The Chaos Ball";
			item.damage = 16;
			item.magic = true;
			item.mana = 11;
			item.width = 28;
			item.height = 30;
			item.toolTip = "Shoots an Orb of Chaos.";
			item.useTime = 24;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 19000;
			item.rare = 2;
			item.useSound = 8;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("ChaosBall");
			item.shootSpeed = 14f;
		}
	}
}
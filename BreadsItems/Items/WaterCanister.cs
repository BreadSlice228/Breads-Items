using System;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace BreadsItems.Items
{
	public class WaterCanister : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("dababysword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Makes guns shoot water instead of bullets");
		}

		public override void SetDefaults()
		{
			item.damage = 0;
			item.width = 40;
			item.height = 40;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 358;
			item.ranged = true;
			item.ammo = AmmoID.Bullet;
			item.consumable = false;
			item.maxStack = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WaterGun);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		
	}

}

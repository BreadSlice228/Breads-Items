using System;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace BreadsItems.Items
{
	public class P90 : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Gun go brrrrrrrrrrr");
		}

		public override void SetDefaults()
		{
			item.damage = 20; 
			item.ranged = true; 
			item.width = 42;
			item.height = 30;
			item.useTime = 3; 
			item.useAnimation = 3; 
			item.useStyle = ItemUseStyleID.HoldingOut; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 10000; 
			item.rare = -12; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 14;
			item.shootSpeed = 20;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Handgun, 2);
			recipe.AddIngredient(ItemID.DirtBlock, 228);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .50f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}
	}
}
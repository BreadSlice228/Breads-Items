using System;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace BreadsItems.Items
{
	public class Recipes : ModItem
	{
		// Other methods and fields here...

		public override void AddRecipes()
		{
			// Here is an example of a recipe.
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronOre, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(97,5);
			recipe.AddRecipe();

			/* // Here we reuse 'recipe', meaning we don't need to re-declare that it is a ModRecipe 
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.BlueBerries, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.PumpkinPie, 2);
			recipe.AddRecipe(); */
		}
	}
}
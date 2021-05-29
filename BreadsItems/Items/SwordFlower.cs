using Terraria.ID;
using Terraria.ModLoader;

namespace BreadsItems.Items
{
	public class SwordFlower : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("dababysword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() 
		{
			item.damage = 8;
			item.melee = true;
			item.width = 48;
			item.height = 46;
			item.useTime = 20;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 300;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sunflower, 5);
			recipe.AddIngredient(ItemID.WoodenSword, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
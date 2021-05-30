using Terraria.ID;
using Terraria.ModLoader;

namespace BreadsItems.Items
{
	public class Hammer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("dababysword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Makes more sense in hardmode");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
			item.ranged = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 300;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.shoot = 14;
			item.shootSpeed = 5;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 8);
			recipe.AddIngredient(ItemID.StoneBlock, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
using Terraria.ID;
using Terraria.ModLoader;

namespace MaxwelliumMod.Items
{
	public class theWeapon : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Maxwellium Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("seems incomplete...");
		}

		public override void SetDefaults() 
		{
			item.damage = 500000;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<MaxwelliumIngot>(), 15);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
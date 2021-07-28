using Terraria.ID;
using Terraria.ModLoader;

namespace MaxwelliumMod.Items
{
	class MaxwelliumIngot : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Doesn't seem fully real");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
		}
	}
}
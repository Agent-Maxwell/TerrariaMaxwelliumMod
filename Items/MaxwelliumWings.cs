using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MaxwelliumMod.Items
{
    [AutoloadEquip(EquipType.Wings)]
    public class MaxwelliumWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault(""); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("lighter than air");
        }

        public override bool Autoload(ref string name)
        {
            return true;
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 100;
            item.rare = ItemRarityID.Green;
            item.accessory = true;
        }

        
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 200;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.135f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 9f;
            acceleration *= 2.5f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
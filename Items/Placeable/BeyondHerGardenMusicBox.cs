using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Utilities;

namespace MLPMusicBoxes.Items.Placeable
{
	public class BeyondHerGardenMusicBox : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Music Box (Beyond Her Garden)");
		}
        public override bool? PrefixChance(int pre, UnifiedRandom rand)
        {
			return false;
        }
        public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.BeyondHerGardenMusicBox>();
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Green;
			item.value = 100000;
			item.accessory = true;
		}


            public override void AddRecipes()
		    {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DayBloomPlanterBox, 1);
			recipe.AddIngredient(ItemID.MoonglowPlanterBox, 1);
			recipe.AddIngredient(ItemID.BlinkrootPlanterBox, 1);
			recipe.AddIngredient(ItemID.WaterleafPlanterBox, 1);
			recipe.AddIngredient(ItemID.ShiverthornPlanterBox, 1);
			recipe.AddIngredient(ItemID.FireBlossomPlanterBox, 1);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}

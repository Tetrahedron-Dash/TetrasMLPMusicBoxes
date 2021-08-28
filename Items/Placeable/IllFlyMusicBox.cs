using Terraria.ModLoader;
using Terraria.ID;
using System;
using Terraria.Utilities;

namespace MLPMusicBoxes.Items.Placeable
{
	public class IllFlyMusicBox : ModItem
	{
        public override bool? PrefixChance(int pre, UnifiedRandom rand)
        {
			return false;
        }
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (I'll Fly)");
		}

        public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.IllFlyMusicBox>();
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Expert;
			item.value = 100000;
			item.accessory = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 14);
			recipe.AddIngredient(ItemID.SoulofFlight, 10);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
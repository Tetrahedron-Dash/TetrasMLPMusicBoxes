using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Utilities;

namespace MLPMusicBoxes.Items.Placeable
{
	public class ShatterCurseOfPinkamenaMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Shatter, Curse of Pinkamena)");
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
			item.createTile = ModContent.TileType<Tiles.ShatterCurseOfPinkamenaMusicBox>();
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Red;
			item.value = 100000;
			item.accessory = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PsychoKnife, 1);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

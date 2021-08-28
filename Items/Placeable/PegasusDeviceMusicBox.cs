using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Utilities;

namespace MLPMusicBoxes.Items.Placeable
{
	public class PegasusDeviceMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Pegasus Device)");
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
			item.createTile = ModContent.TileType<Tiles.PegasusDeviceMusicBox>();
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Expert;
			item.value = 100000;
			item.accessory = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.OutletPump, 6);
			recipe.AddIngredient(ItemID.YellowDye, 1);
			recipe.AddIngredient(ItemID.OrangeDye, 1);
			recipe.AddIngredient(ItemID.RedDye, 1);
			recipe.AddIngredient(ItemID.GreenDye, 1);
			recipe.AddIngredient(ItemID.BlueDye, 1);
			recipe.AddIngredient(ItemID.PurpleDye, 1);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

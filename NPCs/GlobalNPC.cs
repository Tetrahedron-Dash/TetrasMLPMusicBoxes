using MLPMusicBoxes.Items;
using MLPMusicBoxes.Items.Placeable;
using MLPMusicBoxes.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MLPMusicBoxes.NPCs
{
	public class TetrasGlobalNPC : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (type == NPCID.Mechanic)
			{
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Placeable.AnthropologyMusicBox>());
				nextSlot++;

				// We can use shopCustomPrice and shopSpecialCurrency to support custom prices and currency. Usually a shop sells an item for item.value. 
				// Editing item.value in SetupShop is an incorrect approach.

				// shop.item[nextSlot].shopCustomPrice = 2;
				// shop.item[nextSlot].shopSpecialCurrency = CustomCurrencyID.DefenderMedals; // omit this line if shopCustomPrice should be in regular coins. 
			}

			if (Main.dayTime)
				if (type == NPCID.Steampunker)
				{
					shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Placeable.IllFlyMusicBox>());
					nextSlot++;
				}

			if (Main.bloodMoon)
				if (type == NPCID.Steampunker)
				{
					shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Placeable.RainbowFactoryMusicBox>());
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Placeable.PegasusDeviceMusicBox>());
					nextSlot++;
				}

			if (Main.dayTime)
				if (type == NPCID.PartyGirl)
				{
					shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Placeable.SmileFoozogzRemixMusicBox>());
					nextSlot++;
				}

			if (Main.bloodMoon)
				if (type == NPCID.PartyGirl)	
				{
				    shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Placeable.ShatterCurseOfPinkamenaMusicBox>());
				    nextSlot++;    
			    }

		}
    }
}

using Terraria;
using Terraria.ModLoader;

namespace MLPMusicBoxes
{
	public class MLPMusicBoxes : Mod
	{
		public override void Load()
		{
			if (!Main.dedServ)
			{
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/RainbowFactoryMusicBox"), ItemType("RainbowFactoryMusicBox"), TileType("RainbowFactoryMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BeyondHerGardenMusicBox"), ItemType("BeyondHerGardenMusicBox"), TileType("BeyondHerGardenMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/IllFlyMusicBox"), ItemType("IllFlyMusicBox"), TileType("IllFlyMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AnthropologyMusicBox"), ItemType("AnthropologyMusicBox"), TileType("AnthropologyMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ShatterCurseOfPinkamenaMusicBox"), ItemType("ShatterCurseOfPinkamenaMusicBox"), TileType("ShatterCurseOfPinkamenaMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/PegasusDeviceMusicBox"), ItemType("PegasusDeviceMusicBox"), TileType("PegasusDeviceMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SmileFoozogzRemixMusicBox"), ItemType("SmileFoozogzRemixMusicBox"), TileType("SmileFoozogzRemixMusicBox"));
			}
		}
	}
}
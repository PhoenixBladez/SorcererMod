using Terraria.ModLoader;

namespace SorcerersMod
{
	class SorcerersMod : Mod
	{
		public SorcerersMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}

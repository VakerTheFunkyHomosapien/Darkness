using Terraria.ModLoader;

namespace Darkness
{
	class Darkness : Mod
	{
		public Darkness()
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

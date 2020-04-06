﻿using TaleWorlds.Library;
using TaleWorlds.TwoDimension;

namespace Aragas
{
    public static class SpriteDataFactory
	{
		public static SpriteData CreateNewFromModule(string name, ResourceDepot resourceDepot)
		{
			var spriteData = new SpriteData(name);
			spriteData.Load(resourceDepot);
			foreach (var spriteCategory in spriteData.SpriteCategories)
				spriteCategory.Value.LoadFromModules(resourceDepot);
			return spriteData;
		}
	}
}
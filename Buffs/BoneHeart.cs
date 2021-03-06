﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ForgottenMemories.Buffs
{
	public class BoneHeart : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Carnivorous Aura");
			Description.SetDefault("Increased life regenation");
			//Main.buffNoTimeDisplay[Type] = true;
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			player.lifeRegen += 4;
		}
	}
}
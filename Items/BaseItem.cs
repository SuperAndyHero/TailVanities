using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using TailLib;
using TailVanities.Tails;
using System;

namespace TailVanities.Items
{
    public abstract class BaseVanityItem : TailItem
    {
        protected BaseVanityItem(Type tailType) : base(tailType) { }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(0, 0, 10, 0);
            Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
        }
    }
}
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using TailLib;
using TailVanities.Tails;

namespace TailVanities.Items
{
    public class FoxVanityBlankOrangeItem : TailItem
    {
        public FoxVanityBlankOrangeItem() : base(typeof(FoxVanityOrange)) { }

        //public override string Texture => "TailVanities/Tails/FoxBlankOrange";
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = 1000;
            Item.accessory = true;
            Item.rare = ItemRarityID.Green;
        }
    }
}
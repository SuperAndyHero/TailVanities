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
    public class FoxTailVanilla1Item : TailItem
    {
        public FoxTailVanilla1Item() : base(typeof(FoxTailVanilla1)) { }

        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Fox Tail");
            // Tooltip.SetDefault("This can be equiped on your player");
        }
        public override string Texture => "TailVanities/Tails/FoxVanilla1";

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
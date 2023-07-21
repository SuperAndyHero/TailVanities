using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using TailLib;
using Terraria;
using Terraria.ModLoader;

namespace TailVanities.Tails
{
    public class FoxVanillaTail : DogVanillaTail
    {
        public override string Texture => "TailVanities/Tails/FoxVanilla";
        public override bool PreUpdate()
        {
            tailInstance.TailWobble(3, 4, 0.025f, 0.14f, 0.30f, 0.50f, 0, 1);//wobbles the tail when idle or running
            return true;
        }
    }
}

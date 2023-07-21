using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using TailLib;
using Terraria;
using Terraria.ModLoader;

namespace TailVanities.Tails
{
    public class LizardVanillaTail : Tailbase
    {
        public override string Texture => "TailVanities/Tails/LizardVanilla";
        public override Vector2 WorldOffset => new Vector2(9.6f, 11.4f);
        public override bool PreUpdate()
        {
            //tailInstance.TailWobble(3, 4, 0.03f, 0.14f, 0.35f, 0.55f);//wobbles the tail when idle or running
            return true;
        }

        public override float Width => 6f;
        public override Vector2 TexPosOffset => new Vector2(-7.450581f, -6.850011f);
        public override Vector2 TexSizeOffset => new Vector2(1.3000002f, 6.8999977f);
        public override int PhysicsRepetitions => 5;
        public override float VertexDrag => 1.15f;
        public override int VertexCount => 4;
        public override float[] VertexDistances => new float[] {
            5.82f,
            5.90028f,
            7.82039f,
            7.5857787f,0f
        };
        public override Vector2[] VertexGravityForces => new Vector2[] {
            new Vector2(0f, 0f),
            new Vector2(0.30955127f, -0.3757273f),
            new Vector2(0.9791489f, -0.20314376f),
            new Vector2(0.858299f, 0.5131497f)
        };
        public override Vector2[] SettledPoints => new Vector2[] {
            new Vector2(0f, 0f),
            new Vector2(5.9875793f, 0.0075821355f),
            new Vector2(11.875526f, 1.0292786f),
            new Vector2(18.721209f, 4.8101697f)
        };

    }
}

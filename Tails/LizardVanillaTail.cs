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
        public override Vector2 WorldOffset => new Vector2(2f, 11.2f);
        public override Vector2 DrawMenuOffset() => new Vector2(5f, 7f);
        public override bool PreUpdate()
        {
            //tailInstance.TailWobble(3, 4, 0.03f, 0.14f, 0.35f, 0.55f);//wobbles the tail when idle or running
            return true;
        }

        public override float Width => 6f;
        public override Vector2 TexPosOffset => new Vector2(-0.049999993f, -6.5000067f);
        public override Vector2 TexSizeOffset => new Vector2(0.5500001f, 6.5f);
        public override int PhysicsRepetitions => 5;
        public override float VertexDrag => 1.15f;
        public override int VertexCount => 5;
        public override float[] VertexDistances => new float[] {
            6.2361274f,
            4.7728934f,
            4.5107613f,
            4.164102f,
            4.0391793f
        };
        public override Vector2[] VertexGravityForces => new Vector2[] {
            new Vector2(0f, 0f),
            new Vector2(1.1716537f, -0.2223282f),
            new Vector2(0.66171914f, -0.22827977f),
            new Vector2(0.65638757f, 0.24321863f),
            new Vector2(0.6375457f, 0.28902507f)
        };
        public override Vector2[] SettledPoints => new Vector2[] {
            new Vector2(0f, 0f),
            new Vector2(6.4927273f, 0.33783394f),
            new Vector2(11.377643f, 1.17394f),
            new Vector2(15.688381f, 2.7898016f),
            new Vector2(19.492243f, 4.484022f)
        };

    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using TailLib;
using Terraria;
using Terraria.ModLoader;

namespace TailVanities.Tails
{
    public class DogVanillaTail : Tailbase
    {
        public override string Texture => "TailVanities/Tails/DogVanilla";
        public override Vector2 WorldOffset => new Vector2(1.8f, 11.4f);
        public override bool PreUpdate()
        {
            tailInstance.TailWobble(3, 4, 0.06f, 0.16f, 0.4f, 0.65f, 0, 1);//wobbles the tail when idle or running
            return true;
        }

        public override float Width => 6f;
        public override Vector2 TexPosOffset => new Vector2(0f, -2.9999976f);
        public override Vector2 TexSizeOffset => new Vector2(-2.5500145f, 3.049983f);
        public override int PhysicsRepetitions => 5;
        public override float VertexDrag => 1.15f;
        public override int VertexCount => 4;
        public override float[] VertexDistances => new float[] {
            5.90028f,
            6.79f,
            9.74838f,
            9.455929f
        };
        public override Vector2[] VertexGravityForces => new Vector2[] {
            new Vector2(0f, 0f),
            new Vector2(0.62052584f, 0.5855344f),
            new Vector2(0.99721587f, 0.06364711f),
            new Vector2(0.99460083f, -0.1037737f)
        };
        public override Vector2[] SettledPoints => new Vector2[] {
            new Vector2(0f, 0f),
            new Vector2(6.00711f, 1.0006362f),
            new Vector2(12.892311f, 1.0021975f),
            new Vector2(22.595469f, 0.0643146f)
        };
    }
}

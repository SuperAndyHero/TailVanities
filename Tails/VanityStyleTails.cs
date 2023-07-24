using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using TailLib;
using Terraria;
using Terraria.ModLoader;

namespace TailVanities.Tails
{
	public class FoxVanity1 : Tailbase
	{
		public override string Texture => "TailVanities/Tails/FoxVanity1";
		public override Vector2 WorldOffset => new Vector2(4f, 11.4f);
        public override Vector2 DrawMenuOffset() => new Vector2(0f, 1f);
        public override bool PreUpdate()
		{
			tailInstance.TailWobble(4, 5, 0.03f, 0.14f, 0.35f, 0.55f);//wobbles the tail when idle or running
			return true;
		}

        public override float Width => 6.75f;
        public override Vector2 TexPosOffset => new Vector2(0f, 0.8f);
        public override Vector2 TexSizeOffset => new Vector2(7f, -6.2f);
        public override int PhysicsRepetitions => 5;
        public override float VertexDrag => 1.15f;
        public override int VertexCount => 5;
        public override float[] VertexDistances => new float[] {
            4.946049f,
            4.8500004f,
            5.22361f,
            7.76f,
            7.5272f
        };
        public override Vector2[] VertexGravityForces => new Vector2[] {
            new Vector2(0f, 0f),
            new Vector2(0.10327351f, 0.9944664f),
            new Vector2(0.99490136f, 0.10085311f),
            new Vector2(0.5456603f, -0.29667327f),
            new Vector2(-0.027497524f, -0.99927276f)
        };
        public override Vector2[] SettledPoints => new Vector2[] {
            new Vector2(0f, 0f),
            new Vector2(4.98464f, -1.0504558f),
            new Vector2(8.862024f, -4.116146f),
            new Vector2(10.953056f, -8.951566f),
            new Vector2(11.001067f, -16.711418f)
        };
	}

    public class FoxVanity2 : FoxVanity1
    {
        public override string Texture => "TailVanities/Tails/FoxVanity2";
    }

    public class FoxVanityBlank: FoxVanity1
    {
        public override string Texture => "TailVanities/Tails/FoxBlank";
    }

    public class FoxVanityOrange : FoxVanity1
    {
        public override string Texture => "TailVanities/Tails/FoxBlankOrange";
    }
}

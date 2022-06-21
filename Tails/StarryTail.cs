using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using TailLib;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace TailVanities.Tails
{
    public class StarryTail : Tailbase
	{
		public override string Texture => "TailVanities/Tails/Starry";
		public override Vector2 WorldOffset => new Vector2(4f, 11.2f);

        public override void DrawSprites(SpriteBatch spriteBatch)
        {
			Vector2 pos = tailInstance.tailBones.ropeSegments[tailInstance.tailBones.segmentCount - 1].ScreenPos;
			Vector2 beforeSegPos = tailInstance.tailBones.ropeSegments[tailInstance.tailBones.segmentCount - 2].ScreenPos;
			Texture2D startex = ModContent.Request<Texture2D>("TailVanities/Tails/StarryOverlay").Value;
			spriteBatch.Draw(startex, pos, null, Lighting.GetColor((tailInstance.tailBones.ropeSegments[tailInstance.tailBones.segmentCount - 1].posNow / 16).ToPoint()), (pos - beforeSegPos).ToRotation() + ((float)Math.PI / 2), startex.Size() / 2, 1f, SpriteEffects.None, 0);
		}

		public override Vector2 DrawMenuOffset() => new Vector2(0, -4);

        public override void PostDrawMenuLayer(ref PlayerDrawSet drawInfo)
        {
			Texture2D tex = ModContent.Request<Texture2D>("TailVanities/Tails/StarryOverlay").Value;
			int frameSize = tex.Height / 20;
			var data = new DrawData(ModContent.Request<Texture2D>("TailVanities/Tails/StarryOverlay").Value, (drawInfo.Position + new Vector2(-9, 0)) - Main.screenPosition, null, Color.White, 0f, new Vector2(tex.Width, frameSize), 1f, SpriteEffects.FlipHorizontally, 0);
			drawInfo.DrawDataCache.Add(data);
        }

		public override bool PreUpdate()
		{
			tailInstance.TailWobble(5, 6, 0.05f, 0.2f, 0.1f, 0.12f);//wobbles the tail when idle or running
			return true;
		}          

		public override float Width => 4f;
		public override Vector2 TexPosOffset => new Vector2(0.10000022f, 4.0499973f);
		public override Vector2 TexSizeOffset => new Vector2(3.7999976f, -6.550007f);
		public override int PhysicsRepetitions => 5;
		public override float VertexDrag => 1.15f;
		public override int VertexCount => 6;
		public override float[] VertexDistances => new float[] {
			5.7599998f,
			6.0715733f,
			10.861159f,
			6.0715733f,
			8.639999f,
			8.294399f
		};
		public override Vector2[] VertexGravityForces => new Vector2[] {
			new Vector2(0f, 0f),
			new Vector2(1.5466869f, 1.7184784f),
			new Vector2(1.0931467f, 1.0542159f),
			new Vector2(1.5930313f, 0.3044483f),
			new Vector2(0.58829015f, -1.4332834f),
			new Vector2(0f, -1f)
		};
		public override Vector2[] SettledPoints => new Vector2[] {
			new Vector2(0f, -2f),
			new Vector2(6.1655116f, -2.0931141f),
			new Vector2(12.1364565f, -4.257334f),
			new Vector2(19.996664f, -12.002435f),
			new Vector2(21.909042f, -17.859163f),
			new Vector2(22.12196f, -26.49654f)
		};

	}
}

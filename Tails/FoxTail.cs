using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using TailLib;
using Terraria;
using Terraria.ModLoader;

namespace TailVanities.Tails
{
	public class FoxTail : Tailbase
	{
		public override string Texture => "TailVanities/Tails/Fox";
		public override Vector2 WorldOffset => new Vector2(6f, 8f);
		public override bool PreUpdate()
		{
			tailInstance.TailWobble(4, 5, 0.02f, 0.12f, 0.4f, 0.7f);//wobbles the tail when idle or running
			return true;
		}


		public override float Width => 11f;
		public override Vector2 TexPosOffset => new Vector2(0.050000068f, 14.050035f);
		public override Vector2 TexSizeOffset => new Vector2(-0.20000006f, -17.550018f);
		public override int PhysicsRepetitions => 5;
		public override float VertexDrag => 1.15f;
		public override int VertexCount => 6;
		public override float[] VertexDistances => new float[] {
			13.193427f,
			3.9512355f,
			5.669648f,
			5.4659314f,
			6.0978513f,
			5.914916f
		};
		public override Vector2[] VertexGravityForces => new Vector2[] {
			new Vector2(0f, 0f),
			new Vector2(1.0747384f, 1.6861742f),
			new Vector2(1.0981346f, -1.0246823f),
			new Vector2(-0.2f, -1.4879577f),
			new Vector2(0.4420102f, -1.0715055f),
			new Vector2(0.9054507f, -0.22472635f)
		};
		public override Vector2[] SettledPoints => new Vector2[] {
			new Vector2(0f, -5f),
			new Vector2(11.046915f, -13.058338f),
			new Vector2(13.591928f, -16.565624f),
			new Vector2(16.425089f, -21.741806f),
			new Vector2(20.337051f, -25.6915f),
			new Vector2(26.148304f, -27.538967f)
		};

	}
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using TailLib;
using Terraria;
using Terraria.ModLoader;

namespace TailVanities.Tails
{
	public class SharkTail : Tailbase
	{
		public override string Texture => "TailVanities/Tails/Shark";
		public override Vector2 WorldOffset => new Vector2(0f, 10.2f);
		public override float Width => 13.55f;
		public override Vector2 TexPosOffset => new Vector2(0.05f, -10.1f);
		public override Vector2 TexSizeOffset => new Vector2(6.1f, 7.55f);
		public override int PhysicsRepetitions => 5;
		public override float VertexDrag => 1.15f;
		public override int VertexCount => 7;
		public override float[] VertexDistances => new float[] {
			8.705419f,
			7.4528837f,
			8.293268f,
			6.4278884f,
			7.0324454f,
			11.324571f,
			10.984834f
		};
		public override Vector2[] VertexGravityForces => new Vector2[] {
			new Vector2(0f, 0f),
			new Vector2(0.96063405f, -1.7434474f),
			new Vector2(0.8653022f, -0.3095753f),
			new Vector2(-0.2641413f, 1.3208505f),
			new Vector2(-0.33182666f, 1.0426755f),
			new Vector2(0.8806968f, -0.1934681f),
			new Vector2(0.7559079f, -0.79759157f)
		};
		public override Vector2[] SettledPoints => new Vector2[] {
			new Vector2(0f, 0f),
			new Vector2(8.7824f, -1.1105112f),
			new Vector2(15.48086f, 2.4651017f),
			new Vector2(21.270613f, 8.512114f),
			new Vector2(27.76228f, 8.7064905f),
			new Vector2(33.914516f, 5.226077f),
			new Vector2(41.85224f, -2.8509555f)
		};

	}
}

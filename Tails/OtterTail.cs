using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using TailLib;
using Terraria;
using Terraria.ModLoader;

namespace TailVanities.Tails
{
    public class OtterTail : Tailbase
    {
		public override string Texture => "TailVanities/Tails/Otter"; 
		public override Vector2 WorldOffset => new Vector2(3.2f, 9f);

		public override float Width => 7.6f;
		public override Vector2 TexPosOffset => new Vector2(0f, -19.2f);
		public override Vector2 TexSizeOffset => new Vector2(0.65f, 19.6f);
		public override int PhysicsRepetitions => 5;
		public override float VertexDrag => 1.15f;
		public override int VertexCount => 7;
		public override float[] VertexDistances => new float[] {
			7.1602583f,
			3.539209f,
			5.9074197f,
			5.4169865f,
			3.6722248f,
			7.023032f,
			6.60165f
		};
		public override Vector2[] VertexGravityForces => new Vector2[] {
			new Vector2(0f, 0f),
			new Vector2(2.0606093f, -1.4096066f),
			new Vector2(0.49598494f, -1.9916767f),
			new Vector2(-0.24141751f, 2.1603253f),
			new Vector2(1.1718491f, 1.8033143f),
			new Vector2(1f, -0.2f),
			new Vector2(0.75f, 0f)
		};
		public override Vector2[] SettledPoints => new Vector2[] {
			new Vector2(0f, 0f),
			new Vector2(7.5607786f, 1.5519595f),
			new Vector2(10.990831f, 3.6199331f),
			new Vector2(15.589871f, 7.8342505f),
			new Vector2(20.540297f, 10.4700575f),
			new Vector2(24.315166f, 10.634245f),
			new Vector2(31.338194f, 10.626539f)
		};

	}
}

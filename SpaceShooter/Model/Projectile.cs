﻿// Projectile.cs
//Using declarations
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter.Model
{
	public class Projectile
	{
		// Image representing the Projectile
		public Texture2D texture;
		// Position of the Projectile relative to the upper left side of the screen
		public Vector2 Position;
		// State of the Projectile
		public bool active;
		// The amount of damage the projectile can inflict to an enemy
		public int damage;
		// Represents the viewable boundary of the game
		Viewport viewport;


		// Image representing the Projectile
		private Texture2D Texture
		{
			get{ return texture; }
			set{ texture = value; }
		}


		// State of the Projectile
		private bool Active
		{
			get{ return active; }
			set{ active = value; }
		}

		// The amount of damage the projectile can inflict to an enemy
		private int Damage
		{
			get{ return damage; }
			set{ damage = value; }
		}


		// Get the width of the projectile ship
		public int Width
		{
			get { return Texture.Width; }
		}

		// Get the height of the projectile ship
		public int Height
		{
			get { return Texture.Height; }
		}

		// Determines how fast the projectile moves
		float projectileMoveSpeed;


		public void Initialize(Viewport viewport, Texture2D texture, Vector2 position)
		{
			Texture = texture;
			Position = position;
			this.viewport = viewport;

			Active = true;

			Damage = 2;

			projectileMoveSpeed = 20f;
		}

		public void Update()
		{
			// Projectiles always move to the right
			Position.X += projectileMoveSpeed;

			// Deactivate the bullet if it goes out of screen
			if (Position.X + Texture.Width / 2 > viewport.Width)
				Active = false;
		}

		public void Draw()
		{
		}
	}
}


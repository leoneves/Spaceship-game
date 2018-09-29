using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace LeoApp
{
    public class Asteroid
    {
		private Texture2D sprite;
		private Vector2 position = new Vector2(600, 300);
		private int speed;
		private const int radius = 58;
		private Vector2 image_size = new Vector2(114, 118);

		public Asteroid(int speed)
		{
			this.speed = speed;
		}

		public void AsteroidUPdate(GameTime gameTime)
		{
			float delta_time = (float)gameTime.ElapsedGameTime.TotalSeconds;
			float adjustment_speed = speed * delta_time;
			position.X -= adjustment_speed;
		}

		public Vector2 CenterPosition()
        {
            return new Vector2(position.X - image_size.X / 2, position.Y - image_size.Y / 2);
        }

		public Texture2D Sprite
		{
			get { return sprite; }
			set { sprite = value; }
		}

		public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}

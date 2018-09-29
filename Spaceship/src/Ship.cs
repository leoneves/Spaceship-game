using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace LeoApp
{
    public class Ship
    {
        private Vector2 position = new Vector2(100, 100);
        private Texture2D sprite;
        private const int speed = 180;
		private Vector2 image_size = new Vector2(68, 100);

        public void ShipUpdate(GameTime gameTime)
        {
            KeyboardState keyboard = Keyboard.GetState();
            float delta_time = (float)gameTime.ElapsedGameTime.TotalSeconds;
            float adjustment_speed = speed * delta_time;

            if (keyboard.IsKeyDown(Keys.Right))
            {
                position.X += adjustment_speed;
            }
            if (keyboard.IsKeyDown(Keys.Left)){
                position.X -= adjustment_speed;
            }
            if (keyboard.IsKeyDown(Keys.Down))
            {
                position.Y += adjustment_speed;
            }
            if (keyboard.IsKeyDown(Keys.Up))
            {
                position.Y -= adjustment_speed;
            }
        }

		public Vector2 CenterPosition()
		{
			return new Vector2(position.X - image_size.X/2, position.Y - image_size.Y/2);
		}

        public Vector2 Position
        {
            get { return position;  }
            set { position = value; }
        }

        public Texture2D Sprite
        {
            get { return sprite;  }
            set { sprite = value; }
        }

    }
}

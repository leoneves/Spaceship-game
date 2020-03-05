using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StoryBoardFlow;

namespace LeoApp
{
    public class Spaceship : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D space_sprite;

        SpriteFont game_font;
        SpriteFont timer_font;

        Ship player = new Ship();
		Asteroid asteroid = new Asteroid(250);

        public Spaceship()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = false;

            graphics.PreferredBackBufferWidth = 1024;
            graphics.PreferredBackBufferHeight = 720;
            MyClass story = new MyClass();
            story.update_new();
        }   

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            player.Sprite = Content.Load<Texture2D>("ship");
			asteroid.Sprite = Content.Load<Texture2D>("asteroid");
            space_sprite = Content.Load<Texture2D>("space");
            game_font = Content.Load<SpriteFont>("spaceFont");
            timer_font = Content.Load<SpriteFont>("timerFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            player.ShipUpdate(gameTime);
			asteroid.AsteroidUPdate(gameTime);
            // TODO: Add your update logic here			
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(texture: space_sprite, position: new Vector2(0, 0), color: Color.White);
			spriteBatch.Draw(player.Sprite, player.DrawPosition(), Color.White);
			spriteBatch.Draw(asteroid.Sprite, asteroid.DrawPosition(), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

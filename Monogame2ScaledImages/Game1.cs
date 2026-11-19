using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame2ScaledImages
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        SpriteFont TitleFont;
        Rectangle window;
        Texture2D circleTexture, rectangleTexture;
        Rectangle circleRect, topRect, halfRect, bottomRect, topCenterRect, centerCircleRect, horEye, horEye2, verEye, horPupil, horPupil2, verPupil, tent1, tent2, tent3, tent4;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            circleRect = new Rectangle(100, 100, 40, 40);
            topRect = new Rectangle(0, 0, window.Width, 15);
            halfRect = new Rectangle(0, 200, 400, 20);
            bottomRect = new Rectangle(0, 580, window.Width, 30);
            topCenterRect = new Rectangle(375, 0, 50, 50);
            centerCircleRect = new Rectangle(350, 250, 300, 300);
            horEye = new Rectangle(362, 370, 100, 50);
            horEye2 = new Rectangle(539, 370, 100, 50);
            verEye = new Rectangle(473, 265, 50, 100);
            horPupil = new Rectangle(406, 389, 10, 10);
            horPupil2 = new Rectangle(585, 389, 10, 10);
            verPupil = new Rectangle(493, 310, 10, 10);
            tent1 = new Rectangle(370, 430, 50, 150);
            tent2 = new Rectangle(435, 460, 50, 150);
            tent3 = new Rectangle(510, 460, 50, 150);
            tent4 = new Rectangle(570, 430, 50, 150);
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            TitleFont = Content.Load<SpriteFont>("text");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(rectangleTexture, new Rectangle(100, 100, 40, 40), Color.White);
            _spriteBatch.Draw(rectangleTexture, topRect, Color.Red);
            _spriteBatch.Draw(rectangleTexture, halfRect, Color.Blue);
            _spriteBatch.Draw(rectangleTexture, bottomRect, Color.Red);
            _spriteBatch.Draw(rectangleTexture, topCenterRect, Color.WhiteSmoke);
            _spriteBatch.Draw(circleTexture, centerCircleRect, Color.Gray);
            _spriteBatch.Draw(circleTexture, horEye, Color.Black);
            _spriteBatch.Draw(circleTexture, horEye2, Color.Black);
            _spriteBatch.Draw(circleTexture, verEye, Color.Black);
            _spriteBatch.Draw(circleTexture, horPupil, Color.White);
            _spriteBatch.Draw(circleTexture, horPupil2, Color.White);
            _spriteBatch.Draw(circleTexture, verPupil, Color.White);
            _spriteBatch.Draw(circleTexture, tent1, Color.Gray);
            _spriteBatch.Draw(circleTexture, tent2, Color.Gray);
            _spriteBatch.Draw(circleTexture, tent3, Color.Gray);
            _spriteBatch.Draw(circleTexture, tent4, Color.Gray);
            _spriteBatch.Draw(circleTexture, new Rectangle(100, 300, 40, 60), Color.IndianRed);
            _spriteBatch.Draw(circleTexture, circleRect, Color.DarkOliveGreen);
            _spriteBatch.DrawString(TitleFont, "Why did you listen?", new Vector2(300, 300), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

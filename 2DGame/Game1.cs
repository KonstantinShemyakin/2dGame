using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _2DGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private AnimatedSprite _char;
        private Texture2D _charTexture;
        private SpriteFont _font;
        private Character _character;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _charTexture = Content.Load<Texture2D>("SmileyWalk");
            _char = new AnimatedSprite(_charTexture, 4, 4, 60);
            _font = Content.Load<SpriteFont>("File");
            _character = new Character(new Vector2(300, 100), Content.Load<Texture2D>("spritestill"));
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _character.Update(gameTime.ElapsedGameTime.Milliseconds);
            // TODO: Add your update logic here
            //gameTime.ElapsedGameTime.

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _character.Draw(_spriteBatch);
            _spriteBatch.DrawString(_font, $"{gameTime.ElapsedGameTime.Milliseconds}", new Vector2(0f, 0f), Color.Black);
            _spriteBatch.DrawString(_font, $"{gameTime.TotalGameTime.Milliseconds}", new Vector2(0f, 50f), Color.Black);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
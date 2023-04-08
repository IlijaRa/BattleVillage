using BattleVillage.Source.Engine;
using BattleVillage.Source.GamePlay.Level1;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BattleVillage
{
    public class Main : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Level1 Level1;

        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            //_graphics.IsFullScreen = true;

            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals.ContentManager = this.Content;
            Globals.SpriteBatch = new SpriteBatch(GraphicsDevice);

            Globals.keyboard = new Source.Engine.Input.KeyboardHandmade();
            Level1 = new Level1();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Globals.keyboard.Update();

            Level1.Update();

            Globals.keyboard.UpdateOld();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.GreenYellow);

            Globals.SpriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);

            Level1.Draw();

            Globals.SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
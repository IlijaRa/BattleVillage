using BattleVillage.Source.Engine;
using BattleVillage.Source.Engine.Tanks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BattleVillage.Source.GamePlay.Level1
{
    public class Level1 : Level
    {
        public BasicTank BasicTank { get; set; }

        public FastTank FastTank { get; set; }

        public Level1() : base()
        {
            BasicTank = new BasicTank(new Vector2(300, 400), new Vector2(60, 60), @"tank_textures\\class1_tank\\gray_class1_texture");
            FastTank = new FastTank(new Vector2(500, 400), new Vector2(60, 60), @"tank_textures\\class1_tank\\gray_class1_texture");
        }

        public override void Update()
        {
            base.Update();
            BasicTank.Update();
            FastTank.Update();
        }

        public override void Draw()
        {
            SetStage();
            base.Draw();
            BasicTank.Draw();
            FastTank.Draw();
        }

        private void SetStage()
        {
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(64, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(64, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(64, 128), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(64, 160), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(64, 192), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(96, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(96, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(96, 128), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(96, 160), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(96, 192), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(192, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(192, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(192, 128), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(192, 160), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(192, 192), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(224, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(224, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(224, 128), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(224, 160), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(224, 192), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(320, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(320, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(320, 128), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(352, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(352, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(352, 128), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariostone_texture"), new Vector2(384, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariostone_texture"), new Vector2(384, 128), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariostone_texture"), new Vector2(416, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariostone_texture"), new Vector2(416, 128), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(448, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(448, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(448, 128), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(480, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(480, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(480, 128), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(576, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(576, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(576, 128), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(576, 160), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(576, 192), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(608, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(608, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(608, 128), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(608, 160), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(608, 192), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(704, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(704, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(704, 128), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(704, 160), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(704, 192), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(736, 64), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(736, 96), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(736, 128), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(736, 160), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(736, 192), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(0, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(32, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariostone_texture"), new Vector2(0, 320), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariostone_texture"), new Vector2(32, 320), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(126, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(158, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(190, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(222, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(126, 320), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(158, 320), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(190, 320), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(222, 320), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(320, 224), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(352, 224), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(320, 256), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(352, 256), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(448, 224), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(480, 224), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(448, 256), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(480, 256), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(576, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(608, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(640, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(672, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(576, 320), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(608, 320), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(640, 320), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(672, 320), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(768, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(800, 288), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariostone_texture"), new Vector2(768, 320), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariostone_texture"), new Vector2(800, 320), Color.White);



            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(336, 568), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(336, 536), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(336, 504), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(368, 504), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(400, 504), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(432, 504), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(432, 536), Color.White);
            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"mario_textures\\mariobrick_texture"), new Vector2(432, 568), Color.White);

            Globals.SpriteBatch.Draw(Globals.ContentManager.Load<Texture2D>(@"tank_textures\\coat_of_arms_texture"), new Vector2(368, 536), Color.White);
        }
    }
}

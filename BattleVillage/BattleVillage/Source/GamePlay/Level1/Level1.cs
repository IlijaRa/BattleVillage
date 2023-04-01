using BattleVillage.Source.Engine.Tanks;
using Microsoft.Xna.Framework;

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
            base.Draw();
            BasicTank.Draw();
            FastTank.Draw();
        }
    }
}

using BattleVillage.Source.Engine.Tanks;
using Microsoft.Xna.Framework;

namespace BattleVillage.Source.GamePlay
{
    public class Level
    {
        public LeftTank LeftTank { get; set; }

        public RightTank RightTank { get; set; }

        public Level()
        {
            LeftTank = new LeftTank(new Vector2(304, 568), new Vector2(60, 60), @"tank_textures\\class2_tank\\blue_class2_texture");
            RightTank = new RightTank(new Vector2(496, 568), new Vector2(60, 60), @"tank_textures\\class2_tank\\red_class2_texture");
        }

        public virtual void Update()
        {
            LeftTank.Update();
            RightTank.Update();
        }

        public virtual void Draw()
        {
            LeftTank.Draw();
            RightTank.Draw();
        }
    }
}

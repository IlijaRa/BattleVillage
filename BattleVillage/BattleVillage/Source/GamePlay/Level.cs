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
            LeftTank = new LeftTank(new Vector2(200, 400), new Vector2(60, 60), @"tank_textures\\class1_tank\\blue_class1_texture");
            RightTank = new RightTank(new Vector2(400, 400), new Vector2(60, 60), @"tank_textures\\class1_tank\\red_class1_texture");
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

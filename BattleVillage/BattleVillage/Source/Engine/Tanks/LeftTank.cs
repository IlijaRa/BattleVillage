using Microsoft.Xna.Framework;

namespace BattleVillage.Source.Engine.Tanks
{
    public class LeftTank : Tank
    {
        public LeftTank() { }

        public LeftTank(Vector2 pos, Vector2 dim, string path) : base(pos, dim, path) { }

        public override void Update() 
        {
            if (Globals.keyboard.GetPress("A"))
                Position = new Vector2(Position.X - 1, Position.Y);
            else if (Globals.keyboard.GetPress("D"))
                Position = new Vector2(Position.X + 1, Position.Y);
            else if(Globals.keyboard.GetPress("W"))
                Position = new Vector2(Position.X, Position.Y - 1);
            else if(Globals.keyboard.GetPress("S"))
                Position = new Vector2(Position.X, Position.Y + 1);

            base.Update();
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}

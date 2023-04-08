using Microsoft.Xna.Framework;

namespace BattleVillage.Source.Engine.Tanks
{
    public class RightTank : Tank
    {
        public RightTank() { }

        public RightTank(Vector2 pos, Vector2 dim, string path) : base(pos, dim, path) { }

        public override void Update()
        {
            if (Globals.keyboard.GetPress("NumPad1"))
                Position = new Vector2(Position.X - 1, Position.Y);
            else if (Globals.keyboard.GetPress("NumPad3"))
                Position = new Vector2(Position.X + 1, Position.Y);
            else if (Globals.keyboard.GetPress("NumPad5"))
                Position = new Vector2(Position.X, Position.Y - 1);
            else if (Globals.keyboard.GetPress("NumPad2"))
                Position = new Vector2(Position.X, Position.Y + 1);

            base.Update();
        }
    }
}

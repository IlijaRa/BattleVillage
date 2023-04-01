using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BattleVillage.Source.Engine.Tanks
{
    public class Tank
    {
        public Vector2 Position { get; set; }

        public Vector2 Dimension { get; set; }

        public Texture2D Texture { get; set; }

        public Tank()
        {

        }

        public Tank(Vector2 pos, Vector2 dim, string path)
        {
            Position = pos;
            Dimension = dim;
            Texture = Globals.ContentManager.Load<Texture2D>(path);
        }

        public virtual void Update() { }

        public virtual void Draw()
        {
            if (Texture is not null)
            {
                Globals.SpriteBatch.Draw(Texture, new Rectangle((int)Position.X, (int)Position.Y, (int)Dimension.X, (int)Dimension.Y),
                                                                null,
                                                                Color.White,
                                                                0.0f,
                                                                new Vector2(Texture.Bounds.Width / 2, Texture.Bounds.Height / 2),
                                                                new SpriteEffects(),
                                                                0);
            }
        }
    }
}

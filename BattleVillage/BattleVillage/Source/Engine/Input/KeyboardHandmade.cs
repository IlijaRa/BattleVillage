using BattleVillage.Source.Engine.Input.KeyboardInputs;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace BattleVillage.Source.Engine.Input
{
    public class KeyboardHandmade
    {
        public KeyboardState newKeyboard, oldKeyboard;

        public List<Key> pressedKeys = new List<Key>(), previousPressedKeys = new List<Key>();

        public KeyboardHandmade()
        {

        }

        public virtual void Update()
        {
            newKeyboard = Keyboard.GetState();

            GetPressedKeys();
        }

        public void UpdateOld()
        {
            oldKeyboard = newKeyboard;

            previousPressedKeys = new List<Key>();

            for (int i = 0; i < pressedKeys.Count; i++)
                previousPressedKeys.Add(pressedKeys[i]);
        }

        public bool GetPress(string KEY)
        {
            for (int i = 0; i < pressedKeys.Count; i++)
                if (pressedKeys[i].key == KEY)
                {
                    return true;
                }

            return false;
        }

        public virtual void GetPressedKeys()
        {
            pressedKeys.Clear();

            for (int i = 0; i < newKeyboard.GetPressedKeys().Length; i++)
                pressedKeys.Add(new Key(newKeyboard.GetPressedKeys()[i].ToString(), 1));
        }
    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame
{
    internal class Character
    {
        public enum states { STILL, WALK_R, WALK_L, JUMP, FALL};
        private Vector2 _pos { get; set; }
        private Vector2 _speed { get; set; }
        private Vector2 _accel { get; set; }
        private AnimatedSprite _still;
        private AnimatedSprite _walk;
        private AnimatedSprite _jump;
        private AnimatedSprite _fall;
        private states _state;

        public Character (Vector2 pos, Texture2D stillFile, Texture2D walkFile = null, Texture2D jumpFile = null, Texture2D fallFile = null)
        {
            _pos = pos;
            _speed = new Vector2(0f,0f);
            _state = states.STILL;

            if (stillFile != null) 
            {
                _still = new AnimatedSprite(stillFile, 2, 11, 60);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            switch(_state)
            {
                case states.STILL:
                    _still.Draw(spriteBatch, _pos);
                    break;
            }
        }

        public void Update(int millisElapsed)
        {
            switch (_state)
            {
                case states.STILL:
                    _still.Update(millisElapsed);
                    break;
            }
        }
    }
}

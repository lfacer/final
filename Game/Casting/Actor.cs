using System;
using System.Numerics;

namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Actor
    {
        private bool _enabled = true;
        private Vector2 _position = Vector2.Zero;
        private Vector2 _size = Vector2.Zero;
        private Vector2 _velocity = Vector2.Zero;
        private bool debug;
        
        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Actor(bool debug)
        {
            this.debug = debug;
        }

        /// <summary>
        /// Whether or not the actor is being debugged.
        /// </summary>
        /// <returns>True if being debugged; false if othewise.</returns>
        public bool IsDebug()
        {
            return debug;
        }

        public virtual void Move()
        {
            if (_enabled)
            {
                _position = _position + _velocity;
            }
        }

        public virtual void Move(float gravity)
        {
            if (_enabled)
            {
                Vector2 force = new Vector2(_velocity.X, _velocity.Y + gravity);
                _position = _position + force;
            }
        }
    }
}
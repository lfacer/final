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
        private float _scale = 1f;
        private Color _tint = Color.White();
        private Point _velocity_b = new Point(0, 0);
        private Point _position_b = new Point(0, 0);
        
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

        public virtual void ClampTo(Actor region)
        {
            Validator.CheckNotNull(region);
            
            if (_enabled)
            {
                float x = GetLeft();
                float y = GetTop();

                float maxX = region.GetRight() - GetWidth();
                float maxY = region.GetBottom() - GetHeight();
                float minX = region.GetLeft();
                float minY = region.GetTop();

                x = Math.Clamp(x, minX, maxX);
                y = Math.Clamp(y, minY, maxY);

                Vector2 newPosition = new Vector2(x, y);
                MoveTo(newPosition);
            }
        }

        public virtual void Enable()
        {
            _enabled = true;
        }

        public virtual void Disable()
        {
            _enabled = false;
        }

        public virtual float GetBottom()
        {
            return _position.Y + _size.Y;
        }

        public virtual Vector2 GetCenter()
        {
            float x = _position.X + (_size.X / 2);
            float y = _position.Y + (_size.Y / 2);
            return new Vector2(x, y);
        }

        public virtual float GetCenterX()
        {
            return _position.X + (_size.X / 2);
        }

        public virtual float GetCenterY()
        {
            return _position.Y + (_size.Y / 2);
        }

        public virtual float GetHeight()
        {
            return _size.Y;
        }

        public virtual float GetLeft()
        {
            return _position.X;
        }

        public virtual Vector2 GetPosition()
        {
            return _position;
        }

        public virtual Vector2 GetOriginalSize()
        {
            return _size;
        }

        public virtual float GetRight()
        {
            return _position.X + _size.X;
        }


        public virtual float GetTop()
        {
            return _position.Y;
        }

        // gets the velocity for the background
        public virtual Vector2 GetVelocity()
        {
            return _velocity;
        }

        // gets the backgrounds position
        public Point GetPositionB()
        {
            return _position_b;
        }

        // moves the background according to its next position according to its velocity. will wrap the position from one side of the screen to the other 
        public void MoveNextB(int maxX, int maxY)
        {
            int x = ((_position_b.GetX() + _velocity_b.GetX()) + maxX) % maxX;
            int y = ((_position_b.GetY() + _velocity_b.GetY()) + maxY) % maxY;
            _position_b = new Point(x, y);
        }

        // sets the backgrounds velocity to the given value
        public void SetVelocityB(Point _velocity_b)
        {
            if (_velocity_b == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this._velocity_b = _velocity_b;
        }


        public Point GetVelocityB()
        {
            return _velocity_b;
        }

        public virtual float GetWidth()
        {
            return _size.X;
        }


        public virtual void MoveTo(Vector2 position)
        {
            _position = position;
        }

        public virtual void MoveTo(float x, float y)
        {
            _position = new Vector2(x, y);
        }

        public virtual Color GetTint()
        {
            return _tint;
        }

        public virtual void Tint(Color color)
        {
            Validator.CheckNotNull(color);
            _tint = color;
        }

        public virtual void Scale(float percent)
        {
            _scale += percent;
        }

        public virtual float GetScale()
        {
            return _scale;
        }

        public virtual Vector2 GetSize()
        {
            return _size * _scale;
        }

    }
}
using Unit06.Game.Casting;
using System.Collections.Generic;


namespace Unit06.Game.Scripting
{
    public class BackgroundAction : Action
    {
        private Point _velocity_b = new Point(0, 0);
        private Point _position_b = new Point(0, 0);
        public BackgroundAction()
        {
        }


        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            List<Actor>backgrounds = cast.GetActors(Constants.BACKGROUND_GROUP);
            foreach(Actor back in backgrounds)
            {
            Body body = ((Brick)back).GetBody();
            // Body body = backgrounds[1].GetBody();
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();

            position = position.Add(velocity);

            int x = position.GetX();
            int y = position.GetY();
            

            position = position.Add(velocity);
            if (x < -800)
            {
                position = new Point(x + 1600, y);
            }
            // else if (y > Constants.SCREEN_HEIGHT - Constants.DINO_HEIGHT)
            // {
            //     position = new Point(x, Constants.SCREEN_HEIGHT - Constants.DINO_HEIGHT);
            // }
            

            body.SetPosition(position);    
            }
           
   
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
        // public void SetVelocityB(Point _velocity_b)
        // {
        //     if (_velocity_b == null)
        //     {
        //         throw new ArgumentException("velocity can't be null");
        //     }
        //     this._velocity_b = _velocity_b;
        // }


        public Point GetVelocityB()
        {
            return _velocity_b;
        }
    }
}
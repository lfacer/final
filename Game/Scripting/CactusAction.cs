using Unit06.Game.Casting;
using System.Collections.Generic;
using System;


namespace Unit06.Game.Scripting
{
    public class CactusAction : Action
    {
        private Point _velocity_c = new Point(0, 0);
        private Point _position_c = new Point(0, 0);
        public CactusAction()
        {
        }



        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            // System.Console.Write("cactus action 20");
            List<Actor>cactuses = cast.GetActors(Constants.CACTUS_GROUP);
            foreach(Actor plant in cactuses)
            {
            Body body = ((Brick)plant).GetBody();
            // Body body = cactuses[1].GetBody();
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();

            position = position.Add(velocity);

            int x = position.GetX();
            int y = position.GetY();
            

            position = position.Add(velocity);
            if (x < -900)
            {
                position = new Point(x + 1795, y);
            }
            // else if (y > Constants.SCREEN_HEIGHT - Constants.DINO_HEIGHT)
            // {
            //     position = new Point(x, Constants.SCREEN_HEIGHT - Constants.DINO_HEIGHT);
            // }
            

            body.SetPosition(position);    
            }
           
   
        }


        // gets the cactuses position
        public Point GetPositionC()
        {
            return _position_c;
        }

        // moves the cacrus according to its next position according to its velocity. will wrap the position from one side of the screen to the other 
        public void MoveNextC(int maxX, int maxY)
        {
            int x = ((_position_c.GetX() + _velocity_c.GetX()) + maxX) % maxX;
            int y = ((_position_c.GetY() + _velocity_c.GetY()) + maxY) % maxY;
            _position_c = new Point(x, y);
        }

        // sets the cactuss velocity to the given value
        // public void SetVelocityB(Point _velocity_b)
        // {
        //     if (_velocity_b == null)
        //     {
        //         throw new ArgumentException("velocity can't be null");
        //     }
        //     this._velocity_b = _velocity_b;
        // }


        public Point GetVelocityC()
        {
            return _velocity_c;
        }
    }
}
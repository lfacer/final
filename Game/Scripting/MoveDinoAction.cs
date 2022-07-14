using Unit06.Game.Casting;

namespace Unit06.Game.Scripting
{
    public class MoveDinoAction : Action
    {
        public MoveDinoAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Dino dino = (Dino)cast.GetFirstActor(Constants.DINO_GROUP);
            Body body = dino.GetBody();
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();

            Point gravity = new Point(0, 3); // constant downward pull
            velocity = velocity.Add(gravity); // update the velocity with gravity
            position = position.Add(velocity);

            int x = position.GetX();
            int y = position.GetY();
            

            position = position.Add(velocity);
            if (y < 0)
            {
                position = new Point(x, 0);
            }
            else if (y > Constants.SCREEN_HEIGHT - Constants.DINO_HEIGHT)
            {
                position = new Point(x, Constants.SCREEN_HEIGHT - Constants.DINO_HEIGHT);
            }
            

            body.SetPosition(position);       
        }
    }
}
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
            int x = position.GetX();

            position = position.Add(velocity);
            if (x < 0)
            {
                position = new Point(0, position.GetY());
                dino.Move(5);
            }
            else if (x > Constants.SCREEN_HEIGHT - Constants.DINO_HEIGHT)
            {
                position = new Point(Constants.SCREEN_HEIGHT - Constants.DINO_HEIGHT, 
                    position.GetY());
            }

            
            

            body.SetPosition(position);       
        }
    }
}
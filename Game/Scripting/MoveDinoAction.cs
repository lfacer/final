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
            }
            else if (x > Constants.SCREEN_WIDTH - Constants.RACKET_WIDTH)
            {
                position = new Point(Constants.SCREEN_WIDTH - Constants.RACKET_WIDTH, 
                    position.GetY());
            }

            body.SetPosition(position);       
        }
    }
}
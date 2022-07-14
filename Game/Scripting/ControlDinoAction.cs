using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class ControlDinoAction : Action
    {
        private KeyboardService keyboardService;

        public ControlDinoAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            
            Dino dino = (Dino)cast.GetFirstActor(Constants.DINO_GROUP);
            if (keyboardService.IsKeyDown(Constants.UP))
            {
                dino.Jump();
            }
            else if (keyboardService.IsKeyDown(Constants.DOWN))
            {
                dino.Duck();
            }
            else
            {
                dino.StopMoving();
            }

            // dino.Move(5);
            // dino.ClampTo(screen);
            
        }
    }
}
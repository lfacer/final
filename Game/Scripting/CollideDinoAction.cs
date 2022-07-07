using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CollideDinoAction : Action
    {
        private AudioService audioService;
        private PhysicsService physicsService;
        
        public CollideDinoAction(PhysicsService physicsService, AudioService audioService)
        {
            this.physicsService = physicsService;
            this.audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Ball ball = (Ball)cast.GetFirstActor(Constants.BALL_GROUP);
            Dino dino = (Dino)cast.GetFirstActor(Constants.DINO_GROUP);
            Body ballBody = ball.GetBody();
            Body racketBody = dino.GetBody();

            if (physicsService.HasCollided(racketBody, ballBody))
            {
                ball.BounceY();
                Sound sound = new Sound(Constants.BOUNCE_SOUND);
                audioService.PlaySound(sound);
            }
        }
    }
}
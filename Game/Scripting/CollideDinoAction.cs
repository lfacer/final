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
            Brick cactus = (Brick)cast.GetFirstActor(Constants.CACTUS_GROUP);
            Dino dino = (Dino)cast.GetFirstActor(Constants.DINO_GROUP);
            Body cactusBody = cactus.GetBody();
            Body dinoBody = dino.GetBody();

            if (physicsService.HasCollided(dinoBody, cactusBody))
            {
                callback.OnNext(Constants.GAME_OVER);
                // audioService.PlaySound(overSound);
            }
        }
    }
}
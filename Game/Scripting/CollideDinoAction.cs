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

            // Here is where I changed the width of the cactus and dino. The body takes in three arguments (position, size, and velocity) I kept the same position and velocity, but I changed the size. I kept the same height, and just changed the width to 10
            Body cb1 = new Body(cactusBody.GetPosition(), new Point(10, cactusBody.GetSize().GetY()), cactusBody.GetVelocity());
            Body db1 = new Body(dinoBody.GetPosition(), new Point(10, dinoBody.GetSize().GetY()), dinoBody.GetVelocity());
            
            if (physicsService.HasCollided(db1, cb1))
            {
                callback.OnNext(Constants.GAME_OVER);
                // audioService.PlaySound(overSound);
            }
        }
    }
}
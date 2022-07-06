using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawDinoAction : Action
    {
        private VideoService videoService;
        
        public DrawDinoAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Dino dino = (Dino)cast.GetFirstActor(Constants.DINO_GROUP);
            Body body = dino.GetBody();

            if (dino.IsDebug())
            {
                Rectangle rectangle = body.GetRectangle();
                Point size = rectangle.GetSize();
                Point pos = rectangle.GetPosition();
                videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
            }

            Animation animation = dino.GetAnimation();
            Image image = animation.NextImage();
            Point position = body.GetPosition();
            videoService.DrawImage(image, position);
        }
    }
}
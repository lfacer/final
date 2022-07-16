using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawCactusAction : Action
    {
        private VideoService videoService;
        
        public DrawCactusAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            // System.Console.Write(" draw cactus action 19");
            List<Actor> plants = cast.GetActors(Constants.CACTUS_GROUP);
            foreach (Actor actor in plants)
            {
                Brick plant = (Brick)actor;
                Body body = plant.GetBody();

                if (plant.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
                }

                Animation animation = plant.GetAnimation();
                Image image = animation.NextImage();
                Point position = body.GetPosition();
                videoService.DrawImage(image, position);
            }
        }
    }
}
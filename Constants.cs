using System.Collections.Generic;
using Unit06.Game.Casting;


namespace Unit06
{
    public class Constants
    {
        // ----------------------------------------------------------------------------------------- 
        // GENERAL GAME CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // GAME
        public static string GAME_NAME = "Dino";
        public static int FRAME_RATE = 60;

        // SCREEN
        public static int SCREEN_WIDTH = 800;
        public static int SCREEN_HEIGHT = 500;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;

        // FIELD
        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 32;

        // SOUND
        public static string BOUNCE_SOUND = "Assets/Sounds/boing.wav";
        public static string WELCOME_SOUND = "Assets/Sounds/start.wav";
        public static string OVER_SOUND = "Assets/Sounds/over.wav";

        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);

        // KEYS
        public static string LEFT = "left";
        public static string RIGHT = "right";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";
        public static string UP = "up";
        public static string DOWN = "down";

        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_LEVEL = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        // LEVELS
        public static string LEVEL_FILE = "Assets/Data/level-{0:000}.txt";
        public static int BASE_LEVELS = 5;

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_LIVES = 3;
        public static int MAXIMUM_LIVES = 5;

        // HUD
        public static int HUD_MARGIN = 15;
        public static string LEVEL_GROUP = "level";
        public static string LIVES_GROUP = "lives";
        public static string SCORE_GROUP = "score";
        public static string LEVEL_FORMAT = "LEVEL: {0}";
        public static string LIVES_FORMAT = "LIVES: {0}";
        public static string SCORE_FORMAT = "SCORE: {0}";

        // BALL
        // public static string BALL_GROUP = "balls";
        // public static string BALL_IMAGE = "Assets/Images/000.png";
        // public static int BALL_WIDTH = 28;
        // public static int BALL_HEIGHT = 28;
        // public static int BALL_VELOCITY = 4;

        // RACKET
        public static string DINO_GROUP = "dinos";
        
        public static List<string> DINO_IMAGES_RUN
            = new List<string>() {
                "Assets/Images/Run (1).png",
                "Assets/Images/Run (2).png",
                "Assets/Images/Run (3).png",
                "Assets/Images/Run (4).png",
                "Assets/Images/Run (5).png",
                "Assets/Images/Run (6).png",
                "Assets/Images/Run (7).png",
                "Assets/Images/Run (8).png"
            };

        public static List<string> DINO_IMAGES_JUMP
            = new List<string>() {
                "Assets/Images/Jump (1).png",
                "Assets/Images/Jump (2).png",
                "Assets/Images/Jump (3).png",
                "Assets/Images/Jump (4).png",
                "Assets/Images/Jump (5).png",
                "Assets/Images/Jump (6).png",
                "Assets/Images/Jump (7).png",
                "Assets/Images/Jump (8).png",
                "Assets/Images/Jump (9).png",
                "Assets/Images/Jump (10).png",
                "Assets/Images/Jump (11).png",
                "Assets/Images/Jump (12).png"
            };
            

        public static int DINO_WIDTH = 340;
        // 106
        public static int DINO_HEIGHT = 256;
        // 28
        public static int DINO_RATE = 6;
        public static int DINO_VELOCITY = 3;

        // BRICK
        public static string BRICK_GROUP = "bricks";
        
        public static Dictionary<string, List<string>> BRICK_IMAGES
            = new Dictionary<string, List<string>>() {
                { "b", new List<string>() {
                    "Assets/Images/010.png",
                    "Assets/Images/011.png",
                    "Assets/Images/012.png",
                    "Assets/Images/013.png",
                    "Assets/Images/014.png",
                    "Assets/Images/015.png",
                    "Assets/Images/016.png",
                    "Assets/Images/017.png",
                    "Assets/Images/018.png"
                } },
                { "g", new List<string>() {
                    "Assets/Images/020.png",
                    "Assets/Images/021.png",
                    "Assets/Images/022.png",
                    "Assets/Images/023.png",
                    "Assets/Images/024.png",
                    "Assets/Images/025.png",
                    "Assets/Images/026.png",
                    "Assets/Images/027.png",
                    "Assets/Images/028.png"
                } },
                { "p", new List<string>() {
                    "Assets/Images/030.png",
                    "Assets/Images/031.png",
                    "Assets/Images/032.png",
                    "Assets/Images/033.png",
                    "Assets/Images/034.png",
                    "Assets/Images/035.png",
                    "Assets/Images/036.png",
                    "Assets/Images/037.png",
                    "Assets/Images/038.png"
                } },
                { "y", new List<string>() {
                    "Assets/Images/040.png",
                    "Assets/Images/041.png",
                    "Assets/Images/042.png",
                    "Assets/Images/043.png",
                    "Assets/Images/044.png",
                    "Assets/Images/045.png",
                    "Assets/Images/046.png",
                    "Assets/Images/047.png",
                    "Assets/Images/048.png"
                } }
        };

        public static string BACKGROUND_GROUP = "backgrounds";

        public static List<string> BACKGROUND_IMAGES = new List<string>() {
                    "Assets/Images/background.png"
                };

        public static int BRICK_WIDTH = 80;
        public static int BRICK_HEIGHT = 28;
        public static double BRICK_DELAY = 0.5;
        public static int BRICK_RATE = 4;
        public static int BRICK_POINTS = 50;

        // background sizes and info
        public static int BACKGROUND_RATE = 4;
        public static int BACKGROUND_WIDTH = 1200;
        public static int BACKGROUND_HEIGHT = 750;
        public static double BACKGROUND_DELAY = 0.5;


        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START";
        public static string PREP_TO_LAUNCH = "PREPARING TO LAUNCH";
        public static string WAS_GOOD_GAME = "GAME OVER";

    }
}
class GraphicsSystem
{
    public void Initialize()
    {
        Console.WriteLine("Инициализация графики");
    }
}
class AudioSystem
{
    public void Initialize()
    {
        Console.WriteLine("Инициализация звука");
    }
}

class InputSystem
{
    public void Initialize()
    {
        Console.WriteLine("Инициализация управления");
    }
}
class SaveSystem
{
    public void Load()
    {
        Console.WriteLine("Загрузка сохранения");
    }
}
class PlayerSystem
{
    public void Create()
    {
        Console.WriteLine("Создание игрока");
    }
}
class GameFacade
{
    private GraphicsSystem graphics;
    private AudioSystem audio;
    private InputSystem input;
    private SaveSystem save;
    private PlayerSystem player;

    public GameFacade()
    {
        graphics = new GraphicsSystem();
        audio = new AudioSystem();
        input = new InputSystem();
        save = new SaveSystem();
        player = new PlayerSystem();
    }

    public void StartGame()
    {
        graphics.Initialize();
        audio.Initialize();
        input.Initialize();
        save.Load();
        player.Create();
    }
}
class Program
{
    static void Main()
    {
        GameFacade game = new GameFacade();

        game.StartGame();
    }
}
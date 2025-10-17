using todo_app.controller;

namespace todo_app;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Controller controller = new Controller();
        controller.Init();
        Application.Run(controller.Form1);
    }
}
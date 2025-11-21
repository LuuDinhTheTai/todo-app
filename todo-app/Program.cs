using todo_app.exception;
using todo_app.service;

namespace todo_app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            GlobalExceptionHandler.Setup();

            var controller = new controller.Controller();
            controller.Init();
            if (args.Length > 0 && args[0] == "/notify")
            {
                controller.ReminderService.ShowNotification();
                return;
            }
            Application.Run(controller.MainForm);
        }
    }
}
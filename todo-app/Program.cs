using System.Threading;
using todo_app.exception;

namespace todo_app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            var controller = new controller.Controller();
            controller.Init();
            
            Application.Run(controller.Form1);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
            
            if (e.IsTerminating)
            {
                MessageBox.Show("Ứng dụng đã gặp một lỗi nghiêm trọng và sẽ phải đóng lại.", "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private static void HandleException(Exception? ex)
        {
            if (ex == null) return;

            if (ex is AppException)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã có lỗi không mong muốn xảy ra. Vui lòng thử lại hoặc liên hệ quản trị viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_app.controller;
using todo_app.exception;
using Timer = System.Windows.Forms.Timer;


namespace todo_app.service
{
    public class ReminderService
    {
        public ReminderService(Controller controller)
        {
        }
        public void CreateOrUpdateReminder(int todoId, DateTime reminderTime)
        {
            try
            {
                using (TaskService taskService = new TaskService())
                {
                    string taskName = $"TodoReminder_{todoId}";
                    string exePath = Process.GetCurrentProcess().MainModule.FileName;

                    var existing = taskService.GetTask(taskName);
                    if (existing != null)
                        taskService.RootFolder.DeleteTask(taskName, false);

                    TaskDefinition taskDefinition = taskService.NewTask();
                    taskDefinition.RegistrationInfo.Description = $"Reminder for Todo ID {todoId}";

                    taskDefinition.Triggers.Add(new TimeTrigger
                    {
                        StartBoundary = reminderTime,
                        Enabled = true
                    });

                    taskDefinition.Actions.Add(new ExecAction(exePath, "/notify", null));

                    taskService.RootFolder.RegisterTaskDefinition(
                        taskName,
                        taskDefinition,
                        TaskCreation.CreateOrUpdate,
                        null, null,
                        TaskLogonType.InteractiveToken);
                }
            }
            catch
            {
                throw new AppException("Xảy ra lỗi trong quá trình tạo nhăc nhở.");
            }
        }
        public void DeleteReminder(int todoId)
        {
            try
            {
                using (TaskService ts = new TaskService())
                {
                    string taskName = $"TodoReminder_{todoId}";

                    if (ts.GetTask(taskName) != null)
                        ts.RootFolder.DeleteTask(taskName, false);
                }
            }
            catch
            {
                throw new AppException("Xảy ra lỗi trong trình xóa nhắc nhở.");
            }
        }
        public bool ReminderExists(int todoId)
        {
            using (TaskService ts = new TaskService())
            {
                string taskName = $"TodoReminder_{todoId}";
                return ts.GetTask(taskName) != null;
            }
        }
        public void UpdateReminder(int todoId, DateTime newTime)
        {
            DeleteReminder(todoId);
            CreateOrUpdateReminder(todoId, newTime);
        }
        public void ShowNotification()
        {
            NotifyIcon notify = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true,
                BalloonTipTitle = "Todo App",
                BalloonTipText = "You have a todo coming up!",
                BalloonTipIcon = ToolTipIcon.Info
            };

            notify.BalloonTipClicked += (s, e) =>
            {
                try
                {
                    string exePath = Process.GetCurrentProcess().MainModule.FileName;
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = exePath,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    throw new AppException("Không thể mở Todo App");
                }
            };

            notify.ShowBalloonTip(5000);

            Timer timer = new Timer { Interval = 5000 };
            timer.Tick += (s, e) =>
            {
                notify.Dispose();
                Application.Exit();
            };
            timer.Start();

            Application.Run();
        }
    }
}

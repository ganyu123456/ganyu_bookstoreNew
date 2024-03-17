using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp;
using Abp.Extensions;
using Abp.Notifications;
using Abp.Timing;
using Abp.Web.Security.AntiForgery;
using BookStoreAbpProject.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BookStoreAbpProject.Web.Host.Controllers
{
    public class HomeController : BookStoreAbpProjectControllerBase
    {
        private readonly INotificationPublisher _notificationPublisher;
        private readonly IWebHostEnvironment env;

        public HomeController(INotificationPublisher notificationPublisher, IWebHostEnvironment env)
        {
            _notificationPublisher = notificationPublisher;
            this.env = env;
        }

        public IActionResult Index()
        {
            if (env.IsDevelopment())
            {
                return Redirect("/swagger");
            }
            else
            {
                return Redirect("/index.html");
            }
        }

        /// <summary>
        /// This is a demo code to demonstrate sending notification to default tenant admin and host admin uers.
        /// Don't use this code in production !!!
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<ActionResult> TestNotification(string message = "")
        {
            if (message.IsNullOrEmpty())
            {
                message = "This is a test notification, created at " + Clock.Now;
            }

            var defaultTenantAdmin = new UserIdentifier(1, 2);
            var hostAdmin = new UserIdentifier(null, 1);

            await _notificationPublisher.PublishAsync(
                "App.SimpleMessage",
                new MessageNotificationData(message),
                severity: NotificationSeverity.Info,
                userIds: new[] { defaultTenantAdmin, hostAdmin }
            );

            return Content("Sent notification: " + message);
        }
    }
}

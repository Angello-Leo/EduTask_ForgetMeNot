using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    internal class NotificationManager
    {
        public static frmNotification CurrentForm { get; set; }

        public static void SendNotification(int notificationId, string message, string type, DateTime createdAt, int creatorId)
        {
            int currentUserId = GetInfo.UserID;

            // Show balloon only for non-creators
            if (currentUserId != creatorId && Application.OpenForms.OfType<frmDashBoard>().FirstOrDefault() is frmDashBoard dash)
            {
                dash.ShowTrayNotification(message, type);
            }

            // Add to FlowPanel if the notification form is open
            CurrentForm?.AddNotificationToPanel(notificationId, message, type, createdAt);
        }

    }
}

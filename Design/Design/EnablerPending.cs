using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    internal class EnablerPending : PendingLogic
    {

        public override void LoadMissingAnnouncement(FlowLayoutPanel panel)
        {
            string query = @"SELECT a.announcement_id, a.class_id, a.title, a.content, a.due_datetime, a.created_at,
           u.username, u.role AS creator_role, s.status FROM announcements a JOIN users u ON a.user_id = u.user_id
           LEFT JOIN announcement_status s ON s.announcement_id = a.announcement_id AND s.user_id = @uid
           WHERE s.status = 'missing'
           ORDER BY a.due_datetime ASC;";

            LoadAnnouncements(panel, query, _ => false);
        }
        public override void LoadPendingAnnouncement(FlowLayoutPanel panel)
        {
            string query = @"SELECT a.announcement_id, a.class_id, a.title, a.content, a.due_datetime, a.created_at,
           u.username, u.role AS creator_role, s.status FROM announcements a LEFT JOIN announcement_status s
         ON s.announcement_id = a.announcement_id AND s.user_id = @uid JOIN users u ON a.user_id = u.user_id WHERE 
         COALESCE(s.status, 'pending') = 'pending' ORDER BY a.created_at DESC;";

            LoadAnnouncements(panel, query, _ => false, Color.LightSalmon);
        }
        public override void LoadAccomplishedAnnouncement(FlowLayoutPanel panel)
        {
            string query = @"SELECT a.announcement_id, a.class_id, a.title, a.content, a.due_datetime, a.created_at,
           u.username, u.role AS creator_role, s.status FROM announcements a LEFT JOIN announcement_status s ON 
           s.announcement_id = a.announcement_id AND s.user_id = @uid JOIN users u ON a.user_id = u.user_id
           WHERE s.status = 'done' ORDER BY a.created_at DESC;";

            LoadAnnouncements(panel, query, r => r["status"].ToString() == "done");
        }
    
    }
}

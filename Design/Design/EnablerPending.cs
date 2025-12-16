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
            string query = @"
        SELECT a.announcement_id, a.class_id, a.title, a.content, a.due_datetime, a.created_at,
               u.username, u.role AS creator_role,
               COALESCE(s.status, 'missing') AS status
        FROM announcements a
        JOIN users u ON a.user_id = u.user_id
        JOIN class_students cs ON cs.class_id = a.class_id AND cs.student_id = @uid
        LEFT JOIN announcement_status s ON s.announcement_id = a.announcement_id AND s.user_id = @uid
        WHERE COALESCE(s.status, 'missing') = 'missing'
        ORDER BY a.due_datetime ASC;
    ";

            LoadAnnouncements(panel, query, reader => reader["status"].ToString() == "missing");
        }


        public override void LoadPendingAnnouncement(FlowLayoutPanel panel)
        {
            string query = @"
                SELECT a.announcement_id, a.class_id, a.title, a.content, a.due_datetime, a.created_at,
                       u.username, u.role AS creator_role,
                       COALESCE(s.status, 'pending') AS status
                FROM announcements a
                JOIN users u ON a.user_id = u.user_id
                JOIN class_students cs ON cs.class_id = a.class_id AND cs.student_id = @uid
                LEFT JOIN announcement_status s ON s.announcement_id = a.announcement_id AND s.user_id = @uid
                WHERE COALESCE(s.status, 'pending') = 'pending'
                ORDER BY a.created_at DESC;
            ";

            LoadAnnouncements(panel, query, reader => reader["status"].ToString() == "pending", Color.LightSalmon);
        }

        public override void LoadAccomplishedAnnouncement(FlowLayoutPanel panel)
        {
            string query = @"
                SELECT a.announcement_id, a.class_id, a.title, a.content, a.due_datetime, a.created_at,
                       u.username, u.role AS creator_role,
                       s.status
                FROM announcements a
                JOIN users u ON a.user_id = u.user_id
                JOIN class_students cs ON cs.class_id = a.class_id AND cs.student_id = @uid
                JOIN announcement_status s ON s.announcement_id = a.announcement_id AND s.user_id = @uid
                WHERE s.status = 'done'
                ORDER BY a.created_at DESC;
            ";

            LoadAnnouncements(panel, query, reader => reader["status"].ToString() == "done");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    internal class UiTransition
    {
        public void Home(Form current)
        {
            new frmDashBoard().Show();
            current.Close();
        }

        public void Pending(Form current)
        {
            new frmPending().Show();
            current.Close();
        }

        public void Schedule(Form current)
        {
            new frmCallendar().Show();
            current.Close();
        }

        public void Flashcards(Form current)
        {
            new frmFlashcard().Show();
            current.Close();
        }

        public void Notification(Form current)
        {
            new frmNotification().Show();
            current.Close();
        }

        public void AddClass(Form current)
        {
            new frmCreateClass().Show();
            current.Close();
        }

        public void Accomplished(Form current)
        {
            new frmAccomplished().Show();
            current.Close();
        }

        public void Missing(Form current)
        {
            new frmMissing().Show();
            current.Close();
        }

        public void Personal(Form current)
        {
            new frmPersonal().Show();
            current.Close();
        }
    }
}

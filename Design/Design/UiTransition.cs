using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    internal class UiTransition
    {
        public void Home(Form form)
        {
            frmDashBoard dashBoard = new frmDashBoard();
            dashBoard.Show();
            form.Close();
        }

        public void Pending(Form form)
        {
            frmPending pending = new frmPending();
            pending.Show();
            form.Close();
        }

        public void Schedule(Form form)
        {
            frmCallendar schedule = new frmCallendar();
            schedule.Show();
            schedule.Close();
        }

        public void Flashcards(Form form)
        {
            frmFlashcard flashcard = new frmFlashcard();
            flashcard.Show();
            form.Close();
        }

        public void Notification(Form form)
        {
            frmNotification notification = new frmNotification();
            notification.Show();
            form.Close();
        }

        public void AddClass(Form form)
        {
            frmCreateClass addClass = new frmCreateClass();
            addClass.Show();
            addClass.Close();
        }
    }
}

using System;

namespace Horoskop
{
    internal class UstalDatę
    {
        private DateTime selectedDate;

        public UstalDatę(DateTime selectedDate)
        {
            this.selectedDate = selectedDate;
        }

        public string GetSelectedDate()
        {
            return selectedDate.ToString("MM-dd");
        }

    }
}

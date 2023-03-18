

namespace ClassLibrary1
{
    public class UstalZodiak 
    {
        private DateTime selectedDate;

        public UstalZodiak(DateTime selectedDate)
        {
            this.selectedDate = selectedDate;
        }

        public string GetSelectedDate() {
             return selectedDate.ToString("MM-dd");
        }

    }
}
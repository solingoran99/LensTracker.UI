namespace LensTracker.UI.Services
{
    public class DateService
    {
        public int SelectedDay { get; private set; }
        public string FormattedDate { get; private set; } = "";
        public event Action? OnChange;

        public void SetDay(int day)
        {
            SelectedDay = day;
            string month = DateTime.Now.ToString("MMMM");
            FormattedDate = $"{day} {month}";
            OnChange?.Invoke();
        }
    }
}

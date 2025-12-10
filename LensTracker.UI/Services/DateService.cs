namespace LensTracker.UI.Services
{
    public class DateService
    {
        public DateTime SelectedDate { get; private set; }
        public string FormattedDate { get; private set; } = "";
        public event Action? OnChange;

        public void SetDate(DateTime date)
        {
            SelectedDate = date;
            FormattedDate = date.ToString("d MMMM yyyy");
            OnChange?.Invoke();
        }
    }
}
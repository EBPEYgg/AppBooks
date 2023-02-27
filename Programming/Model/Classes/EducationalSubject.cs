namespace Programming.Model.Classes
{
    internal class EducationalSubject
    {
        private string? nameSubject { get; set; }
        private int learnHoursTimeSubject
        {
            get { return learnHoursTimeSubject; }
            set { if (learnHoursTimeSubject > 0) learnHoursTimeSubject = value; }
        }
        private int markSubject
        {
            get { return markSubject; }
            set { if (markSubject >= 1 && markSubject <= 5) markSubject = value; }
        }
    }
}

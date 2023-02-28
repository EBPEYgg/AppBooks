namespace Programming.Model.Classes
{
    internal class EducationalSubject
    {
        private string? name { get; set; }
        private int learnHoursTime
        {
            get { return learnHoursTime; }
            set { if (Validator.AssertOnPositiveValue(learnHoursTime)) learnHoursTime = value; }
        }
        private int mark
        {
            get { return mark; }
            set { if (Validator.AssertValueInRange(mark, 0, 6)) mark = value; }
        }

        public EducationalSubject(string? name, int learnHoursTime, int mark)
        {
            name = "";
            learnHoursTime = 0;
            mark = 0;
        }
    }
}

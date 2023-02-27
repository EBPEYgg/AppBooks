namespace Programming.Model.Classes
{
    internal class ContactPhone
    {
        private int idContact { get; set; }
        private string? nameContact { get; set; }
        private int numberContact
        {
            get { return numberContact; }
            set { if (numberContact == 11) numberContact = value; }
        }
    }
}

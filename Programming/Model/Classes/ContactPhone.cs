namespace Programming.Model.Classes
{
    internal class ContactPhone
    {
        private int id { get; set; }
        private string? name
        {
            get { return name; }
            set { AssertStringContainsOnlyEnglishLetters(name); }
        }
        private string? surname 
        { 
            get { return surname; }
            set { AssertStringContainsOnlyEnglishLetters(surname); }
        }
        private int number
        {
            get { return number; }
            set { if (number == 11) number = value; }
        }

        private bool AssertStringContainsOnlyEnglishLetters(string name)
        {
            try
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (((name[i] >= 'a') && (name[i] <= 'z')) || ((name[i] >= 'A') && (name[i] <= 'Z')))
                        return true;
                }
                return false;
            }
            catch
            {
                throw new ArgumentException("Допустима только латиница");
            }
            
        }

        public ContactPhone(int id, string? name, string? surname, int number)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.number = number;
        }
    }
}

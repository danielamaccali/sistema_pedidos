using System;


namespace exercEnum.Entities
{
    class Client
    {
        string _name { get; set; }
        string _email { get; set; }
        DateTime _birthDate { get; set; }

        public Client()
        {

        }

        public Client (string name, string email, DateTime birthDate)
        {
            _name = name;
            _email = email;
            _birthDate = birthDate;

        }

        public override string ToString()
        {
            return _name
                + ", "
                + _birthDate.ToString("dd/MM/yyyy")
                + (" - ")
                + _email;
        }
    }
}

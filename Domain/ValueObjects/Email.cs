namespace Domain.ValueObjects
{
    public class Email
    {
        public string _email { get; set; }   

        public Email(string email)
        {
            this._email = email;
            //Cálculo mágico para validar EMAIL....
        }

        public override string ToString()
            => this._email;  
    }
}
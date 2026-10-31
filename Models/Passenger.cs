namespace TrainBooking.Models
{
    public class Passenger
    {
        private int Id { get; set; }

        private string _firstName;

        private string _lastName;

        public string FirstName { 
            get => _firstName; 
            set {
                _firstName = value;
            } 
        }

        public string LastName { 
            get => _lastName;
            set {
                _lastName = value;
            } 
        }

        public string Name { get => $"{_firstName} {_lastName}"; }
    }
}

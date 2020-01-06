using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Client
    {
        public Client()
        {

        }

        public Client(int clientId)
        {
            ClientId = clientId; 
        }

        public static int Counter { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int ClientId { get; private set; }

        public string FullName
        {
            get
            {
                string FullName = Name;

                if (!string.IsNullOrWhiteSpace(Surname))
                {
                    if (!string.IsNullOrWhiteSpace(FullName))
                    {
                        FullName += ' ';
                    }
                    FullName += Surname;
                }

                return FullName;
            }
        }

        public bool Validation(string property)
        {
            var correct = true;

            if (string.IsNullOrWhiteSpace(property))
            {
                return !correct;
            }
            return correct;
        }

        public bool SaveClient()
        {
            return true;
        }

        public Client GetClient(int ClientId)
        {
            return new Client();
        }

        public List<Client> GetClient()
        {
            return new List<Client>();
        }
    }
}

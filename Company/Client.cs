using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Client
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ClientId { get; set; }

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
    }
}

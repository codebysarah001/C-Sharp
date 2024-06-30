using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4
{
    public class information
    {
        public string name;
        public string email;
        public string gender;
        public string ID;
        public string phone;
        public int age;

        public information()
        {
            age = 23;
            gender = "Female";
            name = "Sarah";
            email = "sarahshorman001@gmail.com";
            ID = "2000337005";
            phone = "077315104";

        }

        public information(string name, string email, string gender, string iD, string phone, int age)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.ID = iD;
            this.phone = phone.StartsWith("077") || phone.StartsWith("078") || phone.StartsWith("079") ? phone : "0770000000";
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Phone: {phone}");
        }
    }
}

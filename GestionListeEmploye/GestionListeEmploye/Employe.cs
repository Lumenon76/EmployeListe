using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionListeEmploye
{
    public class Employe
    {
        private int id;
        private string firstname;
        private string lastname;
        private string post;
        private string adress;
        private int phone;

        public Employe(int id, string firstname, string lastname, string post, string adress, int phone)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.post = post;
            this.adress = adress;
            this.phone = phone;
        }

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Post { get => post; set => post = value; }
        public string Adress { get => adress; set => adress = value; }
        public int Phone { get => phone; set => phone = value; }

        public string Infos()
        {
            return id + "\n" + firstname + "\n" + lastname + "\n" + post + "\n" + adress + "\n" + phone;
        }
    }
}

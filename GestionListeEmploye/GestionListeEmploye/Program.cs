using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionListeEmploye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe unEmploye;
            unEmploye = new Employe(42,"Paul","Hamel","Dev","23 avenue de l'esplanade",0676588421);

            unEmploye.Id = 30;

            Console.WriteLine(unEmploye.Infos());

            Console.Write("Nouveau numero de telephone: ");
            unEmploye.Phone = int.Parse(Console.ReadLine());

            Console.WriteLine(unEmploye.Infos());

            Console.ReadLine();

            
        }
    }
}

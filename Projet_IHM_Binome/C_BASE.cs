using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.ComponentModel;

namespace Projet_IHM_Binome
{
   
    class C_BASE
    {
        public static int compteur;

        public BindingList<C_USER> Les_Users = new BindingList<C_USER>();

        public void Sauvegarde_Toi() // on sérialise Les_Users vers notre fichier JSON
        {
            string Donnees_serialisees = JsonSerializer.Serialize<BindingList<C_USER>>(Les_Users);
            File.WriteAllText("Mes_Users.json", Donnees_serialisees);
        }

        public void Charge_Toi() // On désérialise les donneés.
        {
            string Donnees_serialisees;

            if (File.Exists("Mes_Users.json") == true)
            {
                Donnees_serialisees = File.ReadAllText("Mes_Users.json");

                Les_Users = JsonSerializer.Deserialize<BindingList<C_USER>>(Donnees_serialisees);
            }
        }
    }
}

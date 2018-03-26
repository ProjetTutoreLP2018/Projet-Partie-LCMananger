using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Partie_LCMananger.Models
{
    public class LCManager
    {

        /*
         * Méthode qui permet la création d'une
         * LC.
         * Elle renvoi un booléen pour attester de la
         * réussite de la création
         * */
        public bool CreerLC(LC lc)
        {
            return false;
        }


        /*
         * Méthode qui permet la modification
         * d'une LC dans la base de données.
         * La LC est renvoyé aprés modification.
         * */
        public LC ModifierLC(LC lc)
        {
            return null;
        }


        /*
         * Méthode qui permet de retourner la liste
         * des LC de la base
         * */
        public List<LC> ConsulterLCs()
        {
            return null;
        }


        /*
         * Méthode qui permet de rechercher une LC
         * dans la base de données à partir de son ID
         * */
        public LC RechercherLC(int id)
        {
            return null;
        }


        /*
         * Méthode qui permet d'envoyer la 
         * LC au client
         * */
        public bool EnvoyerLCClient(LC lc, String emailClient)
        {
            return false;
        }


        /*
         * Méthode qui permet de signer la 
         * LC
         * */
        public bool SignerLC(LC lc, string signature)
        {
            return false;
        }


        /*
         * Méthode qui permet d'archiver une LC
         * dans la base de données
         * */
        public void ArchiverLC(LC lc)
        {
            
        }


        /*
         * Méthode qui permet de connaître le status
         * d'une LC
         * */
        public String ConsulterStatus(LC lc)
        {
            return null;
        }



        /*
         * Méthode qui permet de modifier le status
         * d'une LC
         * */
        public void ModifierStatus(LC lc, string status)
        {

        }


        /*
         * Méthode qui permet d'envoyer des notifications
         * au différents acteurs
         * */
        public void EnvoyerNotif(Notification notification, String droit)
        {

        }

    }
}
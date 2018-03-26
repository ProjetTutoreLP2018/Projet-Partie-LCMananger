using Projet_Partie_LCMananger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_Partie_LCMananger.Controllers
{
    public class LCController : Controller
    {
        private LCManager lcManager = new LCManager();

        public bool CreerLC(LC lc)
        {
            return lcManager.CreerLC(lc);
        }

        public LC ModifierLC(LC lc)
        {
            return lcManager.ModifierLC(lc);
        }

        public List<LC> ConsulterLCs()
        {
            return lcManager.ConsulterLCs();
        }

        public LC RechercherLC(int id)
        {
            return lcManager.RechercherLC(id);
        }

        public bool EnvoyerLCClient(LC lc, String emailClient)
        {
            return lcManager.EnvoyerLCClient(lc, emailClient);
        }

        public bool SignerLC(LC lc, string signature)
        {
            return lcManager.SignerLC(lc, signature);
        }

        public void ArchiverLC(LC lc)
        {
            lcManager.ArchiverLC(lc);
        }

        public String ConsulterStatus(LC lc)
        {
            return lcManager.ConsulterStatus(lc);
        }

        public void ModifierStatus(LC lc, string status)
        {
            lcManager.ModifierStatus(lc, status);
        }

        public void EnvoyerNotif(Notification notification, String droit)
        {
            lcManager.EnvoyerNotif(notification, droit);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexisGuyot_AlexandreLabrosse_CDAA.Modele
{
    /// <summary>
    /// Classe contenant quelques fonctions pour rendre l'affichage sur la console plus lisible
    /// </summary>
    public class Affichage
    {
        /*Les fonctions sont statiques car leur fonctionnement ne dépend pas 
         * d'une instance et de ses paramètres, il ne varie jamais.*/

        /// <summary>
        /// Trace une ligne de tirets pour délimiter deux zones
        /// </summary>
        /// <returns>Ligne de tirets</returns>
        public static string Delimiteur()
        {
            return "------------------------------------------------------------------------\n";
        }

        /// <summary>
        /// Met l'emphase sur un titre
        /// Equivalent à un '<h1>' en HTML
        /// </summary>
        /// <param name="titre">Mot ou groupe de mots à mettre en avant</param>
        /// <returns>Le paramètre entouré d'un délimiteur en haut et d'un en bas</returns>
        public static string Titre1(string titre)
        {
            return Delimiteur() + titre + "\n" + Delimiteur();
        }

        /// <summary>
        /// Format pour afficher une erreur
        /// </summary>
        /// <param name="erreur">Erreur soulevée par l'utilisateur</param>
        /// <returns>Cette même erreur mise en forme</returns>
        public static string Erreur(string erreur)
        {
            return "/!\\ Attention ! " + erreur + " /!\\";
        }

        /// <summary>
        /// Centre la ligne de texte passée en paramètre.
        /// </summary>
        /// <param name="s">Texte à centrer</param>
        /// <returns>Ligne centrée</returns>
        public static string Centrer(string s)
        {
            return s.PadLeft(Console.WindowWidth / 2 + s.Length / 2, ' ') + "\n".PadLeft(Console.WindowWidth / 2 - s.Length / 2, ' ');
        }
    }
}

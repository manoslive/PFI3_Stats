//--------------------------------------------------------------------------------------------
// PRODUCTION FINALE D’INTÉGRATION – PARTIE 3
// INFÉRENCE ET PROBABILITÉS
// Par Shaun Cooper & Emmanuel Beloin
//--------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal_Stats
{
    public partial class Form1 : Form
    {
        const int NbPointsAleatoires = 10000;
        double YMin = 0; //Ymin, Ymax qui est ajusté lorsqu'on click sur une fonction
        double YMax = 5;
        int numFonction = 1;
        const double AFonct1 = 24.9062, AFonct2 = 36.2815, AFonct3 = 94.1111, AFonct4 = 61.4956, AFonct5 = 32;//Aire différente pour chaque fonction
        const double ZAsur2 = 1.96f; // pour 95%; 
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------
        // Racine cubique
        //--------------------------------------------------------
        public double RacineCubique(double x)
        {
            if (x >= 0)
                return Math.Pow(x, 1.0 / 3.0f);
            else
                return -Math.Pow(-x, 1.0 / 3.0f);
        }

        //--------------------------------------------------------
        //Fonction #1
        //--------------------------------------------------------
        public bool Fonction1(double pointX, double pointY)
        {

            double premierePartie = Math.Pow(pointX, 2) - (16 * pointX) + 63;
            double deuxiemePartie = RacineCubique(premierePartie);
            double resultat = -(deuxiemePartie) + 4;

            return pointY <= resultat;
        }
        //--------------------------------------------------------
        //Fonction #2
        //--------------------------------------------------------
        public bool Fonction2(double pointX, double pointY)
        {
            double premierePartie = Math.Pow(((pointX - 7) / 5f), 5);
            double deuxiemePartie = Math.Pow(((pointX - 7) / 5f), 3);
            double resultat = (3 * premierePartie) - (5 * deuxiemePartie) + 3;

            return pointY <= resultat;
        }
        //--------------------------------------------------------
        //Fonction #3
        //--------------------------------------------------------
        public bool Fonction3(double pointX, double pointY)
        {
            double resultat = -(1 / 3f) * (Math.Pow((pointX - 6), 2)) + 12;

            return pointY <= resultat;
        }
        //--------------------------------------------------------
        //Fonction #4
        //--------------------------------------------------------
        public bool Fonction4(double pointX, double pointY)
        {
            double resultat = pointX + Math.Sin(pointX);

            return pointY <= resultat;
        }
        //--------------------------------------------------------
        //Fonction #5
        //--------------------------------------------------------
        public bool Fonction5(double pointX, double pointY)
        {
            double resultat = Math.Cos(pointX) + 3;

            return pointY <= resultat;
        }
        //--------------------------------------------------------
        // Calculer l'intervalle de confiance de avec une 
        // confiance de 95% et la marge d'erreur
        //--------------------------------------------------------
        public void CalculerConfiance(double p, double aire)
        {
            String min, max;
            double ME = 0;
            double laPartie = (p * (1 - p)) / NbPointsAleatoires;

            // Calcul de la marge d'erreur
            ME = ZAsur2 * Math.Sqrt(laPartie);
            min = (aire - (aire * ME)).ToString();
            max = (aire + (aire * ME)).ToString();

            // On affiche la ME
            TB_ME.Text = (ME.ToString()).Substring(0, 6);
            // On affiche l'intervalle de confiance
            LB_IntervalleConfiance.Text = min.Substring(0, 6) + " < x < " + max.Substring(0, 6);
        }
        //--------------------------------------------------------
        // Calculer la probabilité de P(a<X<b)
        //--------------------------------------------------------
        public void CalculerProbabilite(double aireEntreLesBornes)
        {
            double resultatAire = 0;
            String resultatAireString = "";
            switch (numFonction)
            {
                case 1:
                    resultatAire = aireEntreLesBornes / AFonct1;
                    break;
                case 2:
                    resultatAire = aireEntreLesBornes / AFonct2;
                    break;
                case 3:
                    resultatAire = aireEntreLesBornes / AFonct3;
                    break;
                case 4:
                    resultatAire = aireEntreLesBornes / AFonct4;
                    break;
                case 5:
                    resultatAire = aireEntreLesBornes / AFonct5;
                    break;
            }
            if ((resultatAire * 100) < 100)
            {
                resultatAireString = (resultatAire * 100).ToString();
                if (resultatAireString.Length > 7)
                    resultatAireString = resultatAireString.Substring(0, 7) + "%";
                else
                    resultatAireString += "%";
            }
            else
                resultatAireString = "100%";

            LB_Probabilite.Text = resultatAireString;

        }
        //--------------------------------------------------------
        // Calculer les 10000 points
        //--------------------------------------------------------
        public void CalculerPoints()
        {
            int pointInterieure = 0;
            double pointX, pointY;
            Random rand = new Random();
            for (int i = 0; i < NbPointsAleatoires; i++)
            {
                var next1 = rand.NextDouble();
                var next2 = rand.NextDouble();
                pointX = (double)NUD_BorneA.Value + (next1 * (double)NUD_BorneB.Value - (double)NUD_BorneA.Value);
                pointY = (double)YMin + (next2 * (double)YMax - (double)YMin);
                switch (numFonction)
                {
                    case 1:
                        if (Fonction1(pointX, pointY))
                            pointInterieure++;
                        break;
                    case 2:
                        if (Fonction2(pointX, pointY))
                            pointInterieure++;
                        break;
                    case 3:
                        if (Fonction3(pointX, pointY))
                            pointInterieure++;
                        break;
                    case 4:
                        if (Fonction4(pointX, pointY))
                            pointInterieure++;
                        break;
                    case 5:
                        if (Fonction5(pointX, pointY))
                            pointInterieure++;
                        break;
                }
            }
            // Calcul de Pi + affichage
            double pi = Convert.ToDouble(pointInterieure) / NbPointsAleatoires;
            LB_Pi.Text = pi.ToString();

            // Calcul de A'
            double aire = ((Convert.ToDouble(pointInterieure) / NbPointsAleatoires) * (Convert.ToDouble(NUD_BorneB.Value - NUD_BorneA.Value) * YMax));

            CalculerConfiance(pi, aire);
            CalculerProbabilite(aire);
        }
        //--------------------------------------------------------
        // Initialiser les bornes selon la fonction sélectionnée
        //--------------------------------------------------------
        public void SetBornes(int laFonction)
        {
            switch (laFonction)
            {
                case 1:
                    numFonction = 1;
                    YMin = 0;
                    YMax = 5;
                    LB_Ymin.Text = YMin.ToString();
                    LB_Ymax.Text = YMax.ToString();
                    break;
                case 2:
                    numFonction = 2;
                    YMin = 0;
                    YMax = 5;
                    LB_Ymin.Text = YMin.ToString();
                    LB_Ymax.Text = YMax.ToString();
                    break;
                case 3:
                    numFonction = 3;
                    YMin = 0;
                    YMax = 12;
                    LB_Ymin.Text = YMin.ToString();
                    LB_Ymax.Text = YMax.ToString();
                    break;
                case 4:
                    numFonction = 4;
                    YMin = 0;
                    YMax = 10;
                    LB_Ymin.Text = YMin.ToString();
                    LB_Ymax.Text = YMax.ToString();
                    break;
                case 5:
                    numFonction = 5;
                    YMin = 0;
                    YMax = 4;
                    LB_Ymin.Text = YMin.ToString();
                    LB_Ymax.Text = YMax.ToString();
                    break;
            }
        }
        //--------------------------------------------------------
        // Click du boutton calculer
        // -déclanche les fonctions de calculs
        //--------------------------------------------------------
        private void BTN_Calculer_Click(object sender, EventArgs e)
        {
            CalculerPoints();
        }
        //--------------------------------------------------------
        // Fonctions des contrôles
        // -Numeric up down
        // -Radio button (fonction click)
        //--------------------------------------------------------
        private void PB_Fonction1_Click(object sender, EventArgs e)
        {
            RB_Fonction1.Select();
            SetBornes(1);
            CalculerPoints();
        }
        private void PB_Fonction2_Click(object sender, EventArgs e)
        {
            RB_Fonction2.Select();
            SetBornes(2);
            CalculerPoints();
        }
        private void PB_Fonction3_Click(object sender, EventArgs e)
        {
            RB_Fonction3.Select();
            SetBornes(3);
            CalculerPoints();
        }
        private void PB_Fonction4_Click(object sender, EventArgs e)
        {
            RB_Fonction4.Select();
            SetBornes(4);
            CalculerPoints();
        }
        private void PB_Fonction5_Click(object sender, EventArgs e)
        {
            RB_Fonction5.Select();
            SetBornes(5);
            CalculerPoints();
        }
        private void NUD_BorneB_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_BorneA.Value > NUD_BorneB.Value)
            {
                NUD_BorneB.Value = NUD_BorneA.Value;
            }
        }
        private void NUD_BorneA_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_BorneA.Value > NUD_BorneB.Value)
            {
                NUD_BorneB.Value = NUD_BorneA.Value;
            }
        }

        private void RB_Fonction1_CheckedChanged(object sender, EventArgs e)
        {
            SetBornes(1);
            CalculerPoints();
        }

        private void RB_Fonction2_CheckedChanged(object sender, EventArgs e)
        {
            SetBornes(2);
            CalculerPoints();
        }

        private void RB_Fonction3_CheckedChanged(object sender, EventArgs e)
        {
            SetBornes(3);
            CalculerPoints();
        }

        private void RB_Fonction4_CheckedChanged(object sender, EventArgs e)
        {
            SetBornes(4);
            CalculerPoints();
        }

        private void RB_Fonction5_CheckedChanged(object sender, EventArgs e)
        {
            SetBornes(5);
            CalculerPoints();
        }
    }
}

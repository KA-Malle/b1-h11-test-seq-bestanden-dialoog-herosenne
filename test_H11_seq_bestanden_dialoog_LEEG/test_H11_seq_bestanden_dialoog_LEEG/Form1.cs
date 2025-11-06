using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_H11_seq_bestanden_dialoog_LEEG
{
    public partial class Form1 : Form
    {
        private string[] _steden = {"Lille", "Schilde", "Turnhout", "Geel", "Mol", "Deurne", "Wilrijk", "Herentals" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenereer_Click(object sender, EventArgs e)
        {
            // resultaten leegmaken
            txtResultaat.Text = "";

            // Declaratie
            Random willekeurige = new Random();
            int[] temp = {15, 24, 21, 14, 16};
            

            // txt resultaten vullen
            foreach (var item in _steden)
            {
                
                // dorp neerschrijven
                txtResultaat.Text += item + " ";
                

                for (int i = 0; i < 5; i++)
                {
                    // random temp genereren
                    // vergeten :(

                    // temperatuur neerschrijven
                    txtResultaat.Text += temp[i] + " ";
                }

                // Nieuwe lijn beginnen voor volgende stad
                txtResultaat.Text += "\r\n";

            }

            // het document zonnedagen aanmaken
            using (StreamWriter schrijf = new StreamWriter("zonnedagen.txt", false))
            {
                foreach (var item in _steden)
                {
                    schrijf.Write(item + ",");

                    for (int i = 0; i < 5; i++)
                    {
                        schrijf.Write(temp[i] + ",");
                    }

                    schrijf.WriteLine("");

                }// einde for each

            }// einde streamwriter

        }// einde genereren

        private void btnVerwerken_Click(object sender, EventArgs e)
        {
            // resultaten leegmaken
            txtResultaat.Text = "";
            // declaratie
            string volledigelijn;
            string[] lijnGesplit;

            // algemeen
            string stad, warmsteStad= "", koudsteStad = "";
            decimal temp1, temp2, temp3, temp4, temp5, gemiddelde, hoogsteTemp = 0, laagsteTemp = 25;
            

            // zonnedagen bestand uitlezen
            using(StreamReader streamlees = new StreamReader("zonnedagen.txt"))
            {
                // het bestand uitlezen
                while (streamlees.Peek() != -1)
                {
                    // lezen en splitsen
                    volledigelijn = streamlees.ReadLine();
                    lijnGesplit = volledigelijn.Split(',');

                    // gegevens opslaan
                    stad = lijnGesplit[0];
                    temp1 = Convert.ToDecimal(lijnGesplit[1]);
                    temp2 = Convert.ToDecimal(lijnGesplit[2]);
                    temp3 = Convert.ToDecimal(lijnGesplit[3]);
                    temp4 = Convert.ToDecimal(lijnGesplit[4]);
                    temp5 = Convert.ToDecimal(lijnGesplit[5]);

                    // gemiddelde berekenen
                    gemiddelde = temp1 + temp2 + temp3 + temp4 + temp5;
                    gemiddelde = gemiddelde / 5;

                    // de stad en temperaturen neer schrijven
                    txtResultaat.Text += stad + " " + temp1 + " " + temp2 + " " + temp3 + " " + temp4 + " " + temp5 + "\t " + gemiddelde + " °C";
                    txtResultaat.Text += "\r\n";

                    // hoogts temperatuur krijgen
                    if (gemiddelde > hoogsteTemp)
                    {
                        // warmste temp aangeven
                        hoogsteTemp = gemiddelde;

                        // warmste stad aangeven
                        warmsteStad = stad;
                    }


                    // laagste temperatuur berekenen
                    if (gemiddelde < laagsteTemp)
                    {
                        // koudste temp aangeven
                        laagsteTemp = gemiddelde;
                        // koudste stad aangeven
                        koudsteStad = stad;
                    }


                }// einde streamlees
                
                // de laagste en hoogste temp opschrijven
                txtResultaat.Text += "\r\n";
                txtResultaat.Text += "De laagtse temperatuur was " + laagsteTemp + " °C in " + koudsteStad;
                txtResultaat.Text += "\r\n";
                txtResultaat.Text += "De hoogste temperatuur was " + hoogsteTemp + " °C in " + warmsteStad;


            }// einde streamReader

            // het bestand verwerkt neerschrijven
            using (StreamWriter schrijf = new StreamWriter("verwerkt.txt", false))
            {
                // de steden en gemiddelde temp neerschrijven
                for (int i = 0; i < 8; i++)
                {
                    // neerschrijven
                    schrijf.WriteLine("\"...\",...");

                }// einde for lus




            }// einde streamwriter


        }// Einde verwerking
        

        

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            // applicatie sluiten
            Application.Exit();
        }
    }
}

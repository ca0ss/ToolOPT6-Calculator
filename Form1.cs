﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToolOPT6_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;
            cmb1EYE.SelectedIndex = 3;
            cmb2Star.SelectedIndex = 0;
            cmb3AdaptiveDim.SelectedIndex = 1;
            cmb4Adaptive.SelectedIndex = 0; 
            cmb5ECO.SelectedIndex = 12;
            cmb6Sound.SelectedIndex = 0;
            cmb7ISF.SelectedIndex = 1;
            cmb8SETID.SelectedIndex = 1;
            cmb9ATV.SelectedIndex = 0;
            cmbADVR.SelectedIndex = 0;
            cmbBAudio.SelectedIndex = 0;
            cmbCWIFIBT.SelectedIndex = 2;
            cmbDWifiAssy.SelectedIndex = 3;
            cmbEREMOCON.SelectedIndex = 1;
            cmbFAudio.SelectedIndex = 0;
            cmbGEDID.SelectedIndex = 1;
            cmbHWISA.SelectedIndex = 0;

            Encode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decode();
           // string TMP = Convert.ToString(txtToolOPT6.Text, 2);//.PadLeft(30, '0');


        }

        private void Decode()
        {
            try
            {

                int numeroDecimale = int.Parse(txtToolOPT6.Text);
                string numeroBinario = Convert.ToString(numeroDecimale, 2).PadLeft(30, '0'); 
                lblBinary.Text = numeroBinario;
                cmb1EYE.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(28, 2));
                cmb2Star.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(27, 1));
                cmb3AdaptiveDim.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(26, 1));
                cmb4Adaptive.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(22, 4));
                cmb5ECO.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(18, 4));
                cmb6Sound.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(16, 2));
                cmb7ISF.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(15, 1));
                cmb8SETID.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(14, 1));
                cmb9ATV.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(13, 1));
                cmbADVR.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(12, 1));
                cmbBAudio.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(11, 1));
                cmbCWIFIBT.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(9, 2));
                cmbDWifiAssy.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(6, 3));
                cmbEREMOCON.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(5, 1));
                cmbFAudio.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(3, 2));
                cmbGEDID.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(1, 2));
                cmbHWISA.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(0, 1));
            }
            catch
            {
                MessageBox.Show("Invalid Input", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

            private void Encode()
        {
            string EYE = Convert.ToString(cmb1EYE.SelectedIndex, 2).PadLeft(2, '0');
            string STAR = Convert.ToString(cmb2Star.SelectedIndex, 2);
            string ADAPTIVEDIM = Convert.ToString(cmb3AdaptiveDim.SelectedIndex, 2);
            string ADAPTIVE = Convert.ToString(cmb4Adaptive.SelectedIndex, 2).PadLeft(4, '0');
            string ECO = Convert.ToString(cmb5ECO.SelectedIndex, 2).PadLeft(4, '0');
            string SOUND = Convert.ToString(cmb6Sound.SelectedIndex, 2).PadLeft(2, '0');
            string ISF = Convert.ToString(cmb7ISF.SelectedIndex, 2);
            string SETID = Convert.ToString(cmb8SETID.SelectedIndex);
            string ATV = Convert.ToString(cmb9ATV.SelectedIndex, 2);
            string DVR = Convert.ToString(cmbADVR.SelectedIndex, 2);
            string AUDIO = Convert.ToString(cmbBAudio.SelectedIndex, 2);
            string WIFI = Convert.ToString(cmbCWIFIBT.SelectedIndex, 2).PadLeft(2, '0');
            string WIFIASSY = Convert.ToString(cmbDWifiAssy.SelectedIndex, 2).PadLeft(3, '0');
            string REMOCON = Convert.ToString(cmbEREMOCON.SelectedIndex, 2);
            string AUDIOEQ = Convert.ToString(cmbFAudio.SelectedIndex, 2).PadLeft(2, '0');
            string EDID = Convert.ToString(cmbGEDID.SelectedIndex, 2).PadLeft(2, '0');
            string WISA = Convert.ToString(cmbHWISA.SelectedIndex, 2).PadLeft(1, '0');
            
            string OPTCODE = WISA + EDID + AUDIOEQ + REMOCON + WIFIASSY + WIFI + AUDIO + DVR + ATV + SETID + ISF + SOUND + ECO + ADAPTIVE + ADAPTIVEDIM + STAR + EYE;

            //MessageBox.Show(OPTCODE.ToString());
            lblBinary.Text = OPTCODE;
            txtToolOPT6.Text = ConvertiBinarioInDecimale(OPTCODE).ToString();
        }

        private int ConvertiBinarioInDecimale(string binario)
        {
            int decimale = 0;
            int lunghezza = binario.Length;

            for (int i = 0; i < lunghezza; i++)
            {
                char cifra = binario[i];
                int valoreCifra = cifra - '0'; // Converte il carattere in un valore numerico (0 o 1)
                int posizione = lunghezza - i - 1; // Calcola la posizione della cifra, partendo dalla destra

                decimale += valoreCifra * (int)Math.Pow(2, posizione); // Aggiorna il valore decimale
            }

            return decimale;
        }

        private void cmb1EYE_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmbHWISA_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmbGEDID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmbFAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmbEREMOCON_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmbDWifiAssy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmbCWIFIBT_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmbBAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmbADVR_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmb9ATV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmb8SETID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmb7ISF_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmb6Sound_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmb5ECO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmb4Adaptive_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmb3AdaptiveDim_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmb2Star_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }



        private void txtToolOPT6_TextChanged(object sender, EventArgs e)
        {
            //Decode();
        //if(int.Parse(txtToolOPT6.Text) <= 903344063)
          //  {
               lblBinary.Text = Convert.ToString(long.Parse(txtToolOPT6.Text), 2).PadLeft(30, '0');
         //   }
       // else
        //    {
        //        txtToolOPT6.Text = "903344063";
         //       lblBinary.Text = Convert.ToString(int.Parse(txtToolOPT6.Text), 2).PadLeft(30, '0');
         //   }
        }

        private void txtToolOPT6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

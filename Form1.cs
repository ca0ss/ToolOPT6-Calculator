using System;
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
        public int TMP = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //My tv Original Settings :P
            cmbSeries.SelectedIndex = 0;
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
            cmbIMARK.SelectedIndex = 0;
            this.Size = new Size(371, 728);

            Encode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decode();
        }

        private void Decode()
        {
            try
            {

                int numeroDecimale = int.Parse(txtToolOPT6.Text);

                //old static 30 digit code
                // string numeroBinario = Convert.ToString(numeroDecimale, 2).PadLeft(30, '0');

                //implementing G3/C2/UN7300 Encoding 

                // UN7300 is experimental and i use placeholder for that. i need a real test, for now all photo i find online make me think that my guess are correct 
                string numeroBinario = "";
                if (cmbSeries.SelectedIndex != 0) { numeroBinario = Convert.ToString(numeroDecimale, 2).PadLeft(31, '0'); } //original if was (cmbSeries.SelectedIndex == 1 ||cmbSeries.SelectedIndex == 2 ||cmbSeries.SelectedIndex == 3), keep there for future encoding
                else if (cmbSeries.SelectedIndex == 0) { numeroBinario = Convert.ToString(numeroDecimale, 2).PadLeft(30, '0'); }
                
                lblBinary.Text = InsertSpacesFromRight(numeroBinario, 4);

                cmb1EYE.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 2), 2));
                cmb2Star.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 3), 1));
                cmb3AdaptiveDim.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 4), 1));
                cmb4Adaptive.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 8), 4));
                cmb5ECO.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 12), 4));
                cmb6Sound.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 14), 2));
                cmb7ISF.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 15), 1));
                cmb8SETID.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 16), 1));
                cmb9ATV.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 17), 1));
                cmbADVR.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 18), 1));
                cmbBAudio.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 19), 1));
                cmbCWIFIBT.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 21), 2));
                //implementing G3/c2 encoding
                if (cmbSeries.SelectedIndex == 0)
                { //u7500 value of WiFi ASSY has 3 bit
                    cmbDWifiAssy.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(6, 3));
                    cmbEREMOCON.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(5, 1));
                    cmbFAudio.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(3, 2));
                    cmbGEDID.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(1, 2));
                    cmbHWISA.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(0, 1));
                }
                else if (cmbSeries.SelectedIndex == 1)
                {//G3 value of WiFi ASSY has 4 bit
                    cmbDWifiAssy.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(6, 4));
                    cmbEREMOCON.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(5, 1));
                    cmbFAudio.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(3, 2));
                    cmbGEDID.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(1, 2));
                    cmbHWISA.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(0, 1));
                }
                else if (cmbSeries.SelectedIndex == 2)
                { //c2 value of WiFi ASSY has 3 bit but the resulting string still 31 bit long for MARKONE WIFI bit
                    cmbDWifiAssy.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(7, 3));
                    cmbEREMOCON.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(6, 1));
                    cmbFAudio.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(4, 2));
                    cmbGEDID.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(2, 2));
                    cmbHWISA.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(1, 1));
                    cmbIMARK.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(0, 1));
                }
                else if (cmbSeries.SelectedIndex == 3 || cmbSeries.SelectedIndex == 4) //un7300 and um7050 experimental support
                {
                    cmbEREMOCON.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(8, 1));
                    //this should stay 0
                    int TMPWIFIASSY = ConvertiBinarioInDecimale(numeroBinario.Substring(5, 3));
                    if (TMPWIFIASSY != 0) { MessageBox.Show("If you are reading this, there is something wrong with the code you input. Please contact me on GitHub or t.me/Ca0ss93", "Error"); }
                    cmbDWifiAssy.SelectedIndex = 0;
                    cmbFAudio.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(3, 2));
                    cmbGEDID.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(1, 2));
                    cmbHWISA.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(0, 1));

                }

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

            //implementing un7300 experimental support, idk if it have more wify type. should have 3 bit dedicated, maybe 5 option
            if (cmbSeries.SelectedIndex == 3 || cmbSeries.SelectedIndex == 4) { WIFI = Convert.ToString(cmbCWIFIBT.SelectedIndex, 2).PadLeft(3, '0'); }
            
            string WIFIASSY = "000"; //implementing un7300 and um7050 experimental support, there is no WiFi Assy type, ovewer in the photo i find online there is always this 3 zero pattern

            //implementing G3 Encoding
            if (cmbSeries.SelectedIndex == 1) { WIFIASSY = Convert.ToString(cmbDWifiAssy.SelectedIndex, 2).PadLeft(4, '0'); }
            else if (cmbSeries.SelectedIndex == 0 || cmbSeries.SelectedIndex == 2) { WIFIASSY = Convert.ToString(cmbDWifiAssy.SelectedIndex, 2).PadLeft(3, '0'); }

            //not specify what appen if selected index was 3 or 4 bc already 000 and unused

            string REMOCON = Convert.ToString(cmbEREMOCON.SelectedIndex, 2);
            string AUDIOEQ = Convert.ToString(cmbFAudio.SelectedIndex, 2).PadLeft(2, '0');
            string EDID = Convert.ToString(cmbGEDID.SelectedIndex, 2).PadLeft(2, '0');
            string WISA = Convert.ToString(cmbHWISA.SelectedIndex, 2).PadLeft(1, '0');

            //implementing C2 Encoding
            string MARKONE = "";

            if (cmbSeries.SelectedIndex == 2)
            {
                MARKONE = Convert.ToString(cmbIMARK.SelectedIndex, 2).PadLeft(1, '0');
            }
            
            string OPTCODE = MARKONE + WISA + EDID + AUDIOEQ + REMOCON + WIFIASSY + WIFI + AUDIO + DVR + ATV + SETID + ISF + SOUND + ECO + ADAPTIVE + ADAPTIVEDIM + STAR + EYE;


            if (cmbSeries.SelectedIndex == 3 || cmbSeries.SelectedIndex == 4)  //implementing un7300 and um7050 experimental support, WIFI Assy Zeroed and Remocon have switched places
            {
                OPTCODE = WISA + EDID + AUDIOEQ + WIFIASSY + REMOCON + WIFI + AUDIO + DVR + ATV + SETID + ISF + SOUND + ECO + ADAPTIVE + ADAPTIVEDIM + STAR + EYE;
            }
                            
            lblBinary.Text = InsertSpacesFromRight(OPTCODE, 4);
            txtToolOPT6.Text = ConvertiBinarioInDecimale(OPTCODE).ToString();
        }

        static string InsertSpacesFromRight(string input, int interval)
        {
              if (string.IsNullOrEmpty(input) || interval <= 0) { return input; }

        int length = input.Length;
        int spacesCount = (length - 1) / interval;
        char[] resultArray = new char[length + spacesCount];
        int resultIndex = resultArray.Length - 1;
        int inputIndex = length - 1;

        for (int i = 0; i < length; i++)
        {
            resultArray[resultIndex--] = input[inputIndex--];

            if ((i + 1) % interval == 0 && i != length - 1)
            {
                resultArray[resultIndex--] = ' ';
            }
        }

        return new string(resultArray);
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
            if (txtToolOPT6.Text == "")
            {
                txtToolOPT6.Text = "0";
                txtToolOPT6.SelectAll();
            }

            if (cmbSeries.SelectedIndex == 0)
            {
                lblBinary.Text = InsertSpacesFromRight(Convert.ToString(long.Parse(txtToolOPT6.Text), 2).PadLeft(30, '0'), 4);
            }
            else if (cmbSeries.SelectedIndex != 0)
            {
                lblBinary.Text = InsertSpacesFromRight(Convert.ToString(long.Parse(txtToolOPT6.Text), 2).PadLeft(31, '0'), 4);
            }
        }

        private void txtToolOPT6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
           //WiFi ASSY Changer, I should check the type avaiable for other series. UP and G3 are checked, other not
            if (cmbSeries.SelectedIndex == 1 && cmbDWifiAssy.Items.Count == 7) //G3 Serie
            {
                //adding G3 items on WIFI ASSY
                cmbDWifiAssy.Items.Add("Single_22Y");
                cmbDWifiAssy.Items.Add("M_Single_22Y");
                cmbDWifiAssy.Items.Add("Dual_23Y");
                cmbDWifiAssy.Items.Add("Single_23Y");
            }
            else if(cmbSeries.SelectedIndex != 1 && cmbDWifiAssy.Items.Count != 7)
            {
                //removing G3 items on WIFI ASSY
                cmbDWifiAssy.SelectedIndex = 0;
                cmbDWifiAssy.Items.RemoveAt(cmbDWifiAssy.Items.Count - 1);
                cmbDWifiAssy.Items.RemoveAt(cmbDWifiAssy.Items.Count - 1);
                cmbDWifiAssy.Items.RemoveAt(cmbDWifiAssy.Items.Count - 1);
                cmbDWifiAssy.Items.RemoveAt(cmbDWifiAssy.Items.Count - 1);
            }

            //Reverting UM7050 items
            if (cmbSeries.SelectedIndex != 4 && label15.Text != "Audio EQ/ EYE")
            {
                label15.Text = "Audio EQ/ EYE";
                cmbFAudio.Items.Clear();
                cmbFAudio.Items.Add("Default");
                cmbFAudio.Items.Add("Type 1");
                cmbFAudio.Items.Add("Type 2");
                cmbFAudio.SelectedIndex = 0;
            }
            if (cmbSeries.SelectedIndex != 4 && cmbCWIFIBT.Items[1].ToString() != "Dual Combo MTK")
            {
                TMP = cmbCWIFIBT.SelectedIndex;
                cmbCWIFIBT.Items.Clear();
                cmbCWIFIBT.Items.Add("None");
                cmbCWIFIBT.Items.Add("Dual Combo MTK");
                cmbCWIFIBT.Items.Add("WiFi_BT");
                cmbCWIFIBT.SelectedIndex = TMP;
            }


            //restoring stuff for UN7300 and UM7050 implementation
            if (cmbSeries.SelectedIndex != 4 && cmbSeries.SelectedIndex != 3)
            {
                label17.Visible = true;
                cmbDWifiAssy.Visible = true;
                label18.Text = "WiFi/BT";
                label16.Location = new Point(25, 550);
                label15.Location = new Point(25, 583);
                label14.Location = new Point(25, 618);
                label13.Location = new Point(25, 653);
                cmbEREMOCON.Location = new Point(157, 547);
                cmbFAudio.Location = new Point(157, 580);
                cmbGEDID.Location = new Point(157, 615);
                cmbHWISA.Location = new Point(157, 650);
            }
            else //UN7300 and UM7050 implementation
            {
                label18.Text = "WiFi";
                label17.Visible = false;
                cmbDWifiAssy.Visible = false;
                label16.Location = new Point(25, 517);
                label15.Location = new Point(25, 550);
                label14.Location = new Point(25, 583);
                label13.Location = new Point(25, 618);
                cmbEREMOCON.Location = new Point(157, 514);
                cmbFAudio.Location = new Point(157, 547);
                cmbGEDID.Location = new Point(157, 580);
                cmbHWISA.Location = new Point(157, 615);
                this.Size = new Size(371, 693);
            }

            //restoring EDID Items for  u7500, C26, un7300 Series
            if (cmbSeries.SelectedIndex != 1 && cmbSeries.SelectedIndex != 4)
            {
                cmbGEDID.Items.Clear();
                cmbGEDID.Items.Add("pcm");
                cmbGEDID.Items.Add("ac3");
                cmbGEDID.Items.Add("TrueHD");
                cmbGEDID.SelectedIndex = 0;
            }

            //Show MarkOne only when c26 is selected
            if (cmbSeries.SelectedIndex != 2)
            {
                label21.Visible = false;
                cmbIMARK.Visible = false;
            }
            else
            {
                label21.Visible = true;
                cmbIMARK.Visible = true;
                this.Size = new Size(371, 768);
            }

            //Adjust Name for C26 Series
            if (cmbSeries.SelectedIndex != 1)
            {
                label6.Text = "ECO Default Backlight";
            }

            //Adjust Size for UP75 and G3
            if (cmbSeries.SelectedIndex == 0 || cmbSeries.SelectedIndex == 1)
            {
                this.Size = new Size(371, 728);
            }

            if (cmbSeries.SelectedIndex == 1) //G3 Series
            {
                //removing EDID and adding G3 EDID items
                cmbGEDID.Items.Clear();
                cmbGEDID.Items.Add("ac3");
                cmbGEDID.Items.Add("ac3+dts");
                cmbGEDID.Items.Add("TrueHD");
                cmbGEDID.Items.Add("TrueHD+dts");
                cmbGEDID.SelectedIndex = 0;

                //changing Backlight name according to G3 menu
                label6.Text = "Default Backlight";

            }
            else if (cmbSeries.SelectedIndex == 4)  //um7050 implementation
            {
                //removing other series EDID and adding um7050 items
                //i don't find photo of EDID items different from DTS or TrueHD but i find some russian notepad
                cmbGEDID.Items.Clear();
                cmbGEDID.Items.Add("pcm");
                cmbGEDID.Items.Add("ac3");
                cmbGEDID.Items.Add("DTS");
                cmbGEDID.Items.Add("TrueHD");
                cmbGEDID.SelectedIndex = 0;

                //changing names according to um7050 menu
                label15.Text = "EYE Curve Derivation";

                //adding initial curve experimental support
                cmbFAudio.Items.Clear();
                cmbFAudio.Items.Add("Initial Curve"); // should be 2 bit
                cmbFAudio.Items.Add("Unknown !EXP!"); //adding 2 place holder for calculation and reverse reason. i need more research on a real tv
                cmbFAudio.Items.Add("Unknown1 !EXP!"); //i don't find any photo online of value != "initial curve"
                cmbFAudio.SelectedIndex = 0;

                TMP = cmbCWIFIBT.SelectedIndex;
                cmbCWIFIBT.Items.Clear();
                cmbCWIFIBT.Items.Add("None"); //000 "none" according to other models, still experiment, maybe there are more
                cmbCWIFIBT.Items.Add("Dual_combo_mtk");//001
                cmbCWIFIBT.Items.Add("11ac_only_rtk"); //010
                cmbCWIFIBT.SelectedIndex = TMP;
            }

                Encode();
        }

        private void cmbIMARK_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

    }
}

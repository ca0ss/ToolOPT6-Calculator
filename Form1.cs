using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            //implementing error control

            int input = 0;
            try
            {
                input = int.Parse(txtToolOPT6.Text);
            }
            catch 
            {
                input = 0;
            }


            if (cmbSeries.SelectedIndex == 0 && input > 937422783)
            {
                MessageBox.Show("The value that you entered " + txtToolOPT6.Text + " is bigger than the maximum value for this series of tv that is 937422783. \r\nIf you input the value from your tv, probably you enter a wrong tv series or there is an error. \r\nPlease don't use the code on your tv and wrote me on t.me/Ca0ss93 or open a issue on GitHub", "Error");
                txtToolOPT6.Text = "937422783"; //this is the maximum value for this series 
                input = 937422783;
            }
            else if (cmbSeries.SelectedIndex == 1 && input > 2136469439)
            {
                MessageBox.Show("The value that you entered " + txtToolOPT6.Text + " is bigger than the maximum value for this series of tv that is 2136469439. \r\nIf you input the value from your tv, probably you enter a wrong tv series or there is an error. \r\nPlease don't use the code on your tv and wrote me on t.me/Ca0ss93 or open a issue on GitHub", "Error");
                txtToolOPT6.Text = "2136469439";
                input = 2136469439;
            }
            else if (cmbSeries.SelectedIndex == 2 && input > 2010640319)
            {
                MessageBox.Show("The value that you entered " + txtToolOPT6.Text + " is bigger than the maximum value for this series of tv that is 2010640319. \r\nIf you input the value from your tv, probably you enter a wrong tv series or there is an error. \r\nPlease don't use the code on your tv and wrote me on t.me/Ca0ss93 or open a issue on GitHub", "Error");
                txtToolOPT6.Text = "2010640319";
                input = 2010640319;
            }
            else if (cmbSeries.SelectedIndex == 3 && input > 1876946879) //i leave the space for input a value having the 000 pattern altered, just to show alert to user
            {
                MessageBox.Show("The value that you entered " + txtToolOPT6.Text + " is bigger than the theoretical maximum value for this series of tv that is 1876946879. \r\nIf you input the value from your tv, probably you enter a wrong tv series or there is an error. \r\nPlease don't use the code on your tv and wrote me on t.me/Ca0ss93 or open a issue on GitHub", "Error");
                txtToolOPT6.Text = "1876946879"; //the maximum value leaving 000 pattern is 1818226623
                input = 1876946879;
            }
            else if (cmbSeries.SelectedIndex == 4 && input > 2078797759) //i leave the space for input a value having the 000 pattern altered, just to show alert to user
            {
                MessageBox.Show("The value that you entered " + txtToolOPT6.Text + " is bigger than the theoretical maximum value for this series of tv that is 2078797759. \r\nIf you input the value from your tv, probably you enter a wrong tv series or there is an error. \r\nPlease don't use the code on your tv and wrote me on t.me/Ca0ss93 or open a issue on GitHub", "Error");
                txtToolOPT6.Text = "2078797759"; //the maximum value leaving 000 pattern is 2020077503
                input = 2078797759;
            }
            else if (cmbSeries.SelectedIndex == 5 && input > 2078797759) //
            {
                MessageBox.Show("The value that you entered " + txtToolOPT6.Text + " is bigger than the theoretical maximum value for this series of tv that is CHANGE HERE. \r\nIf you input the value from your tv, probably you enter a wrong tv series or there is an error. \r\nPlease don't use the code on your tv and wrote me on t.me/Ca0ss93 or open a issue on GitHub", "Error");
                txtToolOPT6.Text = "2078797759"; 
                input = 2078797759;
            }


            Decode(input);
        }

        private void Decode(int numeroDecimale)
        {
            try
            {

                //int numeroDecimale = int.Parse(txtToolOPT6.Text);

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

                if (cmbSeries.SelectedIndex == 3 || cmbSeries.SelectedIndex == 4) //un7300 and um7050 support
                {
                    cmbCWIFIBT.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(9, 3)); //wifi have 3 bit on this series
                } else
                {
                    cmbCWIFIBT.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring((numeroBinario.Length - 21), 2));
                }

                //implementing G3/c2 encoding
                if (cmbSeries.SelectedIndex == 0)
                { //u7500 value of WiFi ASSY has 3 bit
                    cmbDWifiAssy.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(6, 3));
                    cmbEREMOCON.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(5, 1));
                    cmbFAudio.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(3, 2));
                    cmbGEDID.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(1, 2));
                    cmbHWISA.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(0, 1));
                }
                else if (cmbSeries.SelectedIndex == 1 || cmbSeries.SelectedIndex == 5)
                {//G3 and B42LA value of WiFi ASSY has 4 bit
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
                    int TMPWIFIASSY = ConvertiBinarioInDecimale(numeroBinario.Substring(5, 3)); //on un7300 and um7050 series, there is no WiFi assy option, but LG for some reason keep this value as "000"; every code i see online have this value, try to change have no effect on the menu. 
                    if (TMPWIFIASSY != 0) { MessageBox.Show("If you are reading this, there is something wrong with the code you input. Please don't use the code on your tv and contact me on GitHub or t.me/Ca0ss93", "Error"); }  //this is the alert if the pattern was different from "000", so in this case i need to make some other research and tests
                    cmbDWifiAssy.SelectedIndex = 0;
                    cmbFAudio.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(3, 2));
                    cmbGEDID.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(1, 2));
                    cmbHWISA.SelectedIndex = ConvertiBinarioInDecimale(numeroBinario.Substring(0, 1));

                }

            }
            catch
            {
                MessageBox.Show("If you are reading this, the code you entered is not valid for the tv series you choose. Please don't use the code on your tv and contact me on GitHub or t.me/Ca0ss93", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //implementing G3 and B42LA Encoding
            if (cmbSeries.SelectedIndex == 1 || cmbSeries.SelectedIndex == 5) { WIFIASSY = Convert.ToString(cmbDWifiAssy.SelectedIndex, 2).PadLeft(4, '0'); }
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


            if (cmbSeries.SelectedIndex == 3 || cmbSeries.SelectedIndex == 4)  //implementing un7300 experimental and um7050 support, WIFI Assy Zeroed and Remocon have switched places
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

        private bool IsNumeric(string input)
        {
            // Check if the string is a number
            return int.TryParse(input, out _);
        }

        private void txtToolOPT6_TextChanged(object sender, EventArgs e)
        {
            if (txtToolOPT6.Text == "" || !IsNumeric(txtToolOPT6.Text)) //implementing error control
            {
                txtToolOPT6.Text = "0";
                txtToolOPT6.SelectAll();
            }

            if (txtToolOPT6.Text.StartsWith("-") || txtToolOPT6.Text.StartsWith("+")) { txtToolOPT6.Text = txtToolOPT6.Text.Substring(1); }

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
           //WiFi ASSY Changer, I should check the type avaiable for other series. UP and G3 are checked, other not. C2 serie, according to a video on yt have single_22y voice
            if ((cmbSeries.SelectedIndex == 1 || cmbSeries.SelectedIndex == 2) && cmbDWifiAssy.Items.Count != 11) //G3 Serie + C2 Serie experimental, maybe it have all items, should test it
            {
                TMP = cmbDWifiAssy.SelectedIndex;
                if (TMP >= 11) { TMP = 10; } //keeping selected item

                while (cmbDWifiAssy.Items.Count > 7) //removing extra item, pt.1
                {
                    cmbDWifiAssy.Items.RemoveAt(cmbDWifiAssy.Items.Count - 1);
                }


                //adding G3 items on WIFI ASSY; on a yt video the c2 have Single_22Y item, so probably have same item of G3. should confirm it
                cmbDWifiAssy.Items.Add("Single_22Y");   // 0111
                cmbDWifiAssy.Items.Add("M_Single_22Y"); // 1000
                cmbDWifiAssy.Items.Add("Dual_23Y");     // 1001
                cmbDWifiAssy.Items.Add("Single_23Y");   // 1010

                cmbDWifiAssy.SelectedIndex = TMP; //removing extra item, pt.2
            }
            else if (cmbSeries.SelectedIndex == 5 && cmbDWifiAssy.Items.Count != 12) //b42la support
            {
                label11.Text = "Support Calman SW";
                if (cmbDWifiAssy.Items.Count == 11) //adding B42LA items on WIFI ASSY;
                {
                    cmbDWifiAssy.Items.Add("M_Single_24Y");   // 1011
                }
                else if ( cmbDWifiAssy.Items.Count == 7)
                {
                    cmbDWifiAssy.Items.Add("Single_22Y");   // 0111
                    cmbDWifiAssy.Items.Add("M_Single_22Y"); // 1000
                    cmbDWifiAssy.Items.Add("Dual_23Y");     // 1001
                    cmbDWifiAssy.Items.Add("Single_23Y");   // 1010
                    cmbDWifiAssy.Items.Add("M_Single_24Y"); // 1011
                }
            }
            else if(cmbSeries.SelectedIndex != 1 && cmbSeries.SelectedIndex != 2 && cmbSeries.SelectedIndex != 5 && cmbDWifiAssy.Items.Count != 7)
            {
                //removing G3 items on WIFI ASSY
                TMP = cmbDWifiAssy.SelectedIndex;
                if(TMP >= 7) { TMP = 6; } //keeping selected item
                cmbDWifiAssy.SelectedIndex = TMP;

                while (cmbDWifiAssy.Items.Count > 7)
                {
                    cmbDWifiAssy.Items.RemoveAt(cmbDWifiAssy.Items.Count - 1);
                }
                
            }

            //Reverting UM7050 items
            if (cmbSeries.SelectedIndex != 4 && label15.Text != "Audio EQ/ EYE")
            {
                label15.Text = "Audio EQ/ EYE";
                cmbFAudio.Items.Clear();
                cmbFAudio.Items.Add("Default"); //00
                cmbFAudio.Items.Add("Type 1");  //01
                cmbFAudio.Items.Add("Type 2");  //10
                cmbFAudio.Items.Add("Type 3");  //11
                cmbFAudio.SelectedIndex = 0;
            }
            if (cmbSeries.SelectedIndex != 4 && cmbSeries.SelectedIndex != 3 && cmbSeries.SelectedIndex != 0 && cmbCWIFIBT.Items[1].ToString() != "Dual Combo MTK")
            {
                TMP = cmbCWIFIBT.SelectedIndex;
                if (TMP >= 3) { TMP = 2; }
                cmbCWIFIBT.Items.Clear();
                cmbCWIFIBT.Items.Add("None"); //00
                cmbCWIFIBT.Items.Add("Dual Combo MTK"); //01
                cmbCWIFIBT.Items.Add("WiFi_BT"); //10
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
                TMP = cmbGEDID.SelectedIndex;
                if (TMP >= 3) { TMP = 2; }
                cmbGEDID.Items.Clear();
                cmbGEDID.Items.Add("pcm"); //00
                cmbGEDID.Items.Add("ac3"); //01
                cmbGEDID.Items.Add("TrueHD"); //10
                cmbGEDID.SelectedIndex = TMP;
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

            //Adjust Name for B42LA Series
            if (cmbSeries.SelectedIndex != 5)
            {
                label11.Text = "Support ATV DVR";
            }


            //Adjust Size for UP75 and G3
            if (cmbSeries.SelectedIndex == 0 || cmbSeries.SelectedIndex == 1 || cmbSeries.SelectedIndex == 5)
            {
                this.Size = new Size(371, 728);
            }

            if (cmbSeries.SelectedIndex == 1 || cmbSeries.SelectedIndex == 5) //G3 and B42LA Series
            {
                //removing EDID and adding G3 EDID items
                TMP = cmbGEDID.SelectedIndex;
                cmbGEDID.Items.Clear();
                cmbGEDID.Items.Add("ac3"); //00
                cmbGEDID.Items.Add("ac3+dts"); //01
                cmbGEDID.Items.Add("TrueHD"); //10
                cmbGEDID.Items.Add("TrueHD+dts"); //11
                cmbGEDID.SelectedIndex = TMP;

                //changing Backlight name according to G3 and B42LA menu
                label6.Text = "Default Backlight";

            }
            else if (cmbSeries.SelectedIndex == 3 || cmbSeries.SelectedIndex == 0)  //UP7500 un7300 Nano79 implementation
            {
                TMP = cmbCWIFIBT.SelectedIndex;

                if (TMP >= 4) { TMP = 3; }
                cmbCWIFIBT.Items.Clear();
                cmbCWIFIBT.Items.Add("Ready"); //00 
                cmbCWIFIBT.Items.Add("WiFi_Only");//01
                cmbCWIFIBT.Items.Add("WiFi_BT"); //10
                cmbCWIFIBT.Items.Add("None"); //11

                //cmbCWIFIBT.Items.Add("WiFi_BT *"); //100  input this value, tv accept the resulting code, but the name still the same
                //cmbCWIFIBT.Items.Add("WiFi_BT *"); //101  i keep the variant here, just in case some tv use it, for future discovery and reference
                //cmbCWIFIBT.Items.Add("WiFi_BT *"); //110  Nano796 have this name all the same, maybe other tv not
                //cmbCWIFIBT.Items.Add("WiFi_BT *"); //111 
                cmbCWIFIBT.SelectedIndex = TMP;
            }
            else if (cmbSeries.SelectedIndex == 4)  //um7050 implementation
            {
                //removing other series EDID and adding um7050 items
                TMP = cmbGEDID.SelectedIndex;
                cmbGEDID.Items.Clear();
                cmbGEDID.Items.Add("pcm"); //00
                cmbGEDID.Items.Add("ac3"); //01
                cmbGEDID.Items.Add("dts"); //10
                cmbGEDID.Items.Add("TrueHD"); //11
                cmbGEDID.SelectedIndex = TMP;

                //changing names according to um7050 menu
                label15.Text = "EYE Curve Derivation";

                //adding initial curve experimental support
                cmbFAudio.Items.Clear();
                cmbFAudio.Items.Add("Initial Curve"); // 00 
                cmbFAudio.Items.Add("1 Pole, Eye Uncoating"); //01
                cmbFAudio.Items.Add("2 Pole, Eye Uncoating"); //10
                cmbFAudio.SelectedIndex = 0;

                TMP = cmbCWIFIBT.SelectedIndex;
                if (TMP >= 5) { TMP = 4; }
                cmbCWIFIBT.Items.Clear();
                cmbCWIFIBT.Items.Add("None"); //000 "none" according to other models
                cmbCWIFIBT.Items.Add("Dual_combo_mtk");//001
                cmbCWIFIBT.Items.Add("11ac_only_rtk"); //010
                cmbCWIFIBT.Items.Add("11ac_only_mtk"); //011
                cmbCWIFIBT.Items.Add("11ac_combo_mtk"); //100


                // cmbCWIFIBT.Items.Add("11ac_combo_mtk *"); //101  input this value, tv accept the resulting code, but the name still the same
                // cmbCWIFIBT.Items.Add("11ac_combo_mtk *"); //110  i keep the variant here, just in case some tv use it, for future discovery and reference
                // cmbCWIFIBT.Items.Add("11ac_combo_mtk *"); //111  um7050 have this name all the same, maybe other tv not


                cmbCWIFIBT.SelectedIndex = TMP;
            }

                Encode();
        }

        private void cmbIMARK_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encode();
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Does your TV have \"Markone Wifi\" as the last option?", "TV Series selector Helper", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                cmbSeries.SelectedIndex = 2;
            }
            else if (dialogResult == DialogResult.No)
            {
                dialogResult = MessageBox.Show("Does your TV have \"EYE Curve Derivation\" as third to last option?", "TV Series selector Helper", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    cmbSeries.SelectedIndex = 4;
                }
                else if (dialogResult == DialogResult.No)
                {
                    dialogResult = MessageBox.Show("Does your TV have \"WiFi Assy Type\" fifth to last option?", "TV Series selector Helper", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.No)
                    {
                        cmbSeries.SelectedIndex = 3;
                    }
                    else if (dialogResult == DialogResult.Yes)
                    {
                        dialogResult = MessageBox.Show("The option for \"Default Backlight\" it's called \"ECO Default Backlight\"?", "TV Series selector Helper", MessageBoxButtons.YesNoCancel);
                        if (dialogResult == DialogResult.Yes)
                        {
                            cmbSeries.SelectedIndex = 0;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            dialogResult = MessageBox.Show("Does your TV have \"Support Calman SW\" option?", "TV Series selector Helper", MessageBoxButtons.YesNoCancel);
                            if (dialogResult == DialogResult.No) { cmbSeries.SelectedIndex = 1; }
                            else if (dialogResult == DialogResult.Yes) { cmbSeries.SelectedIndex = 5; }
                            

                        }
                    }
                }
            }

        }
    }
}

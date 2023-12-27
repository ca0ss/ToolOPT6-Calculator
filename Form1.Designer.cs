namespace ToolOPT6_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtToolOPT6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb1EYE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb2Star = new System.Windows.Forms.ComboBox();
            this.cmb3AdaptiveDim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb6Sound = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb5ECO = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb4Adaptive = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb8SETID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb7ISF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbADVR = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb9ATV = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBAudio = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbHWISA = new System.Windows.Forms.ComboBox();
            this.cmbGEDID = new System.Windows.Forms.ComboBox();
            this.cmbFAudio = new System.Windows.Forms.ComboBox();
            this.cmbEREMOCON = new System.Windows.Forms.ComboBox();
            this.cmbDWifiAssy = new System.Windows.Forms.ComboBox();
            this.cmbCWIFIBT = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBinary = new System.Windows.Forms.Label();
            this.cmbSeries = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbIMARK = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // txtToolOPT6
            // 
            this.txtToolOPT6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolOPT6.Location = new System.Drawing.Point(78, 67);
            this.txtToolOPT6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToolOPT6.MaxLength = 10;
            this.txtToolOPT6.Name = "txtToolOPT6";
            this.txtToolOPT6.Size = new System.Drawing.Size(171, 20);
            this.txtToolOPT6.TabIndex = 1;
            this.txtToolOPT6.TextChanged += new System.EventHandler(this.txtToolOPT6_TextChanged);
            this.txtToolOPT6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToolOPT6_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digital Eye";
            // 
            // cmb1EYE
            // 
            this.cmb1EYE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1EYE.FormattingEnabled = true;
            this.cmb1EYE.Items.AddRange(new object[] {
            "OFF",
            "eyeSensor",
            "rgb_sensor",
            "OTP_eyeSensor"});
            this.cmb1EYE.Location = new System.Drawing.Point(157, 128);
            this.cmb1EYE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb1EYE.Name = "cmb1EYE";
            this.cmb1EYE.Size = new System.Drawing.Size(170, 21);
            this.cmb1EYE.TabIndex = 3;
            this.cmb1EYE.SelectedIndexChanged += new System.EventHandler(this.cmb1EYE_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Energy Star";
            // 
            // cmb2Star
            // 
            this.cmb2Star.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2Star.FormattingEnabled = true;
            this.cmb2Star.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cmb2Star.Location = new System.Drawing.Point(157, 157);
            this.cmb2Star.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb2Star.Name = "cmb2Star";
            this.cmb2Star.Size = new System.Drawing.Size(170, 21);
            this.cmb2Star.TabIndex = 5;
            this.cmb2Star.SelectedIndexChanged += new System.EventHandler(this.cmb2Star_SelectedIndexChanged);
            // 
            // cmb3AdaptiveDim
            // 
            this.cmb3AdaptiveDim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb3AdaptiveDim.FormattingEnabled = true;
            this.cmb3AdaptiveDim.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cmb3AdaptiveDim.Location = new System.Drawing.Point(157, 186);
            this.cmb3AdaptiveDim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb3AdaptiveDim.Name = "cmb3AdaptiveDim";
            this.cmb3AdaptiveDim.Size = new System.Drawing.Size(170, 21);
            this.cmb3AdaptiveDim.TabIndex = 7;
            this.cmb3AdaptiveDim.SelectedIndexChanged += new System.EventHandler(this.cmb3AdaptiveDim_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "AdaptiveDim Default";
            // 
            // cmb6Sound
            // 
            this.cmb6Sound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb6Sound.FormattingEnabled = true;
            this.cmb6Sound.Items.AddRange(new object[] {
            "LG Sound Engine",
            "Dolby Atmos",
            "DTS Virtual X"});
            this.cmb6Sound.Location = new System.Drawing.Point(157, 280);
            this.cmb6Sound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb6Sound.Name = "cmb6Sound";
            this.cmb6Sound.Size = new System.Drawing.Size(170, 21);
            this.cmb6Sound.TabIndex = 13;
            this.cmb6Sound.SelectedIndexChanged += new System.EventHandler(this.cmb6Sound_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sound Mode";
            // 
            // cmb5ECO
            // 
            this.cmb5ECO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb5ECO.FormattingEnabled = true;
            this.cmb5ECO.Items.AddRange(new object[] {
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.cmb5ECO.Location = new System.Drawing.Point(157, 247);
            this.cmb5ECO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb5ECO.Name = "cmb5ECO";
            this.cmb5ECO.Size = new System.Drawing.Size(170, 21);
            this.cmb5ECO.TabIndex = 11;
            this.cmb5ECO.SelectedIndexChanged += new System.EventHandler(this.cmb5ECO_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ECO Default Backlight";
            // 
            // cmb4Adaptive
            // 
            this.cmb4Adaptive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb4Adaptive.FormattingEnabled = true;
            this.cmb4Adaptive.Items.AddRange(new object[] {
            "Step1",
            "Step2",
            "Step3",
            "Step4",
            "Step5",
            "Step6",
            "Step7",
            "Step8",
            "Step9",
            "Step10",
            "Step11",
            "Step12"});
            this.cmb4Adaptive.Location = new System.Drawing.Point(157, 216);
            this.cmb4Adaptive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb4Adaptive.Name = "cmb4Adaptive";
            this.cmb4Adaptive.Size = new System.Drawing.Size(170, 21);
            this.cmb4Adaptive.TabIndex = 9;
            this.cmb4Adaptive.SelectedIndexChanged += new System.EventHandler(this.cmb4Adaptive_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Adaptive Dimming";
            // 
            // cmb8SETID
            // 
            this.cmb8SETID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb8SETID.FormattingEnabled = true;
            this.cmb8SETID.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cmb8SETID.Location = new System.Drawing.Point(157, 345);
            this.cmb8SETID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb8SETID.Name = "cmb8SETID";
            this.cmb8SETID.Size = new System.Drawing.Size(170, 21);
            this.cmb8SETID.TabIndex = 17;
            this.cmb8SETID.SelectedIndexChanged += new System.EventHandler(this.cmb8SETID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Set ID";
            // 
            // cmb7ISF
            // 
            this.cmb7ISF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb7ISF.FormattingEnabled = true;
            this.cmb7ISF.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cmb7ISF.Location = new System.Drawing.Point(157, 312);
            this.cmb7ISF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb7ISF.Name = "cmb7ISF";
            this.cmb7ISF.Size = new System.Drawing.Size(170, 21);
            this.cmb7ISF.TabIndex = 15;
            this.cmb7ISF.SelectedIndexChanged += new System.EventHandler(this.cmb7ISF_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "ISF";
            // 
            // cmbADVR
            // 
            this.cmbADVR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbADVR.FormattingEnabled = true;
            this.cmbADVR.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cmbADVR.Location = new System.Drawing.Point(157, 412);
            this.cmbADVR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbADVR.Name = "cmbADVR";
            this.cmbADVR.Size = new System.Drawing.Size(170, 21);
            this.cmbADVR.TabIndex = 21;
            this.cmbADVR.SelectedIndexChanged += new System.EventHandler(this.cmbADVR_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "DVR Ready";
            // 
            // cmb9ATV
            // 
            this.cmb9ATV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb9ATV.FormattingEnabled = true;
            this.cmb9ATV.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cmb9ATV.Location = new System.Drawing.Point(157, 378);
            this.cmb9ATV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb9ATV.Name = "cmb9ATV";
            this.cmb9ATV.Size = new System.Drawing.Size(170, 21);
            this.cmb9ATV.TabIndex = 19;
            this.cmb9ATV.SelectedIndexChanged += new System.EventHandler(this.cmb9ATV_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Support ATV DVR";
            // 
            // cmbBAudio
            // 
            this.cmbBAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBAudio.FormattingEnabled = true;
            this.cmbBAudio.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cmbBAudio.Location = new System.Drawing.Point(157, 448);
            this.cmbBAudio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBAudio.Name = "cmbBAudio";
            this.cmbBAudio.Size = new System.Drawing.Size(170, 21);
            this.cmbBAudio.TabIndex = 23;
            this.cmbBAudio.SelectedIndexChanged += new System.EventHandler(this.cmbBAudio_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Audio Line Out";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 654);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "WiSA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 618);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "EDID_Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 583);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Audio EQ/ EYE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 550);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Motion Remocon";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 516);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "WiFi Assy Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 485);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "WiFi/BT";
            // 
            // cmbHWISA
            // 
            this.cmbHWISA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHWISA.FormattingEnabled = true;
            this.cmbHWISA.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cmbHWISA.Location = new System.Drawing.Point(157, 650);
            this.cmbHWISA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbHWISA.Name = "cmbHWISA";
            this.cmbHWISA.Size = new System.Drawing.Size(170, 21);
            this.cmbHWISA.TabIndex = 35;
            this.cmbHWISA.SelectedIndexChanged += new System.EventHandler(this.cmbHWISA_SelectedIndexChanged);
            // 
            // cmbGEDID
            // 
            this.cmbGEDID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGEDID.FormattingEnabled = true;
            this.cmbGEDID.Items.AddRange(new object[] {
            "pcm",
            "ac3",
            "True HD"});
            this.cmbGEDID.Location = new System.Drawing.Point(157, 615);
            this.cmbGEDID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbGEDID.Name = "cmbGEDID";
            this.cmbGEDID.Size = new System.Drawing.Size(170, 21);
            this.cmbGEDID.TabIndex = 34;
            this.cmbGEDID.SelectedIndexChanged += new System.EventHandler(this.cmbGEDID_SelectedIndexChanged);
            // 
            // cmbFAudio
            // 
            this.cmbFAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFAudio.FormattingEnabled = true;
            this.cmbFAudio.Items.AddRange(new object[] {
            "Default", //00
            "Type1",   //01
            "Type2",   //10
            "Type3"}); //11
            this.cmbFAudio.Location = new System.Drawing.Point(157, 580);
            this.cmbFAudio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFAudio.Name = "cmbFAudio";
            this.cmbFAudio.Size = new System.Drawing.Size(170, 21);
            this.cmbFAudio.TabIndex = 33;
            this.cmbFAudio.SelectedIndexChanged += new System.EventHandler(this.cmbFAudio_SelectedIndexChanged);
            // 
            // cmbEREMOCON
            // 
            this.cmbEREMOCON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEREMOCON.FormattingEnabled = true;
            this.cmbEREMOCON.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cmbEREMOCON.Location = new System.Drawing.Point(157, 547);
            this.cmbEREMOCON.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEREMOCON.Name = "cmbEREMOCON";
            this.cmbEREMOCON.Size = new System.Drawing.Size(170, 21);
            this.cmbEREMOCON.TabIndex = 32;
            this.cmbEREMOCON.SelectedIndexChanged += new System.EventHandler(this.cmbEREMOCON_SelectedIndexChanged);
            // 
            // cmbDWifiAssy
            // 
            this.cmbDWifiAssy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDWifiAssy.FormattingEnabled = true;
            this.cmbDWifiAssy.Items.AddRange(new object[] {
            "11ax",         //000
            "Dual_21Y",     //001
            "Dual_20Y",     //010
            "Single_21Y",   //011
            "Single_20Y",   //100
            "None",         //101
            "M_Dual_21Y"}); //110
            this.cmbDWifiAssy.Location = new System.Drawing.Point(157, 514);
            this.cmbDWifiAssy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDWifiAssy.Name = "cmbDWifiAssy";
            this.cmbDWifiAssy.Size = new System.Drawing.Size(170, 21);
            this.cmbDWifiAssy.TabIndex = 31;
            this.cmbDWifiAssy.SelectedIndexChanged += new System.EventHandler(this.cmbDWifiAssy_SelectedIndexChanged);
            // 
            // cmbCWIFIBT
            // 
            this.cmbCWIFIBT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCWIFIBT.FormattingEnabled = true;
            this.cmbCWIFIBT.Items.AddRange(new object[] {
            "Ready",             //00
            "WiFi_Only",   //01
            "WiFi_BT", //10
            "None"});        //11
            this.cmbCWIFIBT.Location = new System.Drawing.Point(157, 482);
            this.cmbCWIFIBT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCWIFIBT.Name = "cmbCWIFIBT";
            this.cmbCWIFIBT.Size = new System.Drawing.Size(170, 21);
            this.cmbCWIFIBT.TabIndex = 30;
            this.cmbCWIFIBT.SelectedIndexChanged += new System.EventHandler(this.cmbCWIFIBT_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 22);
            this.button1.TabIndex = 36;
            this.button1.Text = "Reverse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Binary";
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Location = new System.Drawing.Point(75, 100);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(13, 13);
            this.lblBinary.TabIndex = 38;
            this.lblBinary.Text = "0";
            // 
            // cmbSeries
            // 
            this.cmbSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeries.FormattingEnabled = true;
            this.cmbSeries.Items.AddRange(new object[] {
            "UP75006 / C11LB",
            "G36LA",
            "C26LB / NANO78",
            "UN7300 / NANO79",
            "UM7050 / UM7300"});
            this.cmbSeries.Location = new System.Drawing.Point(84, 22);
            this.cmbSeries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSeries.Name = "cmbSeries";
            this.cmbSeries.Size = new System.Drawing.Size(243, 21);
            this.cmbSeries.TabIndex = 39;
            this.cmbSeries.SelectedIndexChanged += new System.EventHandler(this.cmbSeries_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "TV Series";
            // 
            // cmbIMARK
            // 
            this.cmbIMARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIMARK.FormattingEnabled = true;
            this.cmbIMARK.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cmbIMARK.Location = new System.Drawing.Point(157, 685);
            this.cmbIMARK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbIMARK.Name = "cmbIMARK";
            this.cmbIMARK.Size = new System.Drawing.Size(170, 21);
            this.cmbIMARK.TabIndex = 42;
            this.cmbIMARK.SelectedIndexChanged += new System.EventHandler(this.cmbIMARK_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 688);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "Markone WiFi Single";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 729);
            this.Controls.Add(this.cmbIMARK);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmbSeries);
            this.Controls.Add(this.lblBinary);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbHWISA);
            this.Controls.Add(this.cmbGEDID);
            this.Controls.Add(this.cmbFAudio);
            this.Controls.Add(this.cmbEREMOCON);
            this.Controls.Add(this.cmbDWifiAssy);
            this.Controls.Add(this.cmbCWIFIBT);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbBAudio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbADVR);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb9ATV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb8SETID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb7ISF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb6Sound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb5ECO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb4Adaptive);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb3AdaptiveDim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb2Star);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb1EYE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToolOPT6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ToolOPT6_Energy/Country Calculator - coded by Ca0ss!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToolOPT6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb1EYE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb2Star;
        private System.Windows.Forms.ComboBox cmb3AdaptiveDim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb6Sound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb5ECO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb4Adaptive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb8SETID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb7ISF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbADVR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb9ATV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbBAudio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbHWISA;
        private System.Windows.Forms.ComboBox cmbGEDID;
        private System.Windows.Forms.ComboBox cmbFAudio;
        private System.Windows.Forms.ComboBox cmbEREMOCON;
        private System.Windows.Forms.ComboBox cmbDWifiAssy;
        private System.Windows.Forms.ComboBox cmbCWIFIBT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.ComboBox cmbSeries;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbIMARK;
        private System.Windows.Forms.Label label21;
    }
}


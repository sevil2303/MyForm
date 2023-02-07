namespace MyForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstnameTxb = new System.Windows.Forms.TextBox();
            this.lastnameTxb = new System.Windows.Forms.TextBox();
            this.firstnameLbl = new System.Windows.Forms.Label();
            this.mobiletxb = new System.Windows.Forms.MaskedTextBox();
            this.mobileLbl = new System.Windows.Forms.Label();
            this.birthdateLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maleBtn = new System.Windows.Forms.RadioButton();
            this.femaleBtn = new System.Windows.Forms.RadioButton();
            this.gendergroupBox = new System.Windows.Forms.GroupBox();
            this.emailTxb = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.lastnameLbl = new System.Windows.Forms.Label();
            this.headerLbl = new System.Windows.Forms.Label();
            this.birthdatetime = new System.Windows.Forms.DateTimePicker();
            this.citizenLbl = new System.Windows.Forms.Label();
            this.citizengroupBox = new System.Windows.Forms.GroupBox();
            this.noBtn = new System.Windows.Forms.RadioButton();
            this.yesBtn = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.languagesLbl = new System.Windows.Forms.Label();
            this.engChbox = new System.Windows.Forms.CheckBox();
            this.germanChbox = new System.Windows.Forms.CheckBox();
            this.azChbox = new System.Windows.Forms.CheckBox();
            this.turkChbox = new System.Windows.Forms.CheckBox();
            this.arabianChbox = new System.Windows.Forms.CheckBox();
            this.spainChbox = new System.Windows.Forms.CheckBox();
            this.countryTxb = new System.Windows.Forms.TextBox();
            this.countryLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.cityTxb = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressTxb = new System.Windows.Forms.TextBox();
            this.specialityLbl = new System.Windows.Forms.Label();
            this.specialityTxb = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.firstwarnLbl = new System.Windows.Forms.Label();
            this.lastwarnLbl = new System.Windows.Forms.Label();
            this.genderwarnLbl = new System.Windows.Forms.Label();
            this.specialtiywarnLbl = new System.Windows.Forms.Label();
            this.emailwarnLbl = new System.Windows.Forms.Label();
            this.birthdatewarnLbl = new System.Windows.Forms.Label();
            this.numberwarnLbl = new System.Windows.Forms.Label();
            this.countrywarnLbl = new System.Windows.Forms.Label();
            this.citywarnLbl = new System.Windows.Forms.Label();
            this.addresswarnLbl = new System.Windows.Forms.Label();
            this.languageswarnLbl = new System.Windows.Forms.Label();
            this.gendergroupBox.SuspendLayout();
            this.citizengroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstnameTxb
            // 
            this.firstnameTxb.Location = new System.Drawing.Point(22, 92);
            this.firstnameTxb.Name = "firstnameTxb";
            this.firstnameTxb.Size = new System.Drawing.Size(200, 20);
            this.firstnameTxb.TabIndex = 0;
            this.firstnameTxb.TextChanged += new System.EventHandler(this.firstnameTxb_TextChanged);
            // 
            // lastnameTxb
            // 
            this.lastnameTxb.Location = new System.Drawing.Point(22, 145);
            this.lastnameTxb.Name = "lastnameTxb";
            this.lastnameTxb.Size = new System.Drawing.Size(200, 20);
            this.lastnameTxb.TabIndex = 0;
            this.lastnameTxb.TextChanged += new System.EventHandler(this.lastnameTxb_TextChanged);
            // 
            // firstnameLbl
            // 
            this.firstnameLbl.AutoSize = true;
            this.firstnameLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firstnameLbl.Location = new System.Drawing.Point(19, 72);
            this.firstnameLbl.Name = "firstnameLbl";
            this.firstnameLbl.Size = new System.Drawing.Size(91, 17);
            this.firstnameLbl.TabIndex = 1;
            this.firstnameLbl.Text = "First name*:";
            // 
            // mobiletxb
            // 
            this.mobiletxb.Location = new System.Drawing.Point(22, 439);
            this.mobiletxb.Mask = "+(994)00-000-00-00";
            this.mobiletxb.Name = "mobiletxb";
            this.mobiletxb.Size = new System.Drawing.Size(200, 20);
            this.mobiletxb.TabIndex = 2;
            this.mobiletxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobiletxb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mobiletxb_MaskInputRejected);
            // 
            // mobileLbl
            // 
            this.mobileLbl.AutoSize = true;
            this.mobileLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mobileLbl.Location = new System.Drawing.Point(19, 419);
            this.mobileLbl.Name = "mobileLbl";
            this.mobileLbl.Size = new System.Drawing.Size(122, 17);
            this.mobileLbl.TabIndex = 1;
            this.mobileLbl.Text = "Mobile number*:";
            // 
            // birthdateLbl
            // 
            this.birthdateLbl.AutoSize = true;
            this.birthdateLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birthdateLbl.Location = new System.Drawing.Point(23, 356);
            this.birthdateLbl.Name = "birthdateLbl";
            this.birthdateLbl.Size = new System.Drawing.Size(87, 17);
            this.birthdateLbl.TabIndex = 1;
            this.birthdateLbl.Text = "Birth date*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gender*:";
            // 
            // maleBtn
            // 
            this.maleBtn.AutoSize = true;
            this.maleBtn.Location = new System.Drawing.Point(0, 15);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.Size = new System.Drawing.Size(48, 17);
            this.maleBtn.TabIndex = 3;
            this.maleBtn.TabStop = true;
            this.maleBtn.Text = "Male";
            this.maleBtn.UseVisualStyleBackColor = true;
            this.maleBtn.CheckedChanged += new System.EventHandler(this.maleBtn_CheckedChanged);
            // 
            // femaleBtn
            // 
            this.femaleBtn.AutoSize = true;
            this.femaleBtn.Location = new System.Drawing.Point(54, 15);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.Size = new System.Drawing.Size(59, 17);
            this.femaleBtn.TabIndex = 3;
            this.femaleBtn.TabStop = true;
            this.femaleBtn.Text = "Female";
            this.femaleBtn.UseVisualStyleBackColor = true;
            this.femaleBtn.CheckedChanged += new System.EventHandler(this.femaleBtn_CheckedChanged);
            // 
            // gendergroupBox
            // 
            this.gendergroupBox.BackColor = System.Drawing.Color.Transparent;
            this.gendergroupBox.Controls.Add(this.femaleBtn);
            this.gendergroupBox.Controls.Add(this.maleBtn);
            this.gendergroupBox.Location = new System.Drawing.Point(22, 202);
            this.gendergroupBox.Name = "gendergroupBox";
            this.gendergroupBox.Size = new System.Drawing.Size(113, 38);
            this.gendergroupBox.TabIndex = 5;
            this.gendergroupBox.TabStop = false;
            // 
            // emailTxb
            // 
            this.emailTxb.Location = new System.Drawing.Point(22, 324);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(200, 20);
            this.emailTxb.TabIndex = 0;
            this.emailTxb.TextChanged += new System.EventHandler(this.emailTxb_TextChanged);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLbl.Location = new System.Drawing.Point(21, 304);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(63, 17);
            this.emailLbl.TabIndex = 1;
            this.emailLbl.Text = "E-mail*:";
            // 
            // lastnameLbl
            // 
            this.lastnameLbl.AutoSize = true;
            this.lastnameLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastnameLbl.Location = new System.Drawing.Point(21, 125);
            this.lastnameLbl.Name = "lastnameLbl";
            this.lastnameLbl.Size = new System.Drawing.Size(89, 17);
            this.lastnameLbl.TabIndex = 1;
            this.lastnameLbl.Text = "Last name*:";
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLbl.Location = new System.Drawing.Point(203, 24);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(416, 34);
            this.headerLbl.TabIndex = 6;
            this.headerLbl.Text = "PERSONAL INFORMATION FORM";
            // 
            // birthdatetime
            // 
            this.birthdatetime.Location = new System.Drawing.Point(22, 385);
            this.birthdatetime.Name = "birthdatetime";
            this.birthdatetime.Size = new System.Drawing.Size(200, 20);
            this.birthdatetime.TabIndex = 7;
            this.birthdatetime.ValueChanged += new System.EventHandler(this.birthdatetime_ValueChanged);
            // 
            // citizenLbl
            // 
            this.citizenLbl.AutoSize = true;
            this.citizenLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.citizenLbl.Location = new System.Drawing.Point(356, 249);
            this.citizenLbl.Name = "citizenLbl";
            this.citizenLbl.Size = new System.Drawing.Size(205, 17);
            this.citizenLbl.TabIndex = 1;
            this.citizenLbl.Text = "Are you an Azerbaijan citizen?";
            // 
            // citizengroupBox
            // 
            this.citizengroupBox.BackColor = System.Drawing.Color.Transparent;
            this.citizengroupBox.Controls.Add(this.noBtn);
            this.citizengroupBox.Controls.Add(this.yesBtn);
            this.citizengroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citizengroupBox.Location = new System.Drawing.Point(359, 281);
            this.citizengroupBox.Name = "citizengroupBox";
            this.citizengroupBox.Size = new System.Drawing.Size(113, 38);
            this.citizengroupBox.TabIndex = 5;
            this.citizengroupBox.TabStop = false;
            // 
            // noBtn
            // 
            this.noBtn.AutoSize = true;
            this.noBtn.Location = new System.Drawing.Point(54, 15);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(39, 17);
            this.noBtn.TabIndex = 3;
            this.noBtn.TabStop = true;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.CheckedChanged += new System.EventHandler(this.noBtn_CheckedChanged);
            // 
            // yesBtn
            // 
            this.yesBtn.AutoSize = true;
            this.yesBtn.Location = new System.Drawing.Point(0, 15);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(43, 17);
            this.yesBtn.TabIndex = 3;
            this.yesBtn.TabStop = true;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.CheckedChanged += new System.EventHandler(this.yesBtn_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyForm.Properties.Resources._3740813;
            this.pictureBox1.Location = new System.Drawing.Point(687, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // languagesLbl
            // 
            this.languagesLbl.AutoSize = true;
            this.languagesLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.languagesLbl.Location = new System.Drawing.Point(356, 342);
            this.languagesLbl.Name = "languagesLbl";
            this.languagesLbl.Size = new System.Drawing.Size(92, 17);
            this.languagesLbl.TabIndex = 1;
            this.languagesLbl.Text = "Languages*:";
            // 
            // engChbox
            // 
            this.engChbox.AutoSize = true;
            this.engChbox.Location = new System.Drawing.Point(359, 377);
            this.engChbox.Name = "engChbox";
            this.engChbox.Size = new System.Drawing.Size(60, 17);
            this.engChbox.TabIndex = 9;
            this.engChbox.Text = "English";
            this.engChbox.UseVisualStyleBackColor = true;
            this.engChbox.CheckedChanged += new System.EventHandler(this.engChbox_CheckedChanged);
            // 
            // germanChbox
            // 
            this.germanChbox.AutoSize = true;
            this.germanChbox.Location = new System.Drawing.Point(359, 400);
            this.germanChbox.Name = "germanChbox";
            this.germanChbox.Size = new System.Drawing.Size(63, 17);
            this.germanChbox.TabIndex = 9;
            this.germanChbox.Text = "German";
            this.germanChbox.UseVisualStyleBackColor = true;
            this.germanChbox.CheckedChanged += new System.EventHandler(this.germanChbox_CheckedChanged);
            // 
            // azChbox
            // 
            this.azChbox.AutoSize = true;
            this.azChbox.Location = new System.Drawing.Point(456, 377);
            this.azChbox.Name = "azChbox";
            this.azChbox.Size = new System.Drawing.Size(77, 17);
            this.azChbox.TabIndex = 9;
            this.azChbox.Text = "Azerbaijani";
            this.azChbox.UseVisualStyleBackColor = true;
            this.azChbox.CheckedChanged += new System.EventHandler(this.azChbox_CheckedChanged);
            // 
            // turkChbox
            // 
            this.turkChbox.AutoSize = true;
            this.turkChbox.Location = new System.Drawing.Point(456, 400);
            this.turkChbox.Name = "turkChbox";
            this.turkChbox.Size = new System.Drawing.Size(61, 17);
            this.turkChbox.TabIndex = 9;
            this.turkChbox.Text = "Turkish";
            this.turkChbox.UseVisualStyleBackColor = true;
            this.turkChbox.CheckedChanged += new System.EventHandler(this.turkChbox_CheckedChanged);
            // 
            // arabianChbox
            // 
            this.arabianChbox.AutoSize = true;
            this.arabianChbox.Location = new System.Drawing.Point(359, 421);
            this.arabianChbox.Name = "arabianChbox";
            this.arabianChbox.Size = new System.Drawing.Size(62, 17);
            this.arabianChbox.TabIndex = 9;
            this.arabianChbox.Text = "Arabian";
            this.arabianChbox.UseVisualStyleBackColor = true;
            this.arabianChbox.CheckedChanged += new System.EventHandler(this.arabianChbox_CheckedChanged);
            // 
            // spainChbox
            // 
            this.spainChbox.AutoSize = true;
            this.spainChbox.Location = new System.Drawing.Point(456, 421);
            this.spainChbox.Name = "spainChbox";
            this.spainChbox.Size = new System.Drawing.Size(53, 17);
            this.spainChbox.TabIndex = 9;
            this.spainChbox.Text = "Spain";
            this.spainChbox.UseVisualStyleBackColor = true;
            this.spainChbox.CheckedChanged += new System.EventHandler(this.spainChbox_CheckedChanged);
            // 
            // countryTxb
            // 
            this.countryTxb.Location = new System.Drawing.Point(359, 92);
            this.countryTxb.Name = "countryTxb";
            this.countryTxb.Size = new System.Drawing.Size(200, 20);
            this.countryTxb.TabIndex = 0;
            this.countryTxb.TextChanged += new System.EventHandler(this.countryTxb_TextChanged);
            // 
            // countryLbl
            // 
            this.countryLbl.AutoSize = true;
            this.countryLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countryLbl.Location = new System.Drawing.Point(356, 72);
            this.countryLbl.Name = "countryLbl";
            this.countryLbl.Size = new System.Drawing.Size(74, 17);
            this.countryLbl.TabIndex = 1;
            this.countryLbl.Text = "Country*:";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cityLbl.Location = new System.Drawing.Point(356, 125);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(48, 17);
            this.cityLbl.TabIndex = 1;
            this.cityLbl.Text = "City*:";
            // 
            // cityTxb
            // 
            this.cityTxb.Location = new System.Drawing.Point(359, 145);
            this.cityTxb.Name = "cityTxb";
            this.cityTxb.Size = new System.Drawing.Size(200, 20);
            this.cityTxb.TabIndex = 0;
            this.cityTxb.TextChanged += new System.EventHandler(this.cityTxb_TextChanged);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addressLbl.Location = new System.Drawing.Point(356, 188);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(76, 17);
            this.addressLbl.TabIndex = 1;
            this.addressLbl.Text = "Address*:";
            // 
            // addressTxb
            // 
            this.addressTxb.Location = new System.Drawing.Point(359, 208);
            this.addressTxb.Name = "addressTxb";
            this.addressTxb.Size = new System.Drawing.Size(200, 20);
            this.addressTxb.TabIndex = 0;
            this.addressTxb.TextChanged += new System.EventHandler(this.addressTxb_TextChanged);
            // 
            // specialityLbl
            // 
            this.specialityLbl.AutoSize = true;
            this.specialityLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.specialityLbl.Location = new System.Drawing.Point(19, 249);
            this.specialityLbl.Name = "specialityLbl";
            this.specialityLbl.Size = new System.Drawing.Size(83, 17);
            this.specialityLbl.TabIndex = 1;
            this.specialityLbl.Text = "Speciality*:";
            // 
            // specialityTxb
            // 
            this.specialityTxb.Location = new System.Drawing.Point(22, 281);
            this.specialityTxb.Name = "specialityTxb";
            this.specialityTxb.Size = new System.Drawing.Size(200, 20);
            this.specialityTxb.TabIndex = 0;
            this.specialityTxb.TextChanged += new System.EventHandler(this.specialityTxb_TextChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.submitBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.submitBtn.Location = new System.Drawing.Point(668, 396);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(120, 42);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // firstwarnLbl
            // 
            this.firstwarnLbl.AutoSize = true;
            this.firstwarnLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firstwarnLbl.ForeColor = System.Drawing.Color.Red;
            this.firstwarnLbl.Location = new System.Drawing.Point(105, 76);
            this.firstwarnLbl.Name = "firstwarnLbl";
            this.firstwarnLbl.Size = new System.Drawing.Size(0, 13);
            this.firstwarnLbl.TabIndex = 11;
            // 
            // lastwarnLbl
            // 
            this.lastwarnLbl.AutoSize = true;
            this.lastwarnLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastwarnLbl.ForeColor = System.Drawing.Color.Red;
            this.lastwarnLbl.Location = new System.Drawing.Point(105, 129);
            this.lastwarnLbl.Name = "lastwarnLbl";
            this.lastwarnLbl.Size = new System.Drawing.Size(0, 13);
            this.lastwarnLbl.TabIndex = 11;
            // 
            // genderwarnLbl
            // 
            this.genderwarnLbl.AutoSize = true;
            this.genderwarnLbl.BackColor = System.Drawing.Color.Transparent;
            this.genderwarnLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genderwarnLbl.ForeColor = System.Drawing.Color.Red;
            this.genderwarnLbl.Location = new System.Drawing.Point(95, 183);
            this.genderwarnLbl.Name = "genderwarnLbl";
            this.genderwarnLbl.Size = new System.Drawing.Size(0, 13);
            this.genderwarnLbl.TabIndex = 11;
            // 
            // specialtiywarnLbl
            // 
            this.specialtiywarnLbl.AutoSize = true;
            this.specialtiywarnLbl.BackColor = System.Drawing.Color.Transparent;
            this.specialtiywarnLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.specialtiywarnLbl.ForeColor = System.Drawing.Color.Red;
            this.specialtiywarnLbl.Location = new System.Drawing.Point(108, 253);
            this.specialtiywarnLbl.Name = "specialtiywarnLbl";
            this.specialtiywarnLbl.Size = new System.Drawing.Size(0, 13);
            this.specialtiywarnLbl.TabIndex = 11;
            // 
            // emailwarnLbl
            // 
            this.emailwarnLbl.AutoSize = true;
            this.emailwarnLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailwarnLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailwarnLbl.ForeColor = System.Drawing.Color.Red;
            this.emailwarnLbl.Location = new System.Drawing.Point(90, 308);
            this.emailwarnLbl.Name = "emailwarnLbl";
            this.emailwarnLbl.Size = new System.Drawing.Size(0, 13);
            this.emailwarnLbl.TabIndex = 11;
            // 
            // birthdatewarnLbl
            // 
            this.birthdatewarnLbl.AutoSize = true;
            this.birthdatewarnLbl.BackColor = System.Drawing.Color.Transparent;
            this.birthdatewarnLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birthdatewarnLbl.ForeColor = System.Drawing.Color.Red;
            this.birthdatewarnLbl.Location = new System.Drawing.Point(105, 360);
            this.birthdatewarnLbl.Name = "birthdatewarnLbl";
            this.birthdatewarnLbl.Size = new System.Drawing.Size(0, 13);
            this.birthdatewarnLbl.TabIndex = 11;
            // 
            // numberwarnLbl
            // 
            this.numberwarnLbl.AutoSize = true;
            this.numberwarnLbl.BackColor = System.Drawing.Color.Transparent;
            this.numberwarnLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberwarnLbl.ForeColor = System.Drawing.Color.Red;
            this.numberwarnLbl.Location = new System.Drawing.Point(138, 423);
            this.numberwarnLbl.Name = "numberwarnLbl";
            this.numberwarnLbl.Size = new System.Drawing.Size(0, 13);
            this.numberwarnLbl.TabIndex = 11;
            // 
            // countrywarnLbl
            // 
            this.countrywarnLbl.AutoSize = true;
            this.countrywarnLbl.BackColor = System.Drawing.Color.Transparent;
            this.countrywarnLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countrywarnLbl.ForeColor = System.Drawing.Color.Red;
            this.countrywarnLbl.Location = new System.Drawing.Point(436, 76);
            this.countrywarnLbl.Name = "countrywarnLbl";
            this.countrywarnLbl.Size = new System.Drawing.Size(0, 13);
            this.countrywarnLbl.TabIndex = 11;
            // 
            // citywarnLbl
            // 
            this.citywarnLbl.AutoSize = true;
            this.citywarnLbl.BackColor = System.Drawing.Color.Transparent;
            this.citywarnLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.citywarnLbl.ForeColor = System.Drawing.Color.Red;
            this.citywarnLbl.Location = new System.Drawing.Point(410, 129);
            this.citywarnLbl.Name = "citywarnLbl";
            this.citywarnLbl.Size = new System.Drawing.Size(0, 13);
            this.citywarnLbl.TabIndex = 11;
            // 
            // addresswarnLbl
            // 
            this.addresswarnLbl.AutoSize = true;
            this.addresswarnLbl.BackColor = System.Drawing.Color.Transparent;
            this.addresswarnLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addresswarnLbl.ForeColor = System.Drawing.Color.Red;
            this.addresswarnLbl.Location = new System.Drawing.Point(436, 192);
            this.addresswarnLbl.Name = "addresswarnLbl";
            this.addresswarnLbl.Size = new System.Drawing.Size(0, 13);
            this.addresswarnLbl.TabIndex = 11;
            // 
            // languageswarnLbl
            // 
            this.languageswarnLbl.AutoSize = true;
            this.languageswarnLbl.BackColor = System.Drawing.Color.Transparent;
            this.languageswarnLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.languageswarnLbl.ForeColor = System.Drawing.Color.Red;
            this.languageswarnLbl.Location = new System.Drawing.Point(453, 346);
            this.languageswarnLbl.Name = "languageswarnLbl";
            this.languageswarnLbl.Size = new System.Drawing.Size(0, 13);
            this.languageswarnLbl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.genderwarnLbl);
            this.Controls.Add(this.languageswarnLbl);
            this.Controls.Add(this.addresswarnLbl);
            this.Controls.Add(this.citywarnLbl);
            this.Controls.Add(this.countrywarnLbl);
            this.Controls.Add(this.numberwarnLbl);
            this.Controls.Add(this.birthdatewarnLbl);
            this.Controls.Add(this.emailwarnLbl);
            this.Controls.Add(this.specialtiywarnLbl);
            this.Controls.Add(this.lastwarnLbl);
            this.Controls.Add(this.firstwarnLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.spainChbox);
            this.Controls.Add(this.turkChbox);
            this.Controls.Add(this.azChbox);
            this.Controls.Add(this.arabianChbox);
            this.Controls.Add(this.germanChbox);
            this.Controls.Add(this.engChbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.birthdatetime);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.citizengroupBox);
            this.Controls.Add(this.gendergroupBox);
            this.Controls.Add(this.mobiletxb);
            this.Controls.Add(this.mobileLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.birthdateLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.specialityLbl);
            this.Controls.Add(this.lastnameLbl);
            this.Controls.Add(this.citizenLbl);
            this.Controls.Add(this.languagesLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.countryLbl);
            this.Controls.Add(this.firstnameLbl);
            this.Controls.Add(this.specialityTxb);
            this.Controls.Add(this.lastnameTxb);
            this.Controls.Add(this.emailTxb);
            this.Controls.Add(this.addressTxb);
            this.Controls.Add(this.cityTxb);
            this.Controls.Add(this.countryTxb);
            this.Controls.Add(this.firstnameTxb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gendergroupBox.ResumeLayout(false);
            this.gendergroupBox.PerformLayout();
            this.citizengroupBox.ResumeLayout(false);
            this.citizengroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstnameTxb;
        private System.Windows.Forms.TextBox lastnameTxb;
        private System.Windows.Forms.Label firstnameLbl;
        private System.Windows.Forms.MaskedTextBox mobiletxb;
        private System.Windows.Forms.Label mobileLbl;
        private System.Windows.Forms.Label birthdateLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton maleBtn;
        private System.Windows.Forms.RadioButton femaleBtn;
        private System.Windows.Forms.GroupBox gendergroupBox;
        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label lastnameLbl;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.DateTimePicker birthdatetime;
        private System.Windows.Forms.Label citizenLbl;
        private System.Windows.Forms.GroupBox citizengroupBox;
        private System.Windows.Forms.RadioButton noBtn;
        private System.Windows.Forms.RadioButton yesBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label languagesLbl;
        private System.Windows.Forms.CheckBox engChbox;
        private System.Windows.Forms.CheckBox germanChbox;
        private System.Windows.Forms.CheckBox azChbox;
        private System.Windows.Forms.CheckBox turkChbox;
        private System.Windows.Forms.CheckBox arabianChbox;
        private System.Windows.Forms.CheckBox spainChbox;
        private System.Windows.Forms.TextBox countryTxb;
        private System.Windows.Forms.Label countryLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.TextBox cityTxb;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox addressTxb;
        private System.Windows.Forms.Label specialityLbl;
        private System.Windows.Forms.TextBox specialityTxb;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label firstwarnLbl;
        private System.Windows.Forms.Label lastwarnLbl;
        private System.Windows.Forms.Label genderwarnLbl;
        private System.Windows.Forms.Label specialtiywarnLbl;
        private System.Windows.Forms.Label emailwarnLbl;
        private System.Windows.Forms.Label birthdatewarnLbl;
        private System.Windows.Forms.Label numberwarnLbl;
        private System.Windows.Forms.Label countrywarnLbl;
        private System.Windows.Forms.Label citywarnLbl;
        private System.Windows.Forms.Label addresswarnLbl;
        private System.Windows.Forms.Label languageswarnLbl;
    }
}


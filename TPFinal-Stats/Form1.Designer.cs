namespace TPFinal_Stats
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LB_Pi = new System.Windows.Forms.Label();
            this.LB_IntervalleConfiance = new System.Windows.Forms.Label();
            this.LB_Probabilite = new System.Windows.Forms.Label();
            this.RB_Fonction1 = new System.Windows.Forms.RadioButton();
            this.PB_Fonction1 = new System.Windows.Forms.PictureBox();
            this.RB_Fonction2 = new System.Windows.Forms.RadioButton();
            this.PB_Fonction2 = new System.Windows.Forms.PictureBox();
            this.RB_Fonction3 = new System.Windows.Forms.RadioButton();
            this.PB_Fonction3 = new System.Windows.Forms.PictureBox();
            this.RB_Fonction4 = new System.Windows.Forms.RadioButton();
            this.PB_Fonction4 = new System.Windows.Forms.PictureBox();
            this.RB_Fonction5 = new System.Windows.Forms.RadioButton();
            this.PB_Fonction5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NUD_BorneA = new System.Windows.Forms.NumericUpDown();
            this.NUD_BorneB = new System.Windows.Forms.NumericUpDown();
            this.BTN_Calculer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_Ymin = new System.Windows.Forms.Label();
            this.LB_Ymax = new System.Windows.Forms.Label();
            this.LB_ME = new System.Windows.Forms.Label();
            this.TB_ME = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fonction1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fonction2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fonction3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fonction4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fonction5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BorneA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BorneB)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estimation de π:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Intervalle de confiance de l\'aire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "P(a < X < b) :";
            // 
            // LB_Pi
            // 
            this.LB_Pi.AutoSize = true;
            this.LB_Pi.BackColor = System.Drawing.Color.White;
            this.LB_Pi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_Pi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_Pi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Pi.Location = new System.Drawing.Point(26, 86);
            this.LB_Pi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Pi.MinimumSize = new System.Drawing.Size(120, 0);
            this.LB_Pi.Name = "LB_Pi";
            this.LB_Pi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_Pi.Size = new System.Drawing.Size(120, 29);
            this.LB_Pi.TabIndex = 9;
            this.LB_Pi.Text = "0";
            // 
            // LB_IntervalleConfiance
            // 
            this.LB_IntervalleConfiance.AutoSize = true;
            this.LB_IntervalleConfiance.BackColor = System.Drawing.Color.White;
            this.LB_IntervalleConfiance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_IntervalleConfiance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_IntervalleConfiance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_IntervalleConfiance.Location = new System.Drawing.Point(26, 403);
            this.LB_IntervalleConfiance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_IntervalleConfiance.MinimumSize = new System.Drawing.Size(300, 0);
            this.LB_IntervalleConfiance.Name = "LB_IntervalleConfiance";
            this.LB_IntervalleConfiance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_IntervalleConfiance.Size = new System.Drawing.Size(300, 29);
            this.LB_IntervalleConfiance.TabIndex = 10;
            this.LB_IntervalleConfiance.Text = "0";
            // 
            // LB_Probabilite
            // 
            this.LB_Probabilite.AutoSize = true;
            this.LB_Probabilite.BackColor = System.Drawing.Color.White;
            this.LB_Probabilite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_Probabilite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_Probabilite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Probabilite.Location = new System.Drawing.Point(26, 295);
            this.LB_Probabilite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Probabilite.MinimumSize = new System.Drawing.Size(120, 0);
            this.LB_Probabilite.Name = "LB_Probabilite";
            this.LB_Probabilite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_Probabilite.Size = new System.Drawing.Size(120, 29);
            this.LB_Probabilite.TabIndex = 11;
            this.LB_Probabilite.Text = "0";
            // 
            // RB_Fonction1
            // 
            this.RB_Fonction1.AutoSize = true;
            this.RB_Fonction1.Location = new System.Drawing.Point(9, 45);
            this.RB_Fonction1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_Fonction1.Name = "RB_Fonction1";
            this.RB_Fonction1.Size = new System.Drawing.Size(21, 20);
            this.RB_Fonction1.TabIndex = 0;
            this.RB_Fonction1.TabStop = true;
            this.RB_Fonction1.UseVisualStyleBackColor = true;
            this.RB_Fonction1.CheckedChanged += new System.EventHandler(this.RB_Fonction1_CheckedChanged);
            // 
            // PB_Fonction1
            // 
            this.PB_Fonction1.BackgroundImage = global::TPFinal_Stats.Properties.Resources.Fonction1;
            this.PB_Fonction1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Fonction1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_Fonction1.Location = new System.Drawing.Point(39, 29);
            this.PB_Fonction1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fonction1.Name = "PB_Fonction1";
            this.PB_Fonction1.Size = new System.Drawing.Size(268, 48);
            this.PB_Fonction1.TabIndex = 1;
            this.PB_Fonction1.TabStop = false;
            this.PB_Fonction1.Click += new System.EventHandler(this.PB_Fonction1_Click);
            // 
            // RB_Fonction2
            // 
            this.RB_Fonction2.AutoSize = true;
            this.RB_Fonction2.Location = new System.Drawing.Point(9, 105);
            this.RB_Fonction2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_Fonction2.Name = "RB_Fonction2";
            this.RB_Fonction2.Size = new System.Drawing.Size(21, 20);
            this.RB_Fonction2.TabIndex = 1;
            this.RB_Fonction2.TabStop = true;
            this.RB_Fonction2.UseVisualStyleBackColor = true;
            this.RB_Fonction2.CheckedChanged += new System.EventHandler(this.RB_Fonction2_CheckedChanged);
            // 
            // PB_Fonction2
            // 
            this.PB_Fonction2.BackgroundImage = global::TPFinal_Stats.Properties.Resources.Fonction2;
            this.PB_Fonction2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Fonction2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_Fonction2.Location = new System.Drawing.Point(39, 86);
            this.PB_Fonction2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fonction2.Name = "PB_Fonction2";
            this.PB_Fonction2.Size = new System.Drawing.Size(268, 58);
            this.PB_Fonction2.TabIndex = 2;
            this.PB_Fonction2.TabStop = false;
            this.PB_Fonction2.Click += new System.EventHandler(this.PB_Fonction2_Click);
            // 
            // RB_Fonction3
            // 
            this.RB_Fonction3.AutoSize = true;
            this.RB_Fonction3.Location = new System.Drawing.Point(9, 174);
            this.RB_Fonction3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_Fonction3.Name = "RB_Fonction3";
            this.RB_Fonction3.Size = new System.Drawing.Size(21, 20);
            this.RB_Fonction3.TabIndex = 2;
            this.RB_Fonction3.TabStop = true;
            this.RB_Fonction3.UseVisualStyleBackColor = true;
            this.RB_Fonction3.CheckedChanged += new System.EventHandler(this.RB_Fonction3_CheckedChanged);
            // 
            // PB_Fonction3
            // 
            this.PB_Fonction3.BackgroundImage = global::TPFinal_Stats.Properties.Resources.Fonction3;
            this.PB_Fonction3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Fonction3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_Fonction3.Location = new System.Drawing.Point(39, 154);
            this.PB_Fonction3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fonction3.Name = "PB_Fonction3";
            this.PB_Fonction3.Size = new System.Drawing.Size(222, 55);
            this.PB_Fonction3.TabIndex = 3;
            this.PB_Fonction3.TabStop = false;
            this.PB_Fonction3.Click += new System.EventHandler(this.PB_Fonction3_Click);
            // 
            // RB_Fonction4
            // 
            this.RB_Fonction4.AutoSize = true;
            this.RB_Fonction4.Location = new System.Drawing.Point(10, 232);
            this.RB_Fonction4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_Fonction4.Name = "RB_Fonction4";
            this.RB_Fonction4.Size = new System.Drawing.Size(21, 20);
            this.RB_Fonction4.TabIndex = 3;
            this.RB_Fonction4.TabStop = true;
            this.RB_Fonction4.UseVisualStyleBackColor = true;
            this.RB_Fonction4.CheckedChanged += new System.EventHandler(this.RB_Fonction4_CheckedChanged);
            // 
            // PB_Fonction4
            // 
            this.PB_Fonction4.BackgroundImage = global::TPFinal_Stats.Properties.Resources.Fonction4;
            this.PB_Fonction4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Fonction4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_Fonction4.Location = new System.Drawing.Point(39, 222);
            this.PB_Fonction4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fonction4.Name = "PB_Fonction4";
            this.PB_Fonction4.Size = new System.Drawing.Size(180, 42);
            this.PB_Fonction4.TabIndex = 4;
            this.PB_Fonction4.TabStop = false;
            this.PB_Fonction4.Click += new System.EventHandler(this.PB_Fonction4_Click);
            // 
            // RB_Fonction5
            // 
            this.RB_Fonction5.AutoSize = true;
            this.RB_Fonction5.Location = new System.Drawing.Point(9, 289);
            this.RB_Fonction5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_Fonction5.Name = "RB_Fonction5";
            this.RB_Fonction5.Size = new System.Drawing.Size(21, 20);
            this.RB_Fonction5.TabIndex = 4;
            this.RB_Fonction5.TabStop = true;
            this.RB_Fonction5.UseVisualStyleBackColor = true;
            this.RB_Fonction5.CheckedChanged += new System.EventHandler(this.RB_Fonction5_CheckedChanged);
            // 
            // PB_Fonction5
            // 
            this.PB_Fonction5.BackgroundImage = global::TPFinal_Stats.Properties.Resources.Fonction5;
            this.PB_Fonction5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Fonction5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_Fonction5.Location = new System.Drawing.Point(39, 277);
            this.PB_Fonction5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fonction5.Name = "PB_Fonction5";
            this.PB_Fonction5.Size = new System.Drawing.Size(180, 42);
            this.PB_Fonction5.TabIndex = 5;
            this.PB_Fonction5.TabStop = false;
            this.PB_Fonction5.Click += new System.EventHandler(this.PB_Fonction5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.PB_Fonction5);
            this.groupBox1.Controls.Add(this.RB_Fonction5);
            this.groupBox1.Controls.Add(this.PB_Fonction4);
            this.groupBox1.Controls.Add(this.RB_Fonction4);
            this.groupBox1.Controls.Add(this.PB_Fonction3);
            this.groupBox1.Controls.Add(this.RB_Fonction3);
            this.groupBox1.Controls.Add(this.PB_Fonction2);
            this.groupBox1.Controls.Add(this.RB_Fonction2);
            this.groupBox1.Controls.Add(this.PB_Fonction1);
            this.groupBox1.Controls.Add(this.RB_Fonction1);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(369, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fonctions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 431);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borne A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 431);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Borne B";
            // 
            // NUD_BorneA
            // 
            this.NUD_BorneA.BackColor = System.Drawing.Color.White;
            this.NUD_BorneA.DecimalPlaces = 2;
            this.NUD_BorneA.Location = new System.Drawing.Point(116, 428);
            this.NUD_BorneA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUD_BorneA.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NUD_BorneA.Name = "NUD_BorneA";
            this.NUD_BorneA.Size = new System.Drawing.Size(69, 26);
            this.NUD_BorneA.TabIndex = 3;
            this.NUD_BorneA.ValueChanged += new System.EventHandler(this.NUD_BorneA_ValueChanged);
            // 
            // NUD_BorneB
            // 
            this.NUD_BorneB.BackColor = System.Drawing.Color.White;
            this.NUD_BorneB.DecimalPlaces = 2;
            this.NUD_BorneB.Location = new System.Drawing.Point(306, 428);
            this.NUD_BorneB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUD_BorneB.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NUD_BorneB.Name = "NUD_BorneB";
            this.NUD_BorneB.Size = new System.Drawing.Size(69, 26);
            this.NUD_BorneB.TabIndex = 4;
            this.NUD_BorneB.Value = new decimal(new int[] {
            1100,
            0,
            0,
            131072});
            this.NUD_BorneB.ValueChanged += new System.EventHandler(this.NUD_BorneB_ValueChanged);
            // 
            // BTN_Calculer
            // 
            this.BTN_Calculer.Location = new System.Drawing.Point(44, 478);
            this.BTN_Calculer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Calculer.Name = "BTN_Calculer";
            this.BTN_Calculer.Size = new System.Drawing.Size(332, 35);
            this.BTN_Calculer.TabIndex = 12;
            this.BTN_Calculer.Text = "Calculer";
            this.BTN_Calculer.UseVisualStyleBackColor = true;
            this.BTN_Calculer.Click += new System.EventHandler(this.BTN_Calculer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 380);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y min: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 380);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Y max: ";
            // 
            // LB_Ymin
            // 
            this.LB_Ymin.AutoSize = true;
            this.LB_Ymin.BackColor = System.Drawing.Color.White;
            this.LB_Ymin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_Ymin.Location = new System.Drawing.Point(116, 380);
            this.LB_Ymin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Ymin.Name = "LB_Ymin";
            this.LB_Ymin.Size = new System.Drawing.Size(20, 22);
            this.LB_Ymin.TabIndex = 15;
            this.LB_Ymin.Text = "0";
            // 
            // LB_Ymax
            // 
            this.LB_Ymax.AutoSize = true;
            this.LB_Ymax.BackColor = System.Drawing.Color.White;
            this.LB_Ymax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_Ymax.Location = new System.Drawing.Point(306, 380);
            this.LB_Ymax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Ymax.Name = "LB_Ymax";
            this.LB_Ymax.Size = new System.Drawing.Size(20, 22);
            this.LB_Ymax.TabIndex = 16;
            this.LB_Ymax.Text = "5";
            // 
            // LB_ME
            // 
            this.LB_ME.AutoSize = true;
            this.LB_ME.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ME.Location = new System.Drawing.Point(20, 145);
            this.LB_ME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ME.Name = "LB_ME";
            this.LB_ME.Size = new System.Drawing.Size(238, 26);
            this.LB_ME.TabIndex = 6;
            this.LB_ME.Text = "Marge d\'erreur(ME):";
            // 
            // TB_ME
            // 
            this.TB_ME.AutoSize = true;
            this.TB_ME.BackColor = System.Drawing.Color.White;
            this.TB_ME.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TB_ME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TB_ME.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ME.Location = new System.Drawing.Point(26, 188);
            this.TB_ME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TB_ME.MinimumSize = new System.Drawing.Size(120, 0);
            this.TB_ME.Name = "TB_ME";
            this.TB_ME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_ME.Size = new System.Drawing.Size(120, 29);
            this.TB_ME.TabIndex = 9;
            this.TB_ME.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.LB_ME);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.LB_Pi);
            this.groupBox2.Controls.Add(this.TB_ME);
            this.groupBox2.Controls.Add(this.LB_Probabilite);
            this.groupBox2.Controls.Add(this.LB_IntervalleConfiance);
            this.groupBox2.Location = new System.Drawing.Point(422, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 493);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultats";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LB_Ymax);
            this.Controls.Add(this.LB_Ymin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTN_Calculer);
            this.Controls.Add(this.NUD_BorneB);
            this.Controls.Add(this.NUD_BorneA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Inférence et Probabilités";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fonction1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fonction2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fonction3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fonction4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fonction5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BorneA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BorneB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_Pi;
        private System.Windows.Forms.Label LB_IntervalleConfiance;
        private System.Windows.Forms.Label LB_Probabilite;
        private System.Windows.Forms.RadioButton RB_Fonction1;
        private System.Windows.Forms.PictureBox PB_Fonction1;
        private System.Windows.Forms.RadioButton RB_Fonction2;
        private System.Windows.Forms.PictureBox PB_Fonction2;
        private System.Windows.Forms.RadioButton RB_Fonction3;
        private System.Windows.Forms.PictureBox PB_Fonction3;
        private System.Windows.Forms.RadioButton RB_Fonction4;
        private System.Windows.Forms.PictureBox PB_Fonction4;
        private System.Windows.Forms.RadioButton RB_Fonction5;
        private System.Windows.Forms.PictureBox PB_Fonction5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUD_BorneA;
        private System.Windows.Forms.NumericUpDown NUD_BorneB;
        private System.Windows.Forms.Button BTN_Calculer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_Ymin;
        private System.Windows.Forms.Label LB_Ymax;
        private System.Windows.Forms.Label LB_ME;
        private System.Windows.Forms.Label TB_ME;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}


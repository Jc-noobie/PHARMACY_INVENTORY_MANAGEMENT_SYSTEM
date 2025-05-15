namespace PHARMACY_SYSTEM
{
    partial class insertMed
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.arrived_input = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.medID_input = new System.Windows.Forms.TextBox();
            this.gen_Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.brand_Input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.price_Input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantity_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.expiry_input = new System.Windows.Forms.DateTimePicker();
            this.stockBtn = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.RichTextBox();
            this.deletebtn = new FontAwesome.Sharp.IconButton();
            this.viewMed = new System.Windows.Forms.DataGridView();
            this.timelbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.typemenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.analgesicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antibioticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antidepressantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antihistaminesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antipyreticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anticonvulsantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antianxietyDrugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anticoagulantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antihypertensivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antifungalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiemeticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stimulantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depressantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallucinogensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medtypeBtn = new FontAwesome.Sharp.IconButton();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.showmedicine = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.medtype_input = new System.Windows.Forms.TextBox();
            this.viewTypeBtn = new FontAwesome.Sharp.IconButton();
            this.addType = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.updateTypeInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.updateNameInput = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.updateType = new FontAwesome.Sharp.IconButton();
            this.label17 = new System.Windows.Forms.Label();
            this.deleteTypeID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.deleteType = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewMed)).BeginInit();
            this.typemenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Special Gothic Expanded One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK MEDICINE";
            // 
            // arrived_input
            // 
            this.arrived_input.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            this.arrived_input.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrived_input.Location = new System.Drawing.Point(450, 459);
            this.arrived_input.Name = "arrived_input";
            this.arrived_input.Size = new System.Drawing.Size(155, 20);
            this.arrived_input.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicine ID :";
            // 
            // medID_input
            // 
            this.medID_input.Location = new System.Drawing.Point(156, 383);
            this.medID_input.Name = "medID_input";
            this.medID_input.Size = new System.Drawing.Size(100, 20);
            this.medID_input.TabIndex = 1;
            // 
            // gen_Input
            // 
            this.gen_Input.Location = new System.Drawing.Point(156, 434);
            this.gen_Input.Name = "gen_Input";
            this.gen_Input.Size = new System.Drawing.Size(100, 20);
            this.gen_Input.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Generic Name :";
            // 
            // brand_Input
            // 
            this.brand_Input.Location = new System.Drawing.Point(156, 461);
            this.brand_Input.Name = "brand_Input";
            this.brand_Input.Size = new System.Drawing.Size(100, 20);
            this.brand_Input.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Branded Name :";
            // 
            // price_Input
            // 
            this.price_Input.Location = new System.Drawing.Point(450, 384);
            this.price_Input.Name = "price_Input";
            this.price_Input.Size = new System.Drawing.Size(100, 20);
            this.price_Input.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price :";
            // 
            // quantity_input
            // 
            this.quantity_input.Location = new System.Drawing.Point(450, 409);
            this.quantity_input.Name = "quantity_input";
            this.quantity_input.Size = new System.Drawing.Size(100, 20);
            this.quantity_input.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Expiration Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date Arrived : ";
            // 
            // expiry_input
            // 
            this.expiry_input.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            this.expiry_input.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiry_input.Location = new System.Drawing.Point(450, 434);
            this.expiry_input.Name = "expiry_input";
            this.expiry_input.Size = new System.Drawing.Size(155, 20);
            this.expiry_input.TabIndex = 8;
            // 
            // stockBtn
            // 
            this.stockBtn.BackColor = System.Drawing.Color.Black;
            this.stockBtn.FlatAppearance.BorderSize = 0;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn.Font = new System.Drawing.Font("Special Gothic Expanded One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stockBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.stockBtn.IconColor = System.Drawing.Color.Black;
            this.stockBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.stockBtn.Location = new System.Drawing.Point(632, 384);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(75, 23);
            this.stockBtn.TabIndex = 10;
            this.stockBtn.Text = "STOCK";
            this.stockBtn.UseVisualStyleBackColor = false;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Description";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(156, 487);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(144, 56);
            this.descriptionInput.TabIndex = 5;
            this.descriptionInput.Text = "";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Black;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Special Gothic Expanded One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletebtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deletebtn.IconColor = System.Drawing.Color.Black;
            this.deletebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deletebtn.Location = new System.Drawing.Point(632, 413);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 12;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // viewMed
            // 
            this.viewMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewMed.Location = new System.Drawing.Point(23, 31);
            this.viewMed.Name = "viewMed";
            this.viewMed.Size = new System.Drawing.Size(730, 324);
            this.viewMed.TabIndex = 19;
            // 
            // timelbl
            // 
            this.timelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timelbl.AutoSize = true;
            this.timelbl.Location = new System.Drawing.Point(1053, 628);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(41, 13);
            this.timelbl.TabIndex = 21;
            this.timelbl.Text = "label10";
            // 
            // datelbl
            // 
            this.datelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(1053, 648);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(41, 13);
            this.datelbl.TabIndex = 22;
            this.datelbl.Text = "label11";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Medicine Type :";
            // 
            // typemenu
            // 
            this.typemenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analgesicsToolStripMenuItem,
            this.antibioticsToolStripMenuItem,
            this.antidepressantsToolStripMenuItem,
            this.antihistaminesToolStripMenuItem,
            this.antipyreticsToolStripMenuItem,
            this.anticonvulsantsToolStripMenuItem,
            this.antianxietyDrugsToolStripMenuItem,
            this.anticoagulantsToolStripMenuItem,
            this.antihypertensivesToolStripMenuItem,
            this.antifungalsToolStripMenuItem,
            this.antiemeticsToolStripMenuItem,
            this.stimulantsToolStripMenuItem,
            this.depressantsToolStripMenuItem,
            this.hallucinogensToolStripMenuItem});
            this.typemenu.Name = "typemenu";
            this.typemenu.Size = new System.Drawing.Size(169, 312);
            this.typemenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.typemenu_ItemClicked);
            // 
            // analgesicsToolStripMenuItem
            // 
            this.analgesicsToolStripMenuItem.Name = "analgesicsToolStripMenuItem";
            this.analgesicsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.analgesicsToolStripMenuItem.Text = "Analgesics";
            // 
            // antibioticsToolStripMenuItem
            // 
            this.antibioticsToolStripMenuItem.Name = "antibioticsToolStripMenuItem";
            this.antibioticsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.antibioticsToolStripMenuItem.Text = "Antibiotics";
            // 
            // antidepressantsToolStripMenuItem
            // 
            this.antidepressantsToolStripMenuItem.Name = "antidepressantsToolStripMenuItem";
            this.antidepressantsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.antidepressantsToolStripMenuItem.Text = "Antidepressants";
            // 
            // antihistaminesToolStripMenuItem
            // 
            this.antihistaminesToolStripMenuItem.Name = "antihistaminesToolStripMenuItem";
            this.antihistaminesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.antihistaminesToolStripMenuItem.Text = "Antihistamines";
            // 
            // antipyreticsToolStripMenuItem
            // 
            this.antipyreticsToolStripMenuItem.Name = "antipyreticsToolStripMenuItem";
            this.antipyreticsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.antipyreticsToolStripMenuItem.Text = "Antipyretics";
            // 
            // anticonvulsantsToolStripMenuItem
            // 
            this.anticonvulsantsToolStripMenuItem.Name = "anticonvulsantsToolStripMenuItem";
            this.anticonvulsantsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.anticonvulsantsToolStripMenuItem.Text = "Anticonvulsants";
            // 
            // antianxietyDrugsToolStripMenuItem
            // 
            this.antianxietyDrugsToolStripMenuItem.Name = "antianxietyDrugsToolStripMenuItem";
            this.antianxietyDrugsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.antianxietyDrugsToolStripMenuItem.Text = "Antianxiety Drugs";
            // 
            // anticoagulantsToolStripMenuItem
            // 
            this.anticoagulantsToolStripMenuItem.Name = "anticoagulantsToolStripMenuItem";
            this.anticoagulantsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.anticoagulantsToolStripMenuItem.Text = "Anticoagulants";
            // 
            // antihypertensivesToolStripMenuItem
            // 
            this.antihypertensivesToolStripMenuItem.Name = "antihypertensivesToolStripMenuItem";
            this.antihypertensivesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.antihypertensivesToolStripMenuItem.Text = "Antihypertensives";
            // 
            // antifungalsToolStripMenuItem
            // 
            this.antifungalsToolStripMenuItem.Name = "antifungalsToolStripMenuItem";
            this.antifungalsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.antifungalsToolStripMenuItem.Text = "Antifungals";
            // 
            // antiemeticsToolStripMenuItem
            // 
            this.antiemeticsToolStripMenuItem.Name = "antiemeticsToolStripMenuItem";
            this.antiemeticsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.antiemeticsToolStripMenuItem.Text = "Antiemetics";
            // 
            // stimulantsToolStripMenuItem
            // 
            this.stimulantsToolStripMenuItem.Name = "stimulantsToolStripMenuItem";
            this.stimulantsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stimulantsToolStripMenuItem.Text = "Stimulants";
            // 
            // depressantsToolStripMenuItem
            // 
            this.depressantsToolStripMenuItem.Name = "depressantsToolStripMenuItem";
            this.depressantsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.depressantsToolStripMenuItem.Text = "Depressants";
            // 
            // hallucinogensToolStripMenuItem
            // 
            this.hallucinogensToolStripMenuItem.Name = "hallucinogensToolStripMenuItem";
            this.hallucinogensToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.hallucinogensToolStripMenuItem.Text = "Hallucinogens";
            // 
            // medtypeBtn
            // 
            this.medtypeBtn.BackColor = System.Drawing.Color.White;
            this.medtypeBtn.FlatAppearance.BorderSize = 0;
            this.medtypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medtypeBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.medtypeBtn.IconColor = System.Drawing.Color.Black;
            this.medtypeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.medtypeBtn.Location = new System.Drawing.Point(156, 408);
            this.medtypeBtn.Name = "medtypeBtn";
            this.medtypeBtn.Size = new System.Drawing.Size(100, 20);
            this.medtypeBtn.TabIndex = 2;
            this.medtypeBtn.Text = "choose";
            this.medtypeBtn.UseVisualStyleBackColor = false;
            this.medtypeBtn.Click += new System.EventHandler(this.medtypeBtn_Click);
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.updatePanel.Location = new System.Drawing.Point(36, 31);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(351, 324);
            this.updatePanel.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(775, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 670);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(775, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 2);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(1, 606);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 2);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.updatePanel);
            this.panel4.Location = new System.Drawing.Point(778, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 355);
            this.panel4.TabIndex = 29;
            // 
            // showmedicine
            // 
            this.showmedicine.BackColor = System.Drawing.Color.Black;
            this.showmedicine.FlatAppearance.BorderSize = 0;
            this.showmedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showmedicine.Font = new System.Drawing.Font("Special Gothic Expanded One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showmedicine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showmedicine.IconChar = FontAwesome.Sharp.IconChar.None;
            this.showmedicine.IconColor = System.Drawing.Color.Black;
            this.showmedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showmedicine.Location = new System.Drawing.Point(632, 442);
            this.showmedicine.Name = "showmedicine";
            this.showmedicine.Size = new System.Drawing.Size(75, 23);
            this.showmedicine.TabIndex = 30;
            this.showmedicine.Text = "View";
            this.showmedicine.UseVisualStyleBackColor = false;
            this.showmedicine.Click += new System.EventHandler(this.showmedicine_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(776, 606);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 2);
            this.panel5.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Special Gothic Expanded One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "UPDATE MEDICINE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Special Gothic Expanded One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(781, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "ADD MEDICINE TYPE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(783, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Medicine type :";
            // 
            // medtype_input
            // 
            this.medtype_input.Location = new System.Drawing.Point(879, 383);
            this.medtype_input.Name = "medtype_input";
            this.medtype_input.Size = new System.Drawing.Size(100, 20);
            this.medtype_input.TabIndex = 34;
            // 
            // viewTypeBtn
            // 
            this.viewTypeBtn.BackColor = System.Drawing.Color.Black;
            this.viewTypeBtn.FlatAppearance.BorderSize = 0;
            this.viewTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTypeBtn.Font = new System.Drawing.Font("Special Gothic Expanded One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTypeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewTypeBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.viewTypeBtn.IconColor = System.Drawing.Color.Black;
            this.viewTypeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.viewTypeBtn.Location = new System.Drawing.Point(960, 577);
            this.viewTypeBtn.Name = "viewTypeBtn";
            this.viewTypeBtn.Size = new System.Drawing.Size(75, 23);
            this.viewTypeBtn.TabIndex = 35;
            this.viewTypeBtn.Text = "View";
            this.viewTypeBtn.UseVisualStyleBackColor = false;
            this.viewTypeBtn.Click += new System.EventHandler(this.viewTypeBtn_Click);
            // 
            // addType
            // 
            this.addType.BackColor = System.Drawing.Color.Black;
            this.addType.FlatAppearance.BorderSize = 0;
            this.addType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addType.Font = new System.Drawing.Font("Special Gothic Expanded One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addType.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addType.IconColor = System.Drawing.Color.Black;
            this.addType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addType.Location = new System.Drawing.Point(985, 380);
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(65, 23);
            this.addType.TabIndex = 36;
            this.addType.Text = "Add";
            this.addType.UseVisualStyleBackColor = false;
            this.addType.Click += new System.EventHandler(this.addType_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Special Gothic Expanded One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(783, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "UPDATE MEDICINE TYPE";
            // 
            // updateTypeInput
            // 
            this.updateTypeInput.Location = new System.Drawing.Point(879, 451);
            this.updateTypeInput.Name = "updateTypeInput";
            this.updateTypeInput.Size = new System.Drawing.Size(100, 20);
            this.updateTypeInput.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(783, 452);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "Medicine ID:";
            // 
            // updateNameInput
            // 
            this.updateNameInput.Location = new System.Drawing.Point(879, 474);
            this.updateNameInput.Name = "updateNameInput";
            this.updateNameInput.Size = new System.Drawing.Size(100, 20);
            this.updateNameInput.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(783, 474);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Medicine type :";
            // 
            // updateType
            // 
            this.updateType.BackColor = System.Drawing.Color.Black;
            this.updateType.FlatAppearance.BorderSize = 0;
            this.updateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateType.Font = new System.Drawing.Font("Special Gothic Expanded One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateType.IconChar = FontAwesome.Sharp.IconChar.None;
            this.updateType.IconColor = System.Drawing.Color.Black;
            this.updateType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateType.Location = new System.Drawing.Point(985, 460);
            this.updateType.Name = "updateType";
            this.updateType.Size = new System.Drawing.Size(75, 23);
            this.updateType.TabIndex = 42;
            this.updateType.Text = "Update";
            this.updateType.UseVisualStyleBackColor = false;
            this.updateType.Click += new System.EventHandler(this.updateType_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Special Gothic Expanded One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(783, 515);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 16);
            this.label17.TabIndex = 43;
            this.label17.Text = "DELETE MEDICINE TYPE";
            // 
            // deleteTypeID
            // 
            this.deleteTypeID.Location = new System.Drawing.Point(878, 534);
            this.deleteTypeID.Name = "deleteTypeID";
            this.deleteTypeID.Size = new System.Drawing.Size(100, 20);
            this.deleteTypeID.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(782, 535);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 16);
            this.label18.TabIndex = 44;
            this.label18.Text = "Type ID :";
            // 
            // deleteType
            // 
            this.deleteType.BackColor = System.Drawing.Color.Black;
            this.deleteType.FlatAppearance.BorderSize = 0;
            this.deleteType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteType.Font = new System.Drawing.Font("Special Gothic Expanded One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteType.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deleteType.IconColor = System.Drawing.Color.Black;
            this.deleteType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteType.Location = new System.Drawing.Point(985, 533);
            this.deleteType.Name = "deleteType";
            this.deleteType.Size = new System.Drawing.Size(75, 23);
            this.deleteType.TabIndex = 46;
            this.deleteType.Text = "Delete";
            this.deleteType.UseVisualStyleBackColor = false;
            this.deleteType.Click += new System.EventHandler(this.deleteType_Click);
            // 
            // insertMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1193, 670);
            this.Controls.Add(this.deleteType);
            this.Controls.Add(this.deleteTypeID);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.updateType);
            this.Controls.Add(this.updateNameInput);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.updateTypeInput);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.addType);
            this.Controls.Add(this.viewTypeBtn);
            this.Controls.Add(this.medtype_input);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.showmedicine);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.medtypeBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.viewMed);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stockBtn);
            this.Controls.Add(this.expiry_input);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantity_input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.price_Input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brand_Input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gen_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.medID_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrived_input);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertMed";
            this.Text = "insertMed";
            this.Load += new System.EventHandler(this.insertMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewMed)).EndInit();
            this.typemenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker arrived_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox medID_input;
        private System.Windows.Forms.TextBox gen_Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox brand_Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price_Input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantity_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker expiry_input;
        private FontAwesome.Sharp.IconButton stockBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox descriptionInput;
        private FontAwesome.Sharp.IconButton deletebtn;
        private System.Windows.Forms.DataGridView viewMed;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip typemenu;
        private FontAwesome.Sharp.IconButton medtypeBtn;
        private System.Windows.Forms.ToolStripMenuItem analgesicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antibioticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antidepressantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antihistaminesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antipyreticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anticonvulsantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antianxietyDrugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anticoagulantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antihypertensivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antifungalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiemeticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stimulantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depressantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallucinogensToolStripMenuItem;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton showmedicine;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox medtype_input;
        private FontAwesome.Sharp.IconButton viewTypeBtn;
        private FontAwesome.Sharp.IconButton addType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox updateTypeInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox updateNameInput;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton updateType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox deleteTypeID;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconButton deleteType;
    }
}
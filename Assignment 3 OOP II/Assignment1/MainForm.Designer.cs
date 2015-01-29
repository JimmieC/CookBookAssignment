namespace Assignment1
{
    partial class MainForm
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
            this.gbrecipes = new System.Windows.Forms.GroupBox();
            this.btnAddRecepie = new System.Windows.Forms.Button();
            this.lstRecepter = new System.Windows.Forms.ListBox();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.btnChangeRecipe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lstIng = new System.Windows.Forms.ListBox();
            this.lblInstuktioner = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öpnnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbrecipes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbrecipes
            // 
            this.gbrecipes.Controls.Add(this.btnAddRecepie);
            this.gbrecipes.Controls.Add(this.lstRecepter);
            this.gbrecipes.Controls.Add(this.btnDeleteRecipe);
            this.gbrecipes.Controls.Add(this.btnChangeRecipe);
            this.gbrecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrecipes.Location = new System.Drawing.Point(20, 36);
            this.gbrecipes.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbrecipes.Name = "gbrecipes";
            this.gbrecipes.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbrecipes.Size = new System.Drawing.Size(349, 654);
            this.gbrecipes.TabIndex = 30;
            this.gbrecipes.TabStop = false;
            this.gbrecipes.Text = "Recipies";
            // 
            // btnAddRecepie
            // 
            this.btnAddRecepie.Location = new System.Drawing.Point(21, 535);
            this.btnAddRecepie.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnAddRecepie.Name = "btnAddRecepie";
            this.btnAddRecepie.Size = new System.Drawing.Size(93, 82);
            this.btnAddRecepie.TabIndex = 27;
            this.btnAddRecepie.Text = "Add Recipe";
            this.btnAddRecepie.UseVisualStyleBackColor = true;
            this.btnAddRecepie.Click += new System.EventHandler(this.btnAddRecepie_Click);
            // 
            // lstRecepter
            // 
            this.lstRecepter.FormattingEnabled = true;
            this.lstRecepter.ItemHeight = 20;
            this.lstRecepter.Location = new System.Drawing.Point(21, 31);
            this.lstRecepter.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.lstRecepter.Name = "lstRecepter";
            this.lstRecepter.Size = new System.Drawing.Size(311, 484);
            this.lstRecepter.TabIndex = 24;
            this.lstRecepter.SelectedIndexChanged += new System.EventHandler(this.lstRecepter_SelectedIndexChanged);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Location = new System.Drawing.Point(240, 535);
            this.btnDeleteRecipe.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(93, 85);
            this.btnDeleteRecipe.TabIndex = 26;
            this.btnDeleteRecipe.Text = "Delete Recipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click_1);
            // 
            // btnChangeRecipe
            // 
            this.btnChangeRecipe.Location = new System.Drawing.Point(131, 535);
            this.btnChangeRecipe.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnChangeRecipe.Name = "btnChangeRecipe";
            this.btnChangeRecipe.Size = new System.Drawing.Size(93, 82);
            this.btnChangeRecipe.TabIndex = 25;
            this.btnChangeRecipe.Text = "Change Recipe";
            this.btnChangeRecipe.UseVisualStyleBackColor = true;
            this.btnChangeRecipe.Click += new System.EventHandler(this.btnChangeRecipe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lstIng);
            this.groupBox1.Controls.Add(this.lblInstuktioner);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(385, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBox1.Size = new System.Drawing.Size(741, 654);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Recipe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Instructions :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Type of Meat/Fish : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name :";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Location = new System.Drawing.Point(477, 76);
            this.pbImage.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(231, 201);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 22;
            this.pbImage.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.Location = new System.Drawing.Point(187, 26);
            this.lblname.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(128, 20);
            this.lblname.TabIndex = 8;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(187, 50);
            this.lblType.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(155, 20);
            this.lblType.TabIndex = 9;
            // 
            // lstIng
            // 
            this.lstIng.FormattingEnabled = true;
            this.lstIng.ItemHeight = 20;
            this.lstIng.Location = new System.Drawing.Point(191, 76);
            this.lstIng.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.lstIng.Name = "lstIng";
            this.lstIng.Size = new System.Drawing.Size(269, 184);
            this.lstIng.TabIndex = 17;
            // 
            // lblInstuktioner
            // 
            this.lblInstuktioner.Location = new System.Drawing.Point(187, 289);
            this.lblInstuktioner.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblInstuktioner.Name = "lblInstuktioner";
            this.lblInstuktioner.Size = new System.Drawing.Size(107, 20);
            this.lblInstuktioner.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ingredients";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyToolStripMenuItem,
            this.öpnnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem,
            this.toolStripMenuItem2,
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.arkivToolStripMenuItem.Text = "&Arkiv";
            // 
            // nyToolStripMenuItem
            // 
            this.nyToolStripMenuItem.Name = "nyToolStripMenuItem";
            this.nyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.nyToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.nyToolStripMenuItem.Text = "&Ny";
            this.nyToolStripMenuItem.Click += new System.EventHandler(this.nyToolStripMenuItem_Click);
            // 
            // öpnnaToolStripMenuItem
            // 
            this.öpnnaToolStripMenuItem.Name = "öpnnaToolStripMenuItem";
            this.öpnnaToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.öpnnaToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.öpnnaToolStripMenuItem.Text = "&Öpnna...";
            this.öpnnaToolStripMenuItem.Click += new System.EventHandler(this.öpnnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.sparaToolStripMenuItem.Text = "&Spara";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.sparaSomToolStripMenuItem.Text = "&Spara som...";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.sparaSomToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 6);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + X";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.avslutaToolStripMenuItem.Text = "&Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1143, 745);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbrecipes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.gbrecipes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbrecipes;
        private System.Windows.Forms.ListBox lstRecepter;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.Button btnChangeRecipe;
        private System.Windows.Forms.Button btnAddRecepie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ListBox lstIng;
        private System.Windows.Forms.Label lblInstuktioner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öpnnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
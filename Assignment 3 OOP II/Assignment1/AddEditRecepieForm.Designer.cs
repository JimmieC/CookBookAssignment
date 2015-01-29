namespace Assignment1
{
    partial class AddEditRecepieForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtbeskrivning = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbMeat = new System.Windows.Forms.RadioButton();
            this.rdbFish = new System.Windows.Forms.RadioButton();
            this.lstIng = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddIngridient = new System.Windows.Forms.Button();
            this.txtMeasureamount = new System.Windows.Forms.TextBox();
            this.cmbmeasure = new System.Windows.Forms.ComboBox();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name of Recipe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Type of Meat/Fish";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(178, 600);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 64);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Recipie";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(127, 34);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(197, 23);
            this.txtname.TabIndex = 0;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(127, 76);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(197, 23);
            this.txtType.TabIndex = 1;
            // 
            // txtbeskrivning
            // 
            this.txtbeskrivning.Location = new System.Drawing.Point(127, 358);
            this.txtbeskrivning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbeskrivning.Multiline = true;
            this.txtbeskrivning.Name = "txtbeskrivning";
            this.txtbeskrivning.Size = new System.Drawing.Size(197, 221);
            this.txtbeskrivning.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ingredients";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 358);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Instructions";
            // 
            // rdbMeat
            // 
            this.rdbMeat.AutoSize = true;
            this.rdbMeat.Checked = true;
            this.rdbMeat.Location = new System.Drawing.Point(135, 107);
            this.rdbMeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMeat.Name = "rdbMeat";
            this.rdbMeat.Size = new System.Drawing.Size(55, 20);
            this.rdbMeat.TabIndex = 13;
            this.rdbMeat.TabStop = true;
            this.rdbMeat.Text = "Meat";
            this.rdbMeat.UseVisualStyleBackColor = true;
            // 
            // rdbFish
            // 
            this.rdbFish.AutoSize = true;
            this.rdbFish.Location = new System.Drawing.Point(274, 107);
            this.rdbFish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbFish.Name = "rdbFish";
            this.rdbFish.Size = new System.Drawing.Size(50, 20);
            this.rdbFish.TabIndex = 14;
            this.rdbFish.Text = "Fish";
            this.rdbFish.UseVisualStyleBackColor = true;
            // 
            // lstIng
            // 
            this.lstIng.FormattingEnabled = true;
            this.lstIng.ItemHeight = 16;
            this.lstIng.Location = new System.Drawing.Point(127, 135);
            this.lstIng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstIng.Name = "lstIng";
            this.lstIng.Size = new System.Drawing.Size(197, 116);
            this.lstIng.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteIngredient);
            this.groupBox1.Controls.Add(this.btnAddImage);
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonAddIngridient);
            this.groupBox1.Controls.Add(this.lstIng);
            this.groupBox1.Controls.Add(this.txtMeasureamount);
            this.groupBox1.Controls.Add(this.cmbmeasure);
            this.groupBox1.Controls.Add(this.rdbFish);
            this.groupBox1.Controls.Add(this.rdbMeat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtbeskrivning);
            this.groupBox1.Controls.Add(this.txtIngredients);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Font = new System.Drawing.Font("GOST Common", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(570, 730);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Location = new System.Drawing.Point(229, 311);
            this.btnDeleteIngredient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(148, 36);
            this.btnDeleteIngredient.TabIndex = 24;
            this.btnDeleteIngredient.Text = "Delete Ingrediet";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(385, 530);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(94, 64);
            this.btnAddImage.TabIndex = 23;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "  Ingredient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 287);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Measurement type";
            // 
            // buttonAddIngridient
            // 
            this.buttonAddIngridient.Location = new System.Drawing.Point(90, 311);
            this.buttonAddIngridient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddIngridient.Name = "buttonAddIngridient";
            this.buttonAddIngridient.Size = new System.Drawing.Size(128, 36);
            this.buttonAddIngridient.TabIndex = 18;
            this.buttonAddIngridient.Text = "Add Ingredient";
            this.buttonAddIngridient.UseVisualStyleBackColor = true;
            this.buttonAddIngridient.Click += new System.EventHandler(this.buttonAddIngridient_Click);
            // 
            // txtMeasureamount
            // 
            this.txtMeasureamount.Location = new System.Drawing.Point(127, 259);
            this.txtMeasureamount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMeasureamount.Name = "txtMeasureamount";
            this.txtMeasureamount.Size = new System.Drawing.Size(43, 23);
            this.txtMeasureamount.TabIndex = 16;
            // 
            // cmbmeasure
            // 
            this.cmbmeasure.FormattingEnabled = true;
            this.cmbmeasure.Location = new System.Drawing.Point(178, 259);
            this.cmbmeasure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbmeasure.Name = "cmbmeasure";
            this.cmbmeasure.Size = new System.Drawing.Size(59, 24);
            this.cmbmeasure.TabIndex = 15;
            // 
            // txtIngredients
            // 
            this.txtIngredients.Location = new System.Drawing.Point(245, 260);
            this.txtIngredients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIngredients.Multiline = true;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.Size = new System.Drawing.Size(79, 23);
            this.txtIngredients.TabIndex = 2;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Location = new System.Drawing.Point(343, 358);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(196, 164);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 22;
            this.pbImage.TabStop = false;
            // 
            // AddEditRecepieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(636, 757);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEditRecepieForm";
            this.Text = "Kok Bok";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtbeskrivning;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbMeat;
        private System.Windows.Forms.RadioButton rdbFish;
        private System.Windows.Forms.ListBox lstIng;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddIngridient;
        private System.Windows.Forms.TextBox txtMeasureamount;
        private System.Windows.Forms.ComboBox cmbmeasure;
        private System.Windows.Forms.TextBox txtIngredients;
    }
}


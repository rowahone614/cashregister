namespace cashregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.muttonAmount = new System.Windows.Forms.NumericUpDown();
            this.wineAmount = new System.Windows.Forms.NumericUpDown();
            this.tartAmount = new System.Windows.Forms.NumericUpDown();
            this.titleHeading = new System.Windows.Forms.Label();
            this.muttonLabel = new System.Windows.Forms.Label();
            this.glueLabel = new System.Windows.Forms.Label();
            this.melonLabel = new System.Windows.Forms.Label();
            this.muttonPrice = new System.Windows.Forms.Label();
            this.winePrice = new System.Windows.Forms.Label();
            this.tartPrice = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.feastButton = new System.Windows.Forms.Button();
            this.taxLabel = new System.Windows.Forms.Label();
            this.grandTotal = new System.Windows.Forms.Label();
            this.tenderLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeValue = new System.Windows.Forms.Label();
            this.tenderValue = new System.Windows.Forms.TextBox();
            this.receiptTitle = new System.Windows.Forms.Label();
            this.receiptOutPut = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.notenoughLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.muttonAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wineAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tartAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // muttonAmount
            // 
            this.muttonAmount.Location = new System.Drawing.Point(150, 75);
            this.muttonAmount.Name = "muttonAmount";
            this.muttonAmount.Size = new System.Drawing.Size(53, 20);
            this.muttonAmount.TabIndex = 0;
            // 
            // wineAmount
            // 
            this.wineAmount.Location = new System.Drawing.Point(150, 117);
            this.wineAmount.Name = "wineAmount";
            this.wineAmount.Size = new System.Drawing.Size(53, 20);
            this.wineAmount.TabIndex = 1;
            // 
            // tartAmount
            // 
            this.tartAmount.Location = new System.Drawing.Point(150, 160);
            this.tartAmount.Name = "tartAmount";
            this.tartAmount.Size = new System.Drawing.Size(53, 20);
            this.tartAmount.TabIndex = 2;
            // 
            // titleHeading
            // 
            this.titleHeading.Font = new System.Drawing.Font("Quorum Md BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleHeading.ForeColor = System.Drawing.Color.White;
            this.titleHeading.Image = global::cashregister.Properties.Resources.jpeg;
            this.titleHeading.Location = new System.Drawing.Point(4, 3);
            this.titleHeading.Name = "titleHeading";
            this.titleHeading.Size = new System.Drawing.Size(797, 56);
            this.titleHeading.TabIndex = 3;
            this.titleHeading.Text = "Giovanni\'s Renaissance Cuisine";
            this.titleHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // muttonLabel
            // 
            this.muttonLabel.AutoSize = true;
            this.muttonLabel.Font = new System.Drawing.Font("Quorum Md BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muttonLabel.Location = new System.Drawing.Point(17, 73);
            this.muttonLabel.Name = "muttonLabel";
            this.muttonLabel.Size = new System.Drawing.Size(127, 22);
            this.muttonLabel.TabIndex = 4;
            this.muttonLabel.Text = "Leg of Mutton";
            // 
            // glueLabel
            // 
            this.glueLabel.AutoSize = true;
            this.glueLabel.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.glueLabel.Location = new System.Drawing.Point(51, 117);
            this.glueLabel.Name = "glueLabel";
            this.glueLabel.Size = new System.Drawing.Size(93, 22);
            this.glueLabel.TabIndex = 5;
            this.glueLabel.Text = "Gluehwein";
            // 
            // melonLabel
            // 
            this.melonLabel.AutoSize = true;
            this.melonLabel.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.melonLabel.Location = new System.Drawing.Point(45, 158);
            this.melonLabel.Name = "melonLabel";
            this.melonLabel.Size = new System.Drawing.Size(99, 22);
            this.melonLabel.TabIndex = 6;
            this.melonLabel.Text = "Melon Tart";
            // 
            // muttonPrice
            // 
            this.muttonPrice.AutoSize = true;
            this.muttonPrice.Font = new System.Drawing.Font("Quorum Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muttonPrice.Location = new System.Drawing.Point(221, 73);
            this.muttonPrice.Name = "muttonPrice";
            this.muttonPrice.Size = new System.Drawing.Size(71, 22);
            this.muttonPrice.TabIndex = 7;
            this.muttonPrice.Text = "$22.75";
            // 
            // winePrice
            // 
            this.winePrice.AutoSize = true;
            this.winePrice.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.winePrice.Location = new System.Drawing.Point(221, 115);
            this.winePrice.Name = "winePrice";
            this.winePrice.Size = new System.Drawing.Size(60, 22);
            this.winePrice.TabIndex = 8;
            this.winePrice.Text = "$7.50";
            // 
            // tartPrice
            // 
            this.tartPrice.AutoSize = true;
            this.tartPrice.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.tartPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tartPrice.Location = new System.Drawing.Point(221, 158);
            this.tartPrice.Name = "tartPrice";
            this.tartPrice.Size = new System.Drawing.Size(71, 22);
            this.tartPrice.TabIndex = 9;
            this.tartPrice.Text = "$14.25";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.subtotalLabel.Location = new System.Drawing.Point(45, 249);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(0, 22);
            this.subtotalLabel.TabIndex = 10;
            // 
            // feastButton
            // 
            this.feastButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.feastButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.feastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feastButton.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.feastButton.ForeColor = System.Drawing.Color.SeaShell;
            this.feastButton.Location = new System.Drawing.Point(55, 195);
            this.feastButton.Name = "feastButton";
            this.feastButton.Size = new System.Drawing.Size(226, 28);
            this.feastButton.TabIndex = 11;
            this.feastButton.Text = "Feast!";
            this.feastButton.UseVisualStyleBackColor = false;
            this.feastButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.taxLabel.Location = new System.Drawing.Point(45, 288);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(0, 22);
            this.taxLabel.TabIndex = 12;
            // 
            // grandTotal
            // 
            this.grandTotal.AutoSize = true;
            this.grandTotal.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.grandTotal.Location = new System.Drawing.Point(45, 326);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.Size = new System.Drawing.Size(0, 22);
            this.grandTotal.TabIndex = 13;
            // 
            // tenderLabel
            // 
            this.tenderLabel.AutoSize = true;
            this.tenderLabel.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.tenderLabel.Location = new System.Drawing.Point(12, 357);
            this.tenderLabel.Name = "tenderLabel";
            this.tenderLabel.Size = new System.Drawing.Size(85, 22);
            this.tenderLabel.TabIndex = 15;
            this.tenderLabel.Text = "Tendered";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.changeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeButton.Location = new System.Drawing.Point(10, 382);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(161, 37);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // changeValue
            // 
            this.changeValue.AutoSize = true;
            this.changeValue.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.changeValue.Location = new System.Drawing.Point(12, 422);
            this.changeValue.Name = "changeValue";
            this.changeValue.Size = new System.Drawing.Size(0, 22);
            this.changeValue.TabIndex = 17;
            // 
            // tenderValue
            // 
            this.tenderValue.Location = new System.Drawing.Point(101, 359);
            this.tenderValue.Name = "tenderValue";
            this.tenderValue.Size = new System.Drawing.Size(70, 20);
            this.tenderValue.TabIndex = 18;
            // 
            // receiptTitle
            // 
            this.receiptTitle.BackColor = System.Drawing.Color.White;
            this.receiptTitle.Font = new System.Drawing.Font("Courier New", 10F);
            this.receiptTitle.Location = new System.Drawing.Point(353, 73);
            this.receiptTitle.Name = "receiptTitle";
            this.receiptTitle.Size = new System.Drawing.Size(287, 366);
            this.receiptTitle.TabIndex = 19;
            this.receiptTitle.Text = "Giovanni\'s Renaissance Cuisine";
            this.receiptTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // receiptOutPut
            // 
            this.receiptOutPut.BackColor = System.Drawing.Color.White;
            this.receiptOutPut.Location = new System.Drawing.Point(378, 115);
            this.receiptOutPut.Name = "receiptOutPut";
            this.receiptOutPut.Size = new System.Drawing.Size(260, 304);
            this.receiptOutPut.TabIndex = 20;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.printButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printButton.Location = new System.Drawing.Point(177, 382);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(163, 37);
            this.printButton.TabIndex = 21;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Black;
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.newButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.newButton.Location = new System.Drawing.Point(659, 345);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(129, 74);
            this.newButton.TabIndex = 22;
            this.newButton.Text = "New Customer";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // notenoughLabel
            // 
            this.notenoughLabel.AutoSize = true;
            this.notenoughLabel.Font = new System.Drawing.Font("Quorum Md BT", 14F);
            this.notenoughLabel.Location = new System.Drawing.Point(17, 422);
            this.notenoughLabel.Name = "notenoughLabel";
            this.notenoughLabel.Size = new System.Drawing.Size(0, 22);
            this.notenoughLabel.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notenoughLabel);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.receiptOutPut);
            this.Controls.Add(this.receiptTitle);
            this.Controls.Add(this.tenderValue);
            this.Controls.Add(this.changeValue);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderLabel);
            this.Controls.Add(this.grandTotal);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.feastButton);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.tartPrice);
            this.Controls.Add(this.winePrice);
            this.Controls.Add(this.muttonPrice);
            this.Controls.Add(this.melonLabel);
            this.Controls.Add(this.glueLabel);
            this.Controls.Add(this.muttonLabel);
            this.Controls.Add(this.titleHeading);
            this.Controls.Add(this.tartAmount);
            this.Controls.Add(this.wineAmount);
            this.Controls.Add(this.muttonAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RH - Cash Register";
            ((System.ComponentModel.ISupportInitialize)(this.muttonAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wineAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tartAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown muttonAmount;
        private System.Windows.Forms.NumericUpDown wineAmount;
        private System.Windows.Forms.NumericUpDown tartAmount;
        private System.Windows.Forms.Label titleHeading;
        private System.Windows.Forms.Label muttonLabel;
        private System.Windows.Forms.Label glueLabel;
        private System.Windows.Forms.Label melonLabel;
        private System.Windows.Forms.Label muttonPrice;
        private System.Windows.Forms.Label winePrice;
        private System.Windows.Forms.Label tartPrice;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Button feastButton;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label grandTotal;
        private System.Windows.Forms.Label tenderLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeValue;
        private System.Windows.Forms.TextBox tenderValue;
        private System.Windows.Forms.Label receiptTitle;
        private System.Windows.Forms.Label receiptOutPut;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label notenoughLabel;
    }
}


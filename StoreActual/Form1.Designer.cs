namespace StoreActual
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
            this.grandtotalLabel = new System.Windows.Forms.Label();
            this.taxtwoLabel = new System.Windows.Forms.Label();
            this.subtotLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.helmetInput = new System.Windows.Forms.TextBox();
            this.skatesInput = new System.Windows.Forms.TextBox();
            this.stickInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tenInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grandtotalLabel
            // 
            this.grandtotalLabel.AutoSize = true;
            this.grandtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotalLabel.Location = new System.Drawing.Point(153, 208);
            this.grandtotalLabel.Name = "grandtotalLabel";
            this.grandtotalLabel.Size = new System.Drawing.Size(0, 20);
            this.grandtotalLabel.TabIndex = 25;
            // 
            // taxtwoLabel
            // 
            this.taxtwoLabel.AutoSize = true;
            this.taxtwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxtwoLabel.Location = new System.Drawing.Point(153, 175);
            this.taxtwoLabel.Name = "taxtwoLabel";
            this.taxtwoLabel.Size = new System.Drawing.Size(0, 20);
            this.taxtwoLabel.TabIndex = 24;
            this.taxtwoLabel.Click += new System.EventHandler(this.taxtwoLabel_Click);
            // 
            // subtotLabel
            // 
            this.subtotLabel.AutoSize = true;
            this.subtotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotLabel.Location = new System.Drawing.Point(153, 142);
            this.subtotLabel.Name = "subtotLabel";
            this.subtotLabel.Size = new System.Drawing.Size(0, 20);
            this.subtotLabel.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Grand Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Subtotal";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(21, 116);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(173, 23);
            this.calculateButton.TabIndex = 19;
            this.calculateButton.Text = "calculate total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // helmetInput
            // 
            this.helmetInput.Location = new System.Drawing.Point(168, 93);
            this.helmetInput.Name = "helmetInput";
            this.helmetInput.Size = new System.Drawing.Size(26, 20);
            this.helmetInput.TabIndex = 18;
            // 
            // skatesInput
            // 
            this.skatesInput.Location = new System.Drawing.Point(168, 73);
            this.skatesInput.Name = "skatesInput";
            this.skatesInput.Size = new System.Drawing.Size(26, 20);
            this.skatesInput.TabIndex = 17;
            // 
            // stickInput
            // 
            this.stickInput.Location = new System.Drawing.Point(168, 54);
            this.stickInput.Name = "stickInput";
            this.stickInput.Size = new System.Drawing.Size(26, 20);
            this.stickInput.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "number of helmets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "number of skates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "number of sticks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tendered";
            // 
            // tenInput
            // 
            this.tenInput.Location = new System.Drawing.Point(157, 275);
            this.tenInput.Name = "tenInput";
            this.tenInput.Size = new System.Drawing.Size(37, 20);
            this.tenInput.TabIndex = 27;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(21, 301);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(173, 23);
            this.changeButton.TabIndex = 28;
            this.changeButton.Text = "calculate change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Change";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(153, 342);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(0, 20);
            this.changeLabel.TabIndex = 30;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(25, 390);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(169, 48);
            this.printButton.TabIndex = 31;
            this.printButton.Text = "print receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(268, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 48);
            this.button1.TabIndex = 32;
            this.button1.Text = "Create New Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(27, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(453, 37);
            this.button2.TabIndex = 33;
            this.button2.Text = "Jacob\'s Hockey Shop";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grandtotalLabel);
            this.Controls.Add(this.taxtwoLabel);
            this.Controls.Add(this.subtotLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.helmetInput);
            this.Controls.Add(this.skatesInput);
            this.Controls.Add(this.stickInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grandtotalLabel;
        private System.Windows.Forms.Label taxtwoLabel;
        private System.Windows.Forms.Label subtotLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox helmetInput;
        private System.Windows.Forms.TextBox skatesInput;
        private System.Windows.Forms.TextBox stickInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printButton;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


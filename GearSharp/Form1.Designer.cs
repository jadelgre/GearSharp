namespace GearSharp
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
            this.inputOriginalSize = new System.Windows.Forms.TextBox();
            this.inputNewSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputRatio = new System.Windows.Forms.TextBox();
            this.outputNewRatio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputOriginalSize
            // 
            this.inputOriginalSize.Location = new System.Drawing.Point(26, 32);
            this.inputOriginalSize.Name = "inputOriginalSize";
            this.inputOriginalSize.Size = new System.Drawing.Size(100, 20);
            this.inputOriginalSize.TabIndex = 0;
            this.inputOriginalSize.TextChanged += new System.EventHandler(this.inputOriginalSize_TextChanged);
            // 
            // inputNewSize
            // 
            this.inputNewSize.Location = new System.Drawing.Point(26, 63);
            this.inputNewSize.Name = "inputNewSize";
            this.inputNewSize.Size = new System.Drawing.Size(100, 20);
            this.inputNewSize.TabIndex = 3;
            this.inputNewSize.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Original Tire Size (Inches)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Tire Size";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputRatio
            // 
            this.inputRatio.Location = new System.Drawing.Point(26, 94);
            this.inputRatio.Name = "inputRatio";
            this.inputRatio.Size = new System.Drawing.Size(100, 20);
            this.inputRatio.TabIndex = 6;
            this.inputRatio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // outputNewRatio
            // 
            this.outputNewRatio.Location = new System.Drawing.Point(48, 209);
            this.outputNewRatio.Name = "outputNewRatio";
            this.outputNewRatio.ReadOnly = true;
            this.outputNewRatio.Size = new System.Drawing.Size(100, 20);
            this.outputNewRatio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current Gear Ratio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "New Gear Ratio";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.IndianRed;
            this.ResetButton.Location = new System.Drawing.Point(146, 180);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Instructions: fill out the fields then click calculate. ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputNewRatio);
            this.Controls.Add(this.inputRatio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNewSize);
            this.Controls.Add(this.inputOriginalSize);
            this.Name = "Form1";
            this.Text = "GearSharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputOriginalSize;
        private System.Windows.Forms.TextBox inputNewSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputRatio;
        private System.Windows.Forms.TextBox outputNewRatio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label5;
    }
}


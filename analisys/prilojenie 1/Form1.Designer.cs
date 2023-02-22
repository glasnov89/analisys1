namespace prilojenie_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stoinostiTB = new System.Windows.Forms.TextBox();
            this.resultlbl = new System.Windows.Forms.Label();
            this.ON = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter numbers for analysis :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(603, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Analisys";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stoinostiTB
            // 
            this.stoinostiTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoinostiTB.Location = new System.Drawing.Point(455, 28);
            this.stoinostiTB.Multiline = true;
            this.stoinostiTB.Name = "stoinostiTB";
            this.stoinostiTB.Size = new System.Drawing.Size(180, 57);
            this.stoinostiTB.TabIndex = 2;
            this.stoinostiTB.TextChanged += new System.EventHandler(this.StoinostiTB_TextChanged);
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultlbl.Location = new System.Drawing.Point(41, 325);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(110, 33);
            this.resultlbl.TabIndex = 3;
            this.resultlbl.Text = "Result:";
            this.resultlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // ON
            // 
            this.ON.AutoSize = true;
            this.ON.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ON.Location = new System.Drawing.Point(248, 90);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(47, 20);
            this.ON.TabIndex = 5;
            this.ON.TabStop = true;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.stoinostiTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox stoinostiTB;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.RadioButton ON;
    }
}


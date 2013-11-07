namespace GSM
{
    partial class Main
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.lblVraag = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblWeergave = new System.Windows.Forms.Label();
            this.btnHoeveel = new System.Windows.Forms.Button();
            this.btnVraag = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEinde = new System.Windows.Forms.Button();
            this.txtHoeveel = new System.Windows.Forms.TextBox();
            this.txtVraag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(13, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(428, 18);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Enquête: Is het gsm-gebruik in de leslokalen toegestaan";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantal.Location = new System.Drawing.Point(13, 44);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(362, 17);
            this.lblAantal.TabIndex = 1;
            this.lblAantal.Text = "Aantal personen die zullen deelnemen aan de enquête: ";
            // 
            // lblVraag
            // 
            this.lblVraag.AutoSize = true;
            this.lblVraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVraag.Location = new System.Drawing.Point(12, 93);
            this.lblVraag.Name = "lblVraag";
            this.lblVraag.Size = new System.Drawing.Size(309, 34);
            this.lblVraag.TabIndex = 2;
            this.lblVraag.Text = "Is het gsm-gebruik toegestaan in de leslokalen\r\n(antwoord=j/J(ja), n/N(nee), o/O " +
    "(onverschillig)?";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(384, 119);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(166, 68);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Elk ander teken stopt de \r\nbevraging en geeft de \r\nresultaten weer. Bij het \r\nber" +
    "eiken van het totaal";
            // 
            // lblWeergave
            // 
            this.lblWeergave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeergave.Location = new System.Drawing.Point(12, 219);
            this.lblWeergave.Name = "lblWeergave";
            this.lblWeergave.Size = new System.Drawing.Size(531, 82);
            this.lblWeergave.TabIndex = 4;
            // 
            // btnHoeveel
            // 
            this.btnHoeveel.Location = new System.Drawing.Point(468, 44);
            this.btnHoeveel.Name = "btnHoeveel";
            this.btnHoeveel.Size = new System.Drawing.Size(75, 23);
            this.btnHoeveel.TabIndex = 5;
            this.btnHoeveel.Text = "OK";
            this.btnHoeveel.UseVisualStyleBackColor = true;
            this.btnHoeveel.Click += new System.EventHandler(this.btnHoeveel_Click);
            // 
            // btnVraag
            // 
            this.btnVraag.Enabled = false;
            this.btnVraag.Location = new System.Drawing.Point(468, 93);
            this.btnVraag.Name = "btnVraag";
            this.btnVraag.Size = new System.Drawing.Size(75, 23);
            this.btnVraag.TabIndex = 6;
            this.btnVraag.Text = "OK";
            this.btnVraag.UseVisualStyleBackColor = true;
            this.btnVraag.Click += new System.EventHandler(this.btnVraag_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(387, 310);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEinde
            // 
            this.btnEinde.Location = new System.Drawing.Point(468, 310);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(75, 23);
            this.btnEinde.TabIndex = 8;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = true;
            this.btnEinde.Click += new System.EventHandler(this.btnEinde_Click);
            // 
            // txtHoeveel
            // 
            this.txtHoeveel.Location = new System.Drawing.Point(381, 44);
            this.txtHoeveel.Name = "txtHoeveel";
            this.txtHoeveel.Size = new System.Drawing.Size(46, 20);
            this.txtHoeveel.TabIndex = 9;
            // 
            // txtVraag
            // 
            this.txtVraag.Enabled = false;
            this.txtVraag.Location = new System.Drawing.Point(381, 93);
            this.txtVraag.Name = "txtVraag";
            this.txtVraag.Size = new System.Drawing.Size(46, 20);
            this.txtVraag.TabIndex = 10;
            // 
            // Main
            // 
            this.AcceptButton = this.btnHoeveel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 344);
            this.Controls.Add(this.txtVraag);
            this.Controls.Add(this.txtHoeveel);
            this.Controls.Add(this.btnEinde);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnVraag);
            this.Controls.Add(this.btnHoeveel);
            this.Controls.Add(this.lblWeergave);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblVraag);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.lblTitel);
            this.Name = "Main";
            this.Text = "gsm gebruik";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Label lblVraag;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblWeergave;
        private System.Windows.Forms.Button btnHoeveel;
        private System.Windows.Forms.Button btnVraag;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.TextBox txtHoeveel;
        private System.Windows.Forms.TextBox txtVraag;
    }
}


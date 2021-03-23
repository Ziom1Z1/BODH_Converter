namespace Converter
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBIn = new System.Windows.Forms.TextBox();
            this.tBOut = new System.Windows.Forms.TextBox();
            this.BConvert = new System.Windows.Forms.Button();
            this.rBIDec = new System.Windows.Forms.RadioButton();
            this.rBIBin = new System.Windows.Forms.RadioButton();
            this.rBODec = new System.Windows.Forms.RadioButton();
            this.rBOBin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBIOct = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBOOct = new System.Windows.Forms.RadioButton();
            this.rBIHex = new System.Windows.Forms.RadioButton();
            this.rBOHex = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBIn
            // 
            this.tBIn.Location = new System.Drawing.Point(12, 131);
            this.tBIn.Name = "tBIn";
            this.tBIn.Size = new System.Drawing.Size(100, 20);
            this.tBIn.TabIndex = 0;
            // 
            // tBOut
            // 
            this.tBOut.Location = new System.Drawing.Point(136, 131);
            this.tBOut.Name = "tBOut";
            this.tBOut.ReadOnly = true;
            this.tBOut.Size = new System.Drawing.Size(100, 20);
            this.tBOut.TabIndex = 1;
            // 
            // BConvert
            // 
            this.BConvert.Location = new System.Drawing.Point(12, 157);
            this.BConvert.Name = "BConvert";
            this.BConvert.Size = new System.Drawing.Size(224, 23);
            this.BConvert.TabIndex = 2;
            this.BConvert.Text = "Change";
            this.BConvert.UseVisualStyleBackColor = true;
            this.BConvert.Click += new System.EventHandler(this.BConvert_Click);
            // 
            // rBIDec
            // 
            this.rBIDec.AutoSize = true;
            this.rBIDec.Checked = true;
            this.rBIDec.Location = new System.Drawing.Point(6, 19);
            this.rBIDec.Name = "rBIDec";
            this.rBIDec.Size = new System.Drawing.Size(47, 17);
            this.rBIDec.TabIndex = 3;
            this.rBIDec.TabStop = true;
            this.rBIDec.Text = "DEC";
            this.rBIDec.UseVisualStyleBackColor = true;
            // 
            // rBIBin
            // 
            this.rBIBin.AutoSize = true;
            this.rBIBin.Location = new System.Drawing.Point(6, 42);
            this.rBIBin.Name = "rBIBin";
            this.rBIBin.Size = new System.Drawing.Size(43, 17);
            this.rBIBin.TabIndex = 4;
            this.rBIBin.TabStop = true;
            this.rBIBin.Text = "BIN";
            this.rBIBin.UseVisualStyleBackColor = true;
            // 
            // rBODec
            // 
            this.rBODec.AutoSize = true;
            this.rBODec.Location = new System.Drawing.Point(6, 19);
            this.rBODec.Name = "rBODec";
            this.rBODec.Size = new System.Drawing.Size(47, 17);
            this.rBODec.TabIndex = 5;
            this.rBODec.TabStop = true;
            this.rBODec.Text = "DEC";
            this.rBODec.UseVisualStyleBackColor = true;
            // 
            // rBOBin
            // 
            this.rBOBin.AutoSize = true;
            this.rBOBin.Checked = true;
            this.rBOBin.Location = new System.Drawing.Point(6, 42);
            this.rBOBin.Name = "rBOBin";
            this.rBOBin.Size = new System.Drawing.Size(43, 17);
            this.rBOBin.TabIndex = 6;
            this.rBOBin.TabStop = true;
            this.rBOBin.Text = "BIN";
            this.rBOBin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBIHex);
            this.groupBox1.Controls.Add(this.rBIOct);
            this.groupBox1.Controls.Add(this.rBIDec);
            this.groupBox1.Controls.Add(this.rBIBin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IN";
            // 
            // rBIOct
            // 
            this.rBIOct.AutoSize = true;
            this.rBIOct.Location = new System.Drawing.Point(7, 66);
            this.rBIOct.Name = "rBIOct";
            this.rBIOct.Size = new System.Drawing.Size(47, 17);
            this.rBIOct.TabIndex = 5;
            this.rBIOct.TabStop = true;
            this.rBIOct.Text = "OCT";
            this.rBIOct.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBOHex);
            this.groupBox2.Controls.Add(this.rBOOct);
            this.groupBox2.Controls.Add(this.rBODec);
            this.groupBox2.Controls.Add(this.rBOBin);
            this.groupBox2.Location = new System.Drawing.Point(136, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 113);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUT";
            // 
            // rBOOct
            // 
            this.rBOOct.AutoSize = true;
            this.rBOOct.Location = new System.Drawing.Point(7, 66);
            this.rBOOct.Name = "rBOOct";
            this.rBOOct.Size = new System.Drawing.Size(47, 17);
            this.rBOOct.TabIndex = 7;
            this.rBOOct.TabStop = true;
            this.rBOOct.Text = "OCT";
            this.rBOOct.UseVisualStyleBackColor = true;
            // 
            // rBIHex
            // 
            this.rBIHex.AutoSize = true;
            this.rBIHex.Location = new System.Drawing.Point(6, 89);
            this.rBIHex.Name = "rBIHex";
            this.rBIHex.Size = new System.Drawing.Size(47, 17);
            this.rBIHex.TabIndex = 9;
            this.rBIHex.TabStop = true;
            this.rBIHex.Text = "HEX";
            this.rBIHex.UseVisualStyleBackColor = true;
            // 
            // rBOHex
            // 
            this.rBOHex.AutoSize = true;
            this.rBOHex.Location = new System.Drawing.Point(6, 89);
            this.rBOHex.Name = "rBOHex";
            this.rBOHex.Size = new System.Drawing.Size(47, 17);
            this.rBOHex.TabIndex = 8;
            this.rBOHex.TabStop = true;
            this.rBOHex.Text = "HEX";
            this.rBOHex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 191);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BConvert);
            this.Controls.Add(this.tBOut);
            this.Controls.Add(this.tBIn);
            this.Name = "Form1";
            this.Text = "Conver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBIn;
        private System.Windows.Forms.TextBox tBOut;
        private System.Windows.Forms.Button BConvert;
        private System.Windows.Forms.RadioButton rBIDec;
        private System.Windows.Forms.RadioButton rBIBin;
        private System.Windows.Forms.RadioButton rBODec;
        private System.Windows.Forms.RadioButton rBOBin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBIOct;
        private System.Windows.Forms.RadioButton rBOOct;
        private System.Windows.Forms.RadioButton rBIHex;
        private System.Windows.Forms.RadioButton rBOHex;
    }
}


namespace ConversorDeTemperatura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            vsbTemp = new VScrollBar();
            label1 = new Label();
            label2 = new Label();
            lblTempF = new Label();
            lblTempC = new Label();
            SuspendLayout();
            // 
            // vsbTemp
            // 
            vsbTemp.Location = new Point(317, 75);
            vsbTemp.Minimum = -80;
            vsbTemp.Name = "vsbTemp";
            vsbTemp.Size = new Size(26, 353);
            vsbTemp.TabIndex = 0;
            vsbTemp.Scroll += vsbTemp_Scroll;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 75);
            label1.Name = "label1";
            label1.Size = new Size(209, 52);
            label1.TabIndex = 1;
            label1.Text = "Fahrenheint";
            // 
            // label2
            // 
            label2.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(430, 75);
            label2.Name = "label2";
            label2.Size = new Size(209, 52);
            label2.TabIndex = 2;
            label2.Text = "Celsius";
            // 
            // lblTempF
            // 
            lblTempF.BackColor = SystemColors.ActiveCaption;
            lblTempF.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTempF.Location = new Point(112, 127);
            lblTempF.Name = "lblTempF";
            lblTempF.Size = new Size(79, 52);
            lblTempF.TabIndex = 3;
            lblTempF.Text = "32";
            lblTempF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTempC
            // 
            lblTempC.BackColor = SystemColors.ActiveCaption;
            lblTempC.Font = new Font("Poppins Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTempC.Location = new Point(430, 127);
            lblTempC.Name = "lblTempC";
            lblTempC.Size = new Size(79, 52);
            lblTempC.TabIndex = 4;
            lblTempC.Text = "0";
            lblTempC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 502);
            Controls.Add(lblTempC);
            Controls.Add(lblTempF);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(vsbTemp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private VScrollBar vsbTemp;
        private Label label1;
        private Label label2;
        private Label lblTempF;
        private Label lblTempC;
    }
}

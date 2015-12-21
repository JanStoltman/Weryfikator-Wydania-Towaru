namespace Etykiety_Epl
{
    partial class AskBox
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
            this.Ile_Bx = new System.Windows.Forms.TextBox();
            this.Ok_Bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ile etykiet wydrukować? ";
            // 
            // Ile_Bx
            // 
            this.Ile_Bx.Location = new System.Drawing.Point(91, 97);
            this.Ile_Bx.Name = "Ile_Bx";
            this.Ile_Bx.Size = new System.Drawing.Size(100, 20);
            this.Ile_Bx.TabIndex = 1;
            this.Ile_Bx.Text = "0";
            this.Ile_Bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Ok_Bt
            // 
            this.Ok_Bt.Location = new System.Drawing.Point(106, 123);
            this.Ok_Bt.Name = "Ok_Bt";
            this.Ok_Bt.Size = new System.Drawing.Size(75, 32);
            this.Ok_Bt.TabIndex = 2;
            this.Ok_Bt.Text = "Ok";
            this.Ok_Bt.UseVisualStyleBackColor = true;
            this.Ok_Bt.Click += new System.EventHandler(this.Ok_Bt_Click);
            // 
            // AskBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Ok_Bt);
            this.Controls.Add(this.Ile_Bx);
            this.Controls.Add(this.label1);
            this.Name = "AskBox";
            this.Text = "Dodrukuj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ile_Bx;
        private System.Windows.Forms.Button Ok_Bt;
    }
}
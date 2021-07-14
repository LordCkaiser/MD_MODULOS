
namespace MD_MODULOS
{
    partial class frmcrearcaja
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
            this.lblcrearcaja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcrearcaja
            // 
            this.lblcrearcaja.AutoSize = true;
            this.lblcrearcaja.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblcrearcaja.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrearcaja.Location = new System.Drawing.Point(74, 204);
            this.lblcrearcaja.Name = "lblcrearcaja";
            this.lblcrearcaja.Size = new System.Drawing.Size(572, 42);
            this.lblcrearcaja.TabIndex = 1;
            this.lblcrearcaja.Text = "Estas en el frmCrear Caja";
            this.lblcrearcaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmcrearcaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcrearcaja);
            this.Name = "frmcrearcaja";
            this.Text = "frmcrearcaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcrearcaja;
    }
}
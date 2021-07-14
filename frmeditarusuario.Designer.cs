
namespace MD_MODULOS
{
    partial class frmeditarusuario
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
            this.lbleditar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbleditar
            // 
            this.lbleditar.AutoSize = true;
            this.lbleditar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbleditar.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditar.Location = new System.Drawing.Point(74, 204);
            this.lbleditar.Name = "lbleditar";
            this.lbleditar.Size = new System.Drawing.Size(666, 42);
            this.lbleditar.TabIndex = 1;
            this.lbleditar.Text = "Estas en el frmEditar Uusario";
            this.lbleditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmeditarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbleditar);
            this.Name = "frmeditarusuario";
            this.Text = "Editar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbleditar;
    }
}
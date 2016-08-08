namespace Presentacion
{
    partial class frmPaginaPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(813, 165);
            this.label2.TabIndex = 0;
            this.label2.Text = "Haz Iniciado Sesion Correctamente\r\n\r\n              Bienvenido";
            // 
            // frmPaginaPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(847, 364);
            this.Controls.Add(this.label2);
            this.Name = "frmPaginaPrincipal";
            this.Text = "Pagina Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Login_1DataSet login_1DataSet;
        private System.Windows.Forms.BindingSource login1DataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
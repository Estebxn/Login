namespace Presentacion
{
    partial class Diagnostico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnostico));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdDiagnostico = new System.Windows.Forms.TextBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.rtbDiagnostico = new System.Windows.Forms.RichTextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.btnGererarDiagnostico = new System.Windows.Forms.Button();
            this.btnEditarDiagnostico = new System.Windows.Forms.Button();
            this.btnEliminarDiagnostico = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Diagnostico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Daignostico";
            // 
            // txtIdDiagnostico
            // 
            this.txtIdDiagnostico.Location = new System.Drawing.Point(198, 128);
            this.txtIdDiagnostico.Name = "txtIdDiagnostico";
            this.txtIdDiagnostico.Size = new System.Drawing.Size(100, 20);
            this.txtIdDiagnostico.TabIndex = 4;
            this.txtIdDiagnostico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdDiagnostico_KeyPress);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(198, 186);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtIdPaciente.TabIndex = 6;
            this.txtIdPaciente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtIdPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPaciente_KeyPress);
            // 
            // rtbDiagnostico
            // 
            this.rtbDiagnostico.Location = new System.Drawing.Point(198, 252);
            this.rtbDiagnostico.Name = "rtbDiagnostico";
            this.rtbDiagnostico.Size = new System.Drawing.Size(342, 144);
            this.rtbDiagnostico.TabIndex = 7;
            this.rtbDiagnostico.Text = "";
            this.rtbDiagnostico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbDiagnostico_KeyPress);
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.Location = new System.Drawing.Point(12, 30);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(576, 55);
            this.lblDiagnostico.TabIndex = 8;
            this.lblDiagnostico.Text = "Diagnostico del Paciente";
            // 
            // btnGererarDiagnostico
            // 
            this.btnGererarDiagnostico.Location = new System.Drawing.Point(46, 458);
            this.btnGererarDiagnostico.Name = "btnGererarDiagnostico";
            this.btnGererarDiagnostico.Size = new System.Drawing.Size(114, 23);
            this.btnGererarDiagnostico.TabIndex = 9;
            this.btnGererarDiagnostico.Text = "Generar &Diagnostico";
            this.btnGererarDiagnostico.UseVisualStyleBackColor = true;
            this.btnGererarDiagnostico.Click += new System.EventHandler(this.btnGererarDiagnostico_Click);
            // 
            // btnEditarDiagnostico
            // 
            this.btnEditarDiagnostico.Location = new System.Drawing.Point(198, 458);
            this.btnEditarDiagnostico.Name = "btnEditarDiagnostico";
            this.btnEditarDiagnostico.Size = new System.Drawing.Size(117, 23);
            this.btnEditarDiagnostico.TabIndex = 10;
            this.btnEditarDiagnostico.Text = "Editar &Diagnostico";
            this.btnEditarDiagnostico.UseVisualStyleBackColor = true;
            this.btnEditarDiagnostico.Click += new System.EventHandler(this.btnEditarDiagnostico_Click);
            // 
            // btnEliminarDiagnostico
            // 
            this.btnEliminarDiagnostico.Location = new System.Drawing.Point(352, 458);
            this.btnEliminarDiagnostico.Name = "btnEliminarDiagnostico";
            this.btnEliminarDiagnostico.Size = new System.Drawing.Size(114, 23);
            this.btnEliminarDiagnostico.TabIndex = 11;
            this.btnEliminarDiagnostico.Text = "Eliminar &Diagnostico";
            this.btnEliminarDiagnostico.UseVisualStyleBackColor = true;
            this.btnEliminarDiagnostico.Click += new System.EventHandler(this.btnEliminarDiagnostico_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(504, 458);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 508);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarDiagnostico);
            this.Controls.Add(this.btnEditarDiagnostico);
            this.Controls.Add(this.btnGererarDiagnostico);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.rtbDiagnostico);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtIdDiagnostico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Diagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnostico";
            this.Load += new System.EventHandler(this.Diagnostico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdDiagnostico;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.RichTextBox rtbDiagnostico;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Button btnGererarDiagnostico;
        private System.Windows.Forms.Button btnEditarDiagnostico;
        private System.Windows.Forms.Button btnEliminarDiagnostico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
namespace Presentacion
{
    partial class Asignar_Citas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.btnPedirCita = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarDatos = new System.Windows.Forms.Button();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.btnModicarCita = new System.Windows.Forms.Button();
            this.lblHoraCita = new System.Windows.Forms.Label();
            this.cbxHoraCita = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Solicitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Cita";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(172, 65);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtIdPaciente.TabIndex = 4;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(172, 122);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmpleado.TabIndex = 5;
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(172, 180);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSolicitud.TabIndex = 6;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(172, 230);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCita.TabIndex = 7;
            // 
            // btnPedirCita
            // 
            this.btnPedirCita.Location = new System.Drawing.Point(80, 357);
            this.btnPedirCita.Name = "btnPedirCita";
            this.btnPedirCita.Size = new System.Drawing.Size(75, 23);
            this.btnPedirCita.TabIndex = 8;
            this.btnPedirCita.Text = "&Pedir Cita";
            this.btnPedirCita.UseVisualStyleBackColor = true;
            this.btnPedirCita.Click += new System.EventHandler(this.btnPedirCita_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(387, 357);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditarDatos
            // 
            this.btnEditarDatos.Location = new System.Drawing.Point(448, 55);
            this.btnEditarDatos.Name = "btnEditarDatos";
            this.btnEditarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnEditarDatos.TabIndex = 10;
            this.btnEditarDatos.Text = "Editar Datos";
            this.btnEditarDatos.UseVisualStyleBackColor = true;
            this.btnEditarDatos.Click += new System.EventHandler(this.btnEditarDatos_Click);
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.Location = new System.Drawing.Point(273, 357);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(99, 23);
            this.btnCancelarCita.TabIndex = 11;
            this.btnCancelarCita.Text = "&Cancelar Cita";
            this.btnCancelarCita.UseVisualStyleBackColor = true;
            this.btnCancelarCita.Click += new System.EventHandler(this.btnCancelarCita_Click);
            // 
            // btnModicarCita
            // 
            this.btnModicarCita.Location = new System.Drawing.Point(172, 357);
            this.btnModicarCita.Name = "btnModicarCita";
            this.btnModicarCita.Size = new System.Drawing.Size(89, 23);
            this.btnModicarCita.TabIndex = 12;
            this.btnModicarCita.Text = "&Modificar Cita";
            this.btnModicarCita.UseVisualStyleBackColor = true;
            // 
            // lblHoraCita
            // 
            this.lblHoraCita.AutoSize = true;
            this.lblHoraCita.Location = new System.Drawing.Point(99, 291);
            this.lblHoraCita.Name = "lblHoraCita";
            this.lblHoraCita.Size = new System.Drawing.Size(51, 13);
            this.lblHoraCita.TabIndex = 13;
            this.lblHoraCita.Text = "Hora Cita";
            // 
            // cbxHoraCita
            // 
            this.cbxHoraCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHoraCita.FormattingEnabled = true;
            this.cbxHoraCita.Items.AddRange(new object[] {
            "0:00",
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbxHoraCita.Location = new System.Drawing.Point(172, 283);
            this.cbxHoraCita.Name = "cbxHoraCita";
            this.cbxHoraCita.Size = new System.Drawing.Size(121, 21);
            this.cbxHoraCita.TabIndex = 14;
            // 
            // Asignar_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 459);
            this.Controls.Add(this.cbxHoraCita);
            this.Controls.Add(this.lblHoraCita);
            this.Controls.Add(this.btnModicarCita);
            this.Controls.Add(this.btnCancelarCita);
            this.Controls.Add(this.btnEditarDatos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPedirCita);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.dtpFechaSolicitud);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Asignar_Citas";
            this.Text = "Asignar_Citas";
            this.Load += new System.EventHandler(this.Asignar_Citas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Button btnPedirCita;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarDatos;
        private System.Windows.Forms.Button btnCancelarCita;
        private System.Windows.Forms.Button btnModicarCita;
        private System.Windows.Forms.Label lblHoraCita;
        private System.Windows.Forms.ComboBox cbxHoraCita;
    }
}
namespace Relógio
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
            this.components = new System.ComponentModel.Container();
            this.labHoras = new System.Windows.Forms.Label();
            this.labMinutos = new System.Windows.Forms.Label();
            this.labSegundos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAjustar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnMenosHotas = new System.Windows.Forms.Button();
            this.btnMaisHoras = new System.Windows.Forms.Button();
            this.btnMaisMinutos = new System.Windows.Forms.Button();
            this.btnMenosMinutos = new System.Windows.Forms.Button();
            this.btnMaisSegundos = new System.Windows.Forms.Button();
            this.btnMenosSegundos = new System.Windows.Forms.Button();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labHoras
            // 
            this.labHoras.AutoSize = true;
            this.labHoras.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labHoras.Location = new System.Drawing.Point(79, 81);
            this.labHoras.Name = "labHoras";
            this.labHoras.Size = new System.Drawing.Size(137, 112);
            this.labHoras.TabIndex = 0;
            this.labHoras.Text = "00";
            // 
            // labMinutos
            // 
            this.labMinutos.AutoSize = true;
            this.labMinutos.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labMinutos.Location = new System.Drawing.Point(293, 81);
            this.labMinutos.Name = "labMinutos";
            this.labMinutos.Size = new System.Drawing.Size(137, 112);
            this.labMinutos.TabIndex = 1;
            this.labMinutos.Text = "00";
            // 
            // labSegundos
            // 
            this.labSegundos.AutoSize = true;
            this.labSegundos.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labSegundos.Location = new System.Drawing.Point(489, 81);
            this.labSegundos.Name = "labSegundos";
            this.labSegundos.Size = new System.Drawing.Size(137, 112);
            this.labSegundos.TabIndex = 2;
            this.labSegundos.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(222, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 112);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(427, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 112);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // btnAjustar
            // 
            this.btnAjustar.Location = new System.Drawing.Point(308, 282);
            this.btnAjustar.Name = "btnAjustar";
            this.btnAjustar.Size = new System.Drawing.Size(103, 29);
            this.btnAjustar.TabIndex = 5;
            this.btnAjustar.Text = "AJUSTAR";
            this.btnAjustar.UseVisualStyleBackColor = true;
            this.btnAjustar.Click += new System.EventHandler(this.btnAjustar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(308, 339);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(103, 29);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnMenosHotas
            // 
            this.btnMenosHotas.Location = new System.Drawing.Point(103, 183);
            this.btnMenosHotas.Name = "btnMenosHotas";
            this.btnMenosHotas.Size = new System.Drawing.Size(32, 29);
            this.btnMenosHotas.TabIndex = 9;
            this.btnMenosHotas.Text = "-";
            this.btnMenosHotas.UseVisualStyleBackColor = true;
            this.btnMenosHotas.Visible = false;
            this.btnMenosHotas.Click += new System.EventHandler(this.btnMenosHotas_Click);
            // 
            // btnMaisHoras
            // 
            this.btnMaisHoras.Location = new System.Drawing.Point(149, 183);
            this.btnMaisHoras.Name = "btnMaisHoras";
            this.btnMaisHoras.Size = new System.Drawing.Size(32, 29);
            this.btnMaisHoras.TabIndex = 10;
            this.btnMaisHoras.Text = "+";
            this.btnMaisHoras.UseVisualStyleBackColor = true;
            this.btnMaisHoras.Visible = false;
            this.btnMaisHoras.Click += new System.EventHandler(this.btnMaisHoras_Click);
            // 
            // btnMaisMinutos
            // 
            this.btnMaisMinutos.Location = new System.Drawing.Point(363, 183);
            this.btnMaisMinutos.Name = "btnMaisMinutos";
            this.btnMaisMinutos.Size = new System.Drawing.Size(32, 29);
            this.btnMaisMinutos.TabIndex = 12;
            this.btnMaisMinutos.Text = "+";
            this.btnMaisMinutos.UseVisualStyleBackColor = true;
            this.btnMaisMinutos.Visible = false;
            this.btnMaisMinutos.Click += new System.EventHandler(this.btnMaisMinutos_Click);
            // 
            // btnMenosMinutos
            // 
            this.btnMenosMinutos.Location = new System.Drawing.Point(317, 183);
            this.btnMenosMinutos.Name = "btnMenosMinutos";
            this.btnMenosMinutos.Size = new System.Drawing.Size(32, 29);
            this.btnMenosMinutos.TabIndex = 11;
            this.btnMenosMinutos.Text = "-";
            this.btnMenosMinutos.UseVisualStyleBackColor = true;
            this.btnMenosMinutos.Visible = false;
            this.btnMenosMinutos.Click += new System.EventHandler(this.btnMenosMinutos_Click);
            // 
            // btnMaisSegundos
            // 
            this.btnMaisSegundos.Location = new System.Drawing.Point(560, 183);
            this.btnMaisSegundos.Name = "btnMaisSegundos";
            this.btnMaisSegundos.Size = new System.Drawing.Size(32, 29);
            this.btnMaisSegundos.TabIndex = 14;
            this.btnMaisSegundos.Text = "+";
            this.btnMaisSegundos.UseVisualStyleBackColor = true;
            this.btnMaisSegundos.Visible = false;
            this.btnMaisSegundos.Click += new System.EventHandler(this.btnMaisSegundos_Click);
            // 
            // btnMenosSegundos
            // 
            this.btnMenosSegundos.Location = new System.Drawing.Point(514, 183);
            this.btnMenosSegundos.Name = "btnMenosSegundos";
            this.btnMenosSegundos.Size = new System.Drawing.Size(32, 29);
            this.btnMenosSegundos.TabIndex = 13;
            this.btnMenosSegundos.Text = "-";
            this.btnMenosSegundos.UseVisualStyleBackColor = true;
            this.btnMenosSegundos.Visible = false;
            this.btnMenosSegundos.Click += new System.EventHandler(this.btnMenosSegundos_Click);
            // 
            // timerRelogio
            // 
            this.timerRelogio.Enabled = true;
            this.timerRelogio.Interval = 1000;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 414);
            this.Controls.Add(this.btnMaisSegundos);
            this.Controls.Add(this.btnMenosSegundos);
            this.Controls.Add(this.btnMaisMinutos);
            this.Controls.Add(this.btnMenosMinutos);
            this.Controls.Add(this.btnMaisHoras);
            this.Controls.Add(this.btnMenosHotas);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAjustar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labSegundos);
            this.Controls.Add(this.labMinutos);
            this.Controls.Add(this.labHoras);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relógio Digital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labHoras;
        private Label labMinutos;
        private Label labSegundos;
        private Label label4;
        private Label label5;
        private Button btnAjustar;
        private Button btnOk;
        private Button btnMenosHotas;
        private Button btnMaisHoras;
        private Button btnMaisMinutos;
        private Button btnMenosMinutos;
        private Button btnMaisSegundos;
        private Button btnMenosSegundos;
        private System.Windows.Forms.Timer timerRelogio;
    }
}
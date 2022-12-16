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
            this.labelPomoHoras = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPomoMinutos = new System.Windows.Forms.Label();
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.btnOkPomo = new System.Windows.Forms.Button();
            this.btnPomoMaisMinutos = new System.Windows.Forms.Button();
            this.btnPomoMenosMinutos = new System.Windows.Forms.Button();
            this.btnPomoMaisHoras = new System.Windows.Forms.Button();
            this.btnPomoMenosHoras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labHoras
            // 
            this.labHoras.AutoSize = true;
            this.labHoras.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labHoras.Location = new System.Drawing.Point(79, 31);
            this.labHoras.Name = "labHoras";
            this.labHoras.Size = new System.Drawing.Size(137, 112);
            this.labHoras.TabIndex = 0;
            this.labHoras.Text = "00";
            // 
            // labMinutos
            // 
            this.labMinutos.AutoSize = true;
            this.labMinutos.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labMinutos.Location = new System.Drawing.Point(293, 31);
            this.labMinutos.Name = "labMinutos";
            this.labMinutos.Size = new System.Drawing.Size(137, 112);
            this.labMinutos.TabIndex = 1;
            this.labMinutos.Text = "00";
            // 
            // labSegundos
            // 
            this.labSegundos.AutoSize = true;
            this.labSegundos.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labSegundos.Location = new System.Drawing.Point(489, 31);
            this.labSegundos.Name = "labSegundos";
            this.labSegundos.Size = new System.Drawing.Size(137, 112);
            this.labSegundos.TabIndex = 2;
            this.labSegundos.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(222, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 112);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(427, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 112);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // btnAjustar
            // 
            this.btnAjustar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAjustar.Location = new System.Drawing.Point(287, 202);
            this.btnAjustar.Name = "btnAjustar";
            this.btnAjustar.Size = new System.Drawing.Size(140, 45);
            this.btnAjustar.TabIndex = 5;
            this.btnAjustar.Text = "AJUSTAR HORA";
            this.btnAjustar.UseVisualStyleBackColor = true;
            this.btnAjustar.Click += new System.EventHandler(this.btnAjustar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOk.Location = new System.Drawing.Point(287, 203);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 43);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnMenosHotas
            // 
            this.btnMenosHotas.Location = new System.Drawing.Point(103, 133);
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
            this.btnMaisHoras.Location = new System.Drawing.Point(149, 133);
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
            this.btnMaisMinutos.Location = new System.Drawing.Point(363, 133);
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
            this.btnMenosMinutos.Location = new System.Drawing.Point(317, 133);
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
            this.btnMaisSegundos.Location = new System.Drawing.Point(560, 133);
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
            this.btnMenosSegundos.Location = new System.Drawing.Point(514, 133);
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
            // labelPomoHoras
            // 
            this.labelPomoHoras.AutoSize = true;
            this.labelPomoHoras.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPomoHoras.Location = new System.Drawing.Point(281, 309);
            this.labelPomoHoras.Name = "labelPomoHoras";
            this.labelPomoHoras.Size = new System.Drawing.Size(71, 57);
            this.labelPomoHoras.TabIndex = 15;
            this.labelPomoHoras.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(344, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 57);
            this.label6.TabIndex = 16;
            this.label6.Text = ":";
            // 
            // labelPomoMinutos
            // 
            this.labelPomoMinutos.AutoSize = true;
            this.labelPomoMinutos.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPomoMinutos.Location = new System.Drawing.Point(365, 309);
            this.labelPomoMinutos.Name = "labelPomoMinutos";
            this.labelPomoMinutos.Size = new System.Drawing.Size(71, 57);
            this.labelPomoMinutos.TabIndex = 17;
            this.labelPomoMinutos.Text = "00";
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPomodoro.Location = new System.Drawing.Point(287, 253);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(140, 45);
            this.btnPomodoro.TabIndex = 18;
            this.btnPomodoro.Text = "POMODORO";
            this.btnPomodoro.UseVisualStyleBackColor = true;
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            // 
            // btnOkPomo
            // 
            this.btnOkPomo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOkPomo.Location = new System.Drawing.Point(287, 254);
            this.btnOkPomo.Name = "btnOkPomo";
            this.btnOkPomo.Size = new System.Drawing.Size(140, 43);
            this.btnOkPomo.TabIndex = 19;
            this.btnOkPomo.Text = "OK";
            this.btnOkPomo.UseVisualStyleBackColor = true;
            this.btnOkPomo.Visible = false;
            this.btnOkPomo.Click += new System.EventHandler(this.btnOkPomo_Click);
            // 
            // btnPomoMaisMinutos
            // 
            this.btnPomoMaisMinutos.Location = new System.Drawing.Point(398, 363);
            this.btnPomoMaisMinutos.Name = "btnPomoMaisMinutos";
            this.btnPomoMaisMinutos.Size = new System.Drawing.Size(32, 29);
            this.btnPomoMaisMinutos.TabIndex = 21;
            this.btnPomoMaisMinutos.Text = "+";
            this.btnPomoMaisMinutos.UseVisualStyleBackColor = true;
            this.btnPomoMaisMinutos.Visible = false;
            this.btnPomoMaisMinutos.Click += new System.EventHandler(this.btnPomoMaisMinutos_Click);
            // 
            // btnPomoMenosMinutos
            // 
            this.btnPomoMenosMinutos.Location = new System.Drawing.Point(367, 363);
            this.btnPomoMenosMinutos.Name = "btnPomoMenosMinutos";
            this.btnPomoMenosMinutos.Size = new System.Drawing.Size(32, 29);
            this.btnPomoMenosMinutos.TabIndex = 20;
            this.btnPomoMenosMinutos.Text = "-";
            this.btnPomoMenosMinutos.UseVisualStyleBackColor = true;
            this.btnPomoMenosMinutos.Visible = false;
            this.btnPomoMenosMinutos.Click += new System.EventHandler(this.btnPomoMenosMinutos_Click);
            // 
            // btnPomoMaisHoras
            // 
            this.btnPomoMaisHoras.Location = new System.Drawing.Point(313, 363);
            this.btnPomoMaisHoras.Name = "btnPomoMaisHoras";
            this.btnPomoMaisHoras.Size = new System.Drawing.Size(32, 29);
            this.btnPomoMaisHoras.TabIndex = 23;
            this.btnPomoMaisHoras.Text = "+";
            this.btnPomoMaisHoras.UseVisualStyleBackColor = true;
            this.btnPomoMaisHoras.Visible = false;
            this.btnPomoMaisHoras.Click += new System.EventHandler(this.btnPomoMaisHoras_Click);
            // 
            // btnPomoMenosHoras
            // 
            this.btnPomoMenosHoras.Location = new System.Drawing.Point(282, 363);
            this.btnPomoMenosHoras.Name = "btnPomoMenosHoras";
            this.btnPomoMenosHoras.Size = new System.Drawing.Size(32, 29);
            this.btnPomoMenosHoras.TabIndex = 22;
            this.btnPomoMenosHoras.Text = "-";
            this.btnPomoMenosHoras.UseVisualStyleBackColor = true;
            this.btnPomoMenosHoras.Visible = false;
            this.btnPomoMenosHoras.Click += new System.EventHandler(this.btnPomoMenosHoras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 414);
            this.Controls.Add(this.btnPomoMaisHoras);
            this.Controls.Add(this.btnPomoMenosHoras);
            this.Controls.Add(this.btnPomoMaisMinutos);
            this.Controls.Add(this.btnPomoMenosMinutos);
            this.Controls.Add(this.btnOkPomo);
            this.Controls.Add(this.btnPomodoro);
            this.Controls.Add(this.labelPomoMinutos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelPomoHoras);
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
        private Label labelPomoHoras;
        private Label label6;
        private Label labelPomoMinutos;
        private Button btnPomodoro;
        private Button btnOkPomo;
        private Button btnPomoMaisMinutos;
        private Button btnPomoMenosMinutos;
        private Button btnPomoMaisHoras;
        private Button btnPomoMenosHoras;
    }
}
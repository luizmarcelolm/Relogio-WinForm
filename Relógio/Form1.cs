using System.Media;

namespace Relógio
{
    public partial class Form1 : Form
    {
        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Segundos { get; set; }
        public int HorasPomo { get; set; }
        public int MinutosPomo { get; set; }
        public Form1()
        {
            InitializeComponent();

             Horas = DateTime.Now.Hour;
             Minutos = DateTime.Now.Minute;
             Segundos = DateTime.Now.Second;
             labHoras.Text = Convert.ToString(Horas);
             labMinutos.Text = Convert.ToString(Minutos);
             labSegundos.Text = Convert.ToString(Segundos);
        }

        private void btnMaisSegundos_Click(object sender, EventArgs e)
        {
            if (Segundos == 59)
            {
                Segundos = 0;
            }
            else
            Segundos++;
            labSegundos.Text = Convert.ToString(Segundos).PadLeft(2, '0');
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
           timerRelogio.Stop();
            btnMaisHoras.Visible = true;
            btnMenosHotas.Visible = true;
            btnMaisMinutos.Visible = true;  
            btnMenosMinutos.Visible = true;
            btnMaisSegundos.Visible = true;
            btnMenosSegundos.Visible = true;
            btnOk.Visible = true;   
        }

        private void btnMenosMinutos_Click(object sender, EventArgs e)
        {
            if (Minutos == 0)
            {
                Minutos = 59;
            }
            else
            Minutos--;
            labMinutos.Text = Convert.ToString(Minutos).PadLeft(2, '0');
        }

        private void btnMenosSegundos_Click(object sender, EventArgs e)
        {
            if (Segundos == 0)
            {
                Segundos = 59;
            }
            else
            Segundos--;
            labSegundos.Text = Convert.ToString(Segundos).PadLeft(2, '0');
        }

        private void btnMaisMinutos_Click(object sender, EventArgs e)
        {
            if (Minutos == 59)
            {
                Minutos = 0;
            }
            else
            Minutos++;
            labMinutos.Text = Convert.ToString(Minutos).PadLeft(2, '0');
        }

        private void btnMaisHoras_Click(object sender, EventArgs e)
        {
            if (Horas == 23)
            {
                Horas = 0;
            }
            else
            Horas++;
            labHoras.Text = Convert.ToString(Horas).PadLeft(2, '0');
        }

        private void btnMenosHotas_Click(object sender, EventArgs e)
        {
            if (Horas == 0)
            {
                Horas = 23;
            }
            else
            Horas--;
            labHoras.Text = Convert.ToString(Horas).PadLeft(2, '0');
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            timerRelogio.Start();
            btnMaisHoras.Visible = false;
            btnMenosHotas.Visible = false;
            btnMaisMinutos.Visible = false;
            btnMenosMinutos.Visible = false;
            btnMaisSegundos.Visible = false;
            btnMenosSegundos.Visible = false;
            btnOk.Visible = false;
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            if (Horas == HorasPomo && Minutos == MinutosPomo)
            {
                timerRelogio.Stop();
                MessageBox.Show("POMODORO CONCLUÍDO!!!");
                HorasPomo = 0;
                MinutosPomo = 0;
                labelPomoHoras.Text = Convert.ToString(HorasPomo).PadLeft(2, '0');
                labelPomoMinutos.Text = Convert.ToString(MinutosPomo).PadLeft(2, '0');
                timerRelogio.Start();
            }
            
            if (Segundos == 59)
            {
                Segundos = 0;
                if (Minutos == 59)
                {
                    Minutos = 0;
                    if (Horas == 23)
                        Horas = 0;
                    else
                        Horas++;
                }  
                else
                    Minutos++;
            }
            else
                Segundos++;

            labSegundos.Text = Convert.ToString(Segundos).PadLeft(2, '0');
            labMinutos.Text = Convert.ToString(Minutos).PadLeft(2, '0');
            labHoras.Text = Convert.ToString(Horas).PadLeft(2, '0');
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            labelPomoHoras.Visible = true;
            labelPomoMinutos.Visible = true;
            label6.Visible = true;
            btnPomoMaisHoras.Visible = true;    
            btnPomoMaisMinutos.Visible = true;
            btnPomoMenosHoras.Visible = true;
            btnPomoMenosMinutos.Visible = true; 
            btnPomodoro.Visible = false;
            btnOkPomo.Visible = true;
        }

        private void btnOkPomo_Click(object sender, EventArgs e)
        {
            btnPomoMaisHoras.Visible = false;
            btnPomoMaisMinutos.Visible = false;
            btnPomoMenosHoras.Visible = false;
            btnPomoMenosMinutos.Visible = false;
            btnOkPomo.Visible = false;
            btnPomodoro.Visible = true;
        }

        private void btnPomoMaisMinutos_Click(object sender, EventArgs e)
        {
            if (MinutosPomo == 59)
            {
                MinutosPomo = 0;
            }else
            MinutosPomo++;
            labelPomoMinutos.Text = Convert.ToString(MinutosPomo).PadLeft(2, '0'); ;
        }

        private void btnPomoMenosMinutos_Click(object sender, EventArgs e)
        {
            if (MinutosPomo == 0)
            {
                MinutosPomo = 59;
            }else
            MinutosPomo--;
            labelPomoMinutos.Text = Convert.ToString(MinutosPomo).PadLeft(2, '0'); 
        }

        private void btnPomoMaisHoras_Click(object sender, EventArgs e)
        {
            if (HorasPomo == 23)
            {
                HorasPomo = 0;
            }else
            HorasPomo++;
            labelPomoHoras.Text = Convert.ToString(HorasPomo).PadLeft(2, '0');
        }

        private void btnPomoMenosHoras_Click(object sender, EventArgs e)
        {
            if (HorasPomo == 0) 
            {
                HorasPomo = 23;
            }else
            HorasPomo--;
            labelPomoHoras.Text = Convert.ToString(HorasPomo).PadLeft(2, '0');
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
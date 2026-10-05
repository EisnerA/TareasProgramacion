namespace ValidacionExpedientes
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource? cts;
        public Form1()
        {
            InitializeComponent();
            btnCancelar.Enabled = false;
        }
        private void PrepararInicio(int total)
        {
            prgProceso.Minimum = 0;
            prgProceso.Maximum = total;
            prgProceso.Value = 0;
            lstResultados.Items.Clear();
            btnIniciar.Enabled = false;
            btnCancelar.Enabled = true;
            nudCantidad.Enabled = false;
            lblEstado.Text = "Iniciando validación...";
            lblPorcentaje.Text = "0 %";
        }

        private void PrepararFin()
        {
            btnIniciar.Enabled = true;
            btnCancelar.Enabled = false;
            nudCantidad.Enabled = true;
        }
        private int ValidarExpedientes(
    int total,
    IProgress<ProgresoExpediente> progreso,
    CancellationToken token)
        {
            int incompletos = 0;
            for (int i = 1; i <= total; i++)
            {
                token.ThrowIfCancellationRequested();

                Thread.Sleep(300);

                token.ThrowIfCancellationRequested();

                string mensaje;
                if (i % 4 == 0)
                {
                    incompletos++;
                    mensaje = $"Expediente {i}: documentación incompleta.";
                }
                else
                {
                    mensaje = $"Expediente {i}: validado correctamente.";
                }

                progreso.Report(new ProgresoExpediente(i, total, mensaje));
            }
            return incompletos;
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {

            int total = (int)nudCantidad.Value;
            PrepararInicio(total);

            var fuente = new CancellationTokenSource();
            cts = fuente;
            CancellationToken token = fuente.Token;
            Progress<ProgresoExpediente> progreso = new(dato =>
            {
                prgProceso.Value = dato.Actual;
                lblEstado.Text = $"Validando {dato.Actual} de {dato.Total}";
                lblPorcentaje.Text = $"{dato.Actual * 100 / dato.Total} %";
                lstResultados.Items.Add(dato.Mensaje);
            });

            try
            {
                int incompletos = await Task.Run(() => ValidarExpedientes(total, progreso, token));
                lblEstado.Text = "Todos los expedientes fueron validados.";
                lstResultados.Items.Add("Proceso finalizado correctamente.");
                lstResultados.Items.Add($"Total de expedientes con documentación incompleta: {incompletos}");
            }
            catch (OperationCanceledException)
            {
                lblEstado.Text = "Validación cancelada.";
                lstResultados.Items.Add("El proceso fue cancelado por el usuario.");
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Ocurrió un error en la validación.";
                lstResultados.Items.Add($"Error: {ex.Message}");
            }
            finally
            {
                cts = null;
                fuente.Dispose();
                PrepararFin();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (cts is null) return;
            btnCancelar.Enabled = false;
            lblEstado.Text = "Cancelando...";
            cts.Cancel();
        }

        public record ProgresoExpediente(int Actual, int Total, string Mensaje);
    }
}

using System.Security.Cryptography;
using System.Text;

namespace GeneradorHash
{
    public partial class fmrGeneradorHash : Form
    {
        public fmrGeneradorHash()
        {
            InitializeComponent();
        }

        private string rutaArchivoSeleccionado = string.Empty;

        private void fmrGeneradorHash_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Seleccionar archivo Txt",
                Filter = "Archivos Txt (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivoSeleccionado = openFileDialog.FileName;
                txtRutaArchivo.Text = rutaArchivoSeleccionado;

                try
                {
                    string hash = CalcularSHA256(rutaArchivoSeleccionado);
                    txtResultado.Text = hash;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al calcular el hash: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private string CalcularSHA256(string rutaArchivo)
        {
            using (FileStream stream = File.OpenRead(rutaArchivo))
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(stream);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
        private void btnGenerarArchivo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(rutaArchivoSeleccionado))
            {
                MessageBox.Show("Por favor, seleccione un archivo primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sha256Hash = txtResultado.Text;
            //string rutaArchivoGenerado = Path.Combine(Path.GetDirectoryName(rutaArchivoSeleccionado), "hash.txt");
            string rutaArchivoHash = Path.ChangeExtension(rutaArchivoSeleccionado, ".sha256");

            string lineaTexto = $"{sha256Hash}  {rutaArchivoSeleccionado}";
            File.WriteAllText(rutaArchivoHash, lineaTexto, Encoding.UTF8);

            MessageBox.Show($"Archivo de hash generado: {rutaArchivoHash}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

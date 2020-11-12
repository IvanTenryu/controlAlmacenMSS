using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ControlAlmacenMSS
{
    public partial class GestionUsuarios : Form
    {        
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        // Cambiar conexión a la ubicación del archivo Sql dependiendo de la PC que se está usando
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0044:Agregar modificador de solo lectura", Justification = "<pendiente>")]
        SqlConnection Con = new SqlConnection(@"");

        private void LabelCerrarGest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void  Rellenar()
        {
            try
            {
                Con.Open();
                string MiConsulta = "select * from GestionUsuarios";
                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(MiConsulta, Con);
                SqlCommandBuilder cmdConstructor = new SqlCommandBuilder(adaptadorDatos);
                var conjuntoDatos = new DataSet();
                adaptadorDatos.Fill(conjuntoDatos);
                DataGridViewGestionUsuarios.DataSource = conjuntoDatos.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private void BtnAgregarGest_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("insert into GestionUsuarios values('"+BunMatTbNombreGest.Text
                    +"','"+BunMatTbUsuarioGest.Text
                    +"','"+BunMatTbContraGest.Text
                    +"','"+BunMatTbMailGest.Text
                    +"','"+BunMatTbTelGest.Text+"')",Con); 
                Cmd.ExecuteNonQuery();
                MessageBox.Show("USUARIO AGREGADO");
                Con.Close();
                Rellenar();
            }
            catch
            {

            }
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            Rellenar();
        }

        private void BtnEditarGest_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("update GestionUsuarios set Nombre='"+BunMatTbNombreGest.Text
                    +"',Usuario='"+BunMatTbUsuarioGest.Text
                    +"',Contraseña='"+BunMatTbContraGest.Text
                    +"',Email='"+BunMatTbMailGest.Text
                    +"' where Teléfono='"+BunMatTbTelGest.Text 
                    +"'", Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("USUARIO ACTUALIZADO");
                Con.Close();
                Rellenar();
            }
            catch
            {

            }
        }

        private void BtnBorrarGest_Click(object sender, EventArgs e)
        {
            if(BunMatTbTelGest.Text == "")
            {
                MessageBox.Show("INGRESA EL NÚMERO DE TELÉFONO DEL USUARIO");
            }
            else
            {
                Con.Open();
                string miConsulta = "delete from GestionUsuarios where Contraseña = '"+BunMatTbTelGest+"';";
                SqlCommand Cmd = new SqlCommand(miConsulta, Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("USUARIO BORRADO");
                Con.Close();
                Rellenar();
            }
        }

        private void DataGridViewGestionUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BunMatTbNombreGest.Text = DataGridViewGestionUsuarios.SelectedRows[0].Cells[0].Value.ToString();
            BunMatTbUsuarioGest.Text = DataGridViewGestionUsuarios.SelectedRows[0].Cells[1].Value.ToString();
            BunMatTbContraGest.Text = DataGridViewGestionUsuarios.SelectedRows[0].Cells[2].Value.ToString();
            BunMatTbMailGest.Text = DataGridViewGestionUsuarios.SelectedRows[0].Cells[3].Value.ToString();
            BunMatTbTelGest.Text = DataGridViewGestionUsuarios.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}

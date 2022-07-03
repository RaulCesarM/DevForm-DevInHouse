using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DevForm {
    public partial class Form2 : Form {

        int id;
        string ConnectionString = "datasource =localhost; username = root;password=Jaraguadosul1234@;database=devinhouse";
        MySqlConnection ConexaoBanco = new MySqlConnection("datasource =localhost; username = root;password=Jaraguadosul1234@;database=devinhouse");

        public Form2() {
            InitializeComponent();
            VIEW.View = View.Details;
            VIEW.AllowColumnReorder = true;
            VIEW.GridLines = true;
            VIEW.Columns.Add("ID", 50, HorizontalAlignment.Left);
            VIEW.Columns.Add("NOME", 120, HorizontalAlignment.Left);
            VIEW.Columns.Add("VALOR", 120, HorizontalAlignment.Left);
            VIEW.Columns.Add("DESCONTO", 120, HorizontalAlignment.Left);
          

        }

        private void button3_Click(object sender, EventArgs e) {

            this.Hide();
            FormularioInscricao cursosForm = new FormularioInscricao();
            cursosForm.Show();

        }

     

        private void SALVAR_click(object sender, EventArgs e) {

            try {
                ConexaoBanco = new MySqlConnection(ConnectionString);
                string sql = "INSERT INTO Curso (Nome, Valor, Desconto )" +
                                        " VALUES ('" + Nome.Text +
                                               "','" + Valor.Text +
                                               "','" + Desconto.Text + "')";
                MySqlCommand MyComand = new MySqlCommand(sql, ConexaoBanco);
                ConexaoBanco.Open();
                MyComand.ExecuteReader();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                ConexaoBanco.Close();
                Nome.Text = "";
                Valor.Text = "";
                Desconto.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e) {

            VIEW.Items.Clear();
            try {
                ConexaoBanco = new MySqlConnection(ConnectionString);
                string sql = "SELECT * FROM Curso";
                ConexaoBanco.Open();
                MySqlCommand MyComand = new MySqlCommand(sql, ConexaoBanco);
                MySqlDataReader dataread = MyComand.ExecuteReader();
                while (dataread.Read()) {
                    string[] linha = {
                        dataread.GetString(0),
                        dataread.GetString(1),
                        dataread.GetString(2),
                        dataread.GetString(3),
                        
                };
                    var listaview = new ListViewItem(linha);
                    VIEW.Items.Add(listaview);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                ConexaoBanco.Close();
            }


        }
    }
}

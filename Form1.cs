using MySql.Data.MySqlClient;
namespace DevForm {
    public partial class FormularioInscricao : Form {
       int id;
       string ConnectionString ="datasource =localhost; username = root;password=Jaraguadosul1234@;database=devinhouse";
        MySqlConnection ConexaoBanco = new MySqlConnection("datasource =localhost; username = root;password=Jaraguadosul1234@;database=devinhouse");

        public FormularioInscricao() {
            InitializeComponent();
            CarregaCombo();
            VIEW.View = View.Details;
            VIEW.AllowColumnReorder = true;
            VIEW.GridLines = true;
           VIEW.Columns.Add("ID", 50, HorizontalAlignment.Left);
           VIEW.Columns.Add("NOME", 120, HorizontalAlignment.Left);
           VIEW.Columns.Add("SOBRENOME", 120, HorizontalAlignment.Left);
            VIEW.Columns.Add("CURSO", 120, HorizontalAlignment.Left);
            VIEW.Columns.Add("IDADE", 80, HorizontalAlignment.Left);
            VIEW.Columns.Add("DATA DE NASCIMENTO", 240, HorizontalAlignment.Left);
        }
        private void BtnSalvar_Click(object sender, EventArgs e) { 
            if(comboBox1.Text == "SELECIONE O CURSO") {
                MessageBox.Show("Selecione um curso");
            } else {
                try {
                    ConexaoBanco = new MySqlConnection(ConnectionString);
                    string sql = "INSERT INTO Aluno (Nome, Sobrenome, Idade, CursosInscrito, Nascimento )" +
                                            " VALUES ('" + Nome.Text +
                                                   "','" + Sobrenome.Text +
                                                   "','" + Idadetxt.Text +
                                                   "','" + comboBox1.Text +
                                                   "','" + dateTimePicker1.Text + "')";
                    MySqlCommand MyComand = new MySqlCommand(sql, ConexaoBanco);
                    ConexaoBanco.Open();
                    MyComand.ExecuteReader();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    ConexaoBanco.Close();
                    Nome.Text = "";
                    Sobrenome.Text = "";
                    Idadetxt.Text = "";
                    textBox1.Text = "";
                    textBox2.Text ="";
                    textBox3.Text = "";
                }

            }
             
        }

        private void BtnBuscar_Click(object sender, EventArgs e) {
            VIEW.Items.Clear();
            try { 
                ConexaoBanco = new MySqlConnection(ConnectionString);
                string sql = "SELECT * FROM Aluno";
                ConexaoBanco.Open();
                MySqlCommand MyComand = new MySqlCommand(sql,ConexaoBanco);               
                MySqlDataReader dataread = MyComand.ExecuteReader(); 
                while (dataread.Read()) {
                    string[] linha = {                        
                        dataread.GetString(0),
                        dataread.GetString(1),
                        dataread.GetString(2),
                        dataread.GetString(3),
                         dataread.GetString(4),
                          dataread.GetString(5),
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
        private void CarregaCombo() {
            
            try {
                ConexaoBanco = new MySqlConnection(ConnectionString);
                string sql = "SELECT IdCurso, Nome FROM Curso";
                ConexaoBanco.Open();
                MySqlCommand MyComand = new MySqlCommand(sql, ConexaoBanco);
                MySqlDataReader dataread = MyComand.ExecuteReader();
                
                while (dataread.Read()) {                   
               
                    string[] linha = {dataread.GetString(1)};
                    var listaview = new ListViewItem(linha);
                   comboBox1.Items.Add(listaview.Text);

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                ConexaoBanco.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e) {
            {
                string Prompt = @"Digite a senha de Administrador! ";
          
                string Titulo = "Dev In Hose";
                string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Prompt,  Titulo,"", 120, 120 ); 
                string password = "1234"; 
                if (Resultado != "") {

                    Resultado = Resultado.TrimStart();
                 
                    if (Resultado != password) {

                        MessageBox.Show("Senha Incorreta.");

                    } else {
                       
                        VIEW.Items.Clear();
                        try {
                            ConexaoBanco = new MySqlConnection(ConnectionString);
                            string sql = "DELETE FROM Aluno WHERE IdAluno > 0";
                            ConexaoBanco.Open();
                            MySqlCommand MyComand = new MySqlCommand(sql, ConexaoBanco);
                            MySqlDataReader dataread = MyComand.ExecuteReader();
                            while (dataread.Read()) {
                                string[] linha = {
                               dataread.GetString(0),
                               dataread.GetString(1),
                                 dataread.GetString(2),
                                dataread.GetString(3),};
                                var listaview = new ListViewItem(linha);
                                VIEW.Items.Add(listaview);
                            }
                        } catch (Exception ex) {
                            MessageBox.Show(ex.Message);

                        } finally {
                            MessageBox.Show("Deletado Com sucesso");
                            ConexaoBanco.Close();
                        }
                    }
                } else {
                    MessageBox.Show("Senha Incorreta.");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e) {
        }
        private void Form1_Load(object sender, EventArgs e) {
        }
      private void button5_Click(object sender, EventArgs e) {
                try {
                    string buscador = "'%" + BuscarTxt.Text + "%'";
                    ConexaoBanco = new MySqlConnection(ConnectionString);
                    string sql = "SELECT * FROM devinhouse.Aluno WHERE Nome LIKE " + buscador;
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
                       IdadeRetorno.Text = linha[3];
                       SobrenomeRetorno.Text = linha[2];
                       NomeRetorno.Text= linha[1];
                       this.id = Convert.ToInt16(linha[0]);                       
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    ConexaoBanco.Close();
                }
            }

        private void Editar_Click(object sender, EventArgs e) {
            try {  
                ConexaoBanco = new MySqlConnection(ConnectionString);
                string sql = $"UPDATE Aluno SET Nome ='{NomeRetorno.Text}', Sobrenome ='{ SobrenomeRetorno.Text}', Idade ='{IdadeRetorno.Text}' WHERE IdAluno ='{this.id}'";
                ConexaoBanco.Open();
                MySqlCommand MyComand = new MySqlCommand(sql, ConexaoBanco);
                MySqlDataReader dataread = MyComand.ExecuteReader();
                    BuscarTxt.Text = "";
                    IdadeRetorno.Text = "";
                    SobrenomeRetorno.Text = "";
                    NomeRetorno.Text ="";
                MessageBox.Show("Editado com sucesso ");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                ConexaoBanco.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                ConexaoBanco = new MySqlConnection(ConnectionString);
                string sql = $"DELETE FROM Aluno WHERE Nome ='{BuscarTxt.Text}'";
                ConexaoBanco.Open();
                MySqlCommand MyComand = new MySqlCommand(sql, ConexaoBanco);
                MySqlDataReader dataread = MyComand.ExecuteReader();
                BuscarTxt.Text = "";
                IdadeRetorno.Text = "";
                SobrenomeRetorno.Text = "";
                NomeRetorno.Text = "";
                MessageBox.Show("Deletado com sucesso ");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                ConexaoBanco.Close();
            }
        }
        private void button6_Click(object sender, EventArgs e) {
            this.Hide();
            Form2 cursosForm = new Form2();
            cursosForm.Show();
        }
        private void LblNome_Click(object sender, EventArgs e) {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void btnBuscar_Click_1(object sender, EventArgs e) {

            try {
                string buscador = "'%" + comboBox1.Text + "%'";
                ConexaoBanco = new MySqlConnection(ConnectionString);
                string sql = "SELECT * FROM devinhouse.Curso WHERE Nome LIKE " + buscador;
                ConexaoBanco.Open();
                MySqlCommand MyComand = new MySqlCommand(sql, ConexaoBanco);
                MySqlDataReader dataread = MyComand.ExecuteReader();
                while (dataread.Read()) {
                    string[] linha = {
                        dataread.GetString(0),//id
                        dataread.GetString(1),//nome
                        dataread.GetString(2),//valor
                        dataread.GetString(3),//desconto
                          };
                    textBox1.Text = linha[2];
                    textBox2.Text = linha[3];
                    
                    int a = Convert.ToInt16(linha[2]);
                    int b = Convert.ToInt16(linha[3]);
                    int total = (a-b);
                    textBox3.Text = Convert.ToString(total);
                    


                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                ConexaoBanco.Close();
            }

        }
    }
    }


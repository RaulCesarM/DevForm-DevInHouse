using MySql.Data.MySqlClient;
using DevForm.Models;


namespace DevForm.Persistence {
    public class ConexaoForm1 {


        private string ConnectionString = "datasource =localhost; username = root;password=Jaraguadosul1234@;database=devinhouse";
        private MySqlConnection ConexaoBanco = new MySqlConnection("datasource =localhost; username = root;password=Jaraguadosul1234@;database=devinhouse");


       

        public void SalvarNoBanco(Aluno aluno) {
            Aluno aluno1 = aluno;
            try {
                ConexaoBanco = new MySqlConnection(ConnectionString);
                string sql = "INSERT INTO Aluno (Nome, Sobrenome, Idade, CursosInscrito, Nascimento )" +
                                        " VALUES ('" + aluno1.Nome +
                                               "','" + aluno1.SobreNome +
                                               "','" + aluno1.Idade +
                                               "','" + aluno1.CursoInscrito +
                                               "','" + aluno1.Nascimento + "')";
                MySqlCommand MyComand = new MySqlCommand(sql, ConexaoBanco);
                ConexaoBanco.Open();
                MyComand.ExecuteReader();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                ConexaoBanco.Close();
            }

        }
        public void DeletarNoBanco() {
        }

        public void AtualizarNoBanco() {

        }

        public void BuscarPorId() {

        }



       
      

    }
}


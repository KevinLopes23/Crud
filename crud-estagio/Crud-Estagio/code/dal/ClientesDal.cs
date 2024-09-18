using Crud_Estagio.code.dto;
using System.Data;
using System.Data.SQLite;
using System.Text;


namespace Crud_Estagio.code.dal
{
    public class ClientesDal
    {
        private string connSqLite = "DATA SOURCE=C:\\Crud-Estagio\\Database\\crud";
        private StringBuilder sql = null;


        public Boolean Salvar(ClientesDto dto)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqLite))
                {
                    conn.Open();

                    sql = new();
                    //sql.Append("INSERT INTO CRUD_ESTAGIO (CODIGO,NOME,DATANASCIMENTO,IDADE,CIDADE,SEXO) VALUES (@CODIGO,@NOME,@DATANASCIMENTO,@IDADE,@CIDADE,@SEXO)");
                    sql.Append("INSERT INTO CRUD_ESTAGIO (CODIGO,NOME,DATANASCIMENTO,IDADE,CIDADE,SEXO,CPF) ");
                    sql.Append(" VALUES ");
                    sql.Append("(@CODIGO,@NOME,@DATANASCIMENTO,@IDADE,@CIDADE,@SEXO,@CPF)");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@CODIGO", dto.Codigo);
                        cmd.Parameters.AddWithValue("@NOME", dto.Nome);
                        cmd.Parameters.AddWithValue("@DATANASCIMENTO", dto.DataNascimento.ToString("dd/MM/yyyy"));
                        cmd.Parameters.AddWithValue("@IDADE", dto.Idade);
                        cmd.Parameters.AddWithValue("@CIDADE", dto.Cidade);
                        cmd.Parameters.AddWithValue("@SEXO", dto.Sexo);
                        cmd.Parameters.AddWithValue("@CPF", dto.Cpf);
                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public Boolean CpfJaCadastrado(string cpf)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqLite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT COUNT(1) FROM CRUD_ESTAGIO WHERE CPF = @CPF");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@CPF", cpf);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }


        }

        public int GeraId()
        {
            try
            {
                int novoId = 0;

                using (SQLiteConnection conn = new SQLiteConnection(connSqLite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT MAX(Codigo) + 1 FROM CRUD_ESTAGIO");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        novoId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                return novoId;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }


        }


        public DataTable PesquisaClientes(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();

                using (SQLiteConnection conn = new SQLiteConnection(connSqLite))
                {
                    conn.Open();

                    StringBuilder sql = new StringBuilder();

                    sql.Append("SELECT CODIGO,NOME, CAST(DATANASCIMENTO AS TEXT) AS DATA , IDADE,CIDADE,SEXO, CPF");
                    sql.Append(" FROM CRUD_ESTAGIO ");
                    sql.Append("WHERE NOME LIKE @NOME");

                    //sql.Append("SELECT CODIGO, NOME, strftime('%d/%m/%Y') , IDADE, CIDADE, SEXO, CPF FROM CRUD_ESTAGIO WHERE NOME LIKE @NOME");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@NOME", "%" + nome + "%");

                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                        da.Fill(tabela);

                        return tabela;
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }




        }

        public ClientesDto DadosCliente(Int32 codigoCliente)
        {
            ClientesDto dto = new();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqLite))
                {
                    conn.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT CODIGO,NOME, CAST(DATANASCIMENTO AS TEXT) AS DATA , IDADE,CIDADE,SEXO, CPF ");
                    sql.Append("FROM CRUD_ESTAGIO ");
                    sql.Append("WHERE CODIGO = @CODIGO");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@CODIGO", codigoCliente);

                        SQLiteDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            dto = new();
                            dto.Codigo = Convert.ToInt32(dr["CODIGO"].ToString());
                            dto.Nome = dr["NOME"].ToString();
                            dto.DataNascimento = Convert.ToDateTime(dr["DATA"].ToString());
                            dto.Idade = Convert.ToInt32(dr["IDADE"].ToString());
                            dto.Cidade = dr["CIDADE"].ToString();
                            dto.Sexo = dr["SEXO"].ToString();
                            dto.Cpf = Convert.ToInt64(dr["CPF"].ToString());

                        }
                        dr.Close();
                    }

                }

                return dto;

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }


        public bool ExcluirClientePorCodigo(int codigoCliente)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqLite))
                {
                    conn.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.Append("DELETE FROM CRUD_ESTAGIO WHERE CODIGO = @CODIGO");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@CODIGO", codigoCliente);

                        int linhasafetadas = cmd.ExecuteNonQuery();

                        // Verifica se alguma linha foi excluída
                        return linhasafetadas > 0;
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }


        public DataTable ObterPorFiltro(string filtro, string valor)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connSqLite))
            {
                conn.Open();
                StringBuilder sql = new StringBuilder();

                sql.Append($"SELECT CODIGO, NOME, CPF, CAST(DATANASCIMENTO AS TEXT) AS DATA, IDADE, CIDADE, SEXO ");
                sql.Append($"FROM CRUD_ESTAGIO");
                sql.Append($" WHERE {filtro} ");


                if (filtro == "NOME" || filtro == "CIDADE")
                    sql.Append(" LIKE @valor");
                else
                    sql.Append(" = @valor");

                using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                {
                    if (filtro == "NOME" || filtro == "CIDADE")
                    {
                        cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@valor", valor);
                    }

                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }



        //////////////public DataTable ObterPorFiltro(string filtro, string valor)
        //////////////{
        //////////////    using (SQLiteConnection conn = new SQLiteConnection(connSqLite))
        //////////////    {
        //////////////        conn.Open();
        //////////////        StringBuilder sql = new StringBuilder();

        //////////////        if (filtro ==("NOME") || filtro ==("CIDADE"))
        //////////////        {
        //////////////            sql.Append($"SELECT CODIGO, NOME, CPF, CAST(DATANASCIMENTO AS TEXT) AS DATA, IDADE, CIDADE, SEXO FROM CRUD_ESTAGIO WHERE {filtro} LIKE @valor");
        //////////////        }
        //////////////        else
        //////////////        {
        //////////////            sql.Append($"SELECT CODIGO, NOME,  CPF, CAST(DATANASCIMENTO AS TEXT) AS DATA, IDADE, CIDADE ,SEXO FROM CRUD_ESTAGIO WHERE {filtro} = @valor");
        //////////////        }

        //////////////        using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
        //////////////        {
        //////////////            if (filtro == ("NOME") || filtro == ("CIDADE"))
        //////////////            {
        //////////////                cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");
        //////////////            }
        //////////////            else
        //////////////            {
        //////////////                cmd.Parameters.AddWithValue("@valor", valor);
        //////////////            }

        //////////////            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
        //////////////            DataTable dt = new DataTable();
        //////////////            da.Fill(dt);
        //////////////            return dt;
        //////////////        }
        //////////////    }
        //////////////}


        public DataTable RetornaSexo()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connSqLite))
            {
                conn.Open();
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT CODIGO, DESCRICAO FROM SEXO");

                using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                {
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }





























        public Boolean ExcluirCliente(string nome)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nome))
                {
                    // Se o nome estiver vazio ou em branco, não faça nada e retorne falso
                    return false;
                }

                using (SQLiteConnection conn = new SQLiteConnection(connSqLite))
                {
                    conn.Open();

                    StringBuilder sql = new StringBuilder();
                    sql.Append("DELETE FROM CRUD_ESTAGIO WHERE CODIGO LIKE CODIGO");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@NOME", "%" + nome + "%");

                        int linhasafetadas = cmd.ExecuteNonQuery();

                        // Verifique se alguma linha foi excluída
                        return linhasafetadas > 0;
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }



        }
























        public Boolean Atualizar(ClientesDto dto)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqLite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE CRUD_ESTAGIO SET NOME=@NOME,DATANASCIMENTO = @DATANASCIMENTO,IDADE = @IDADE,CIDADE = @CIDADE,SEXO = @SEXO , CPF = @CPF ");
                    sql.Append("WHERE CODIGO = @CODIGO");


                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@NOME", dto.Nome);
                        cmd.Parameters.AddWithValue("@DATANASCIMENTO", dto.DataNascimento.ToString("dd/MM/yyyy"));
                        cmd.Parameters.AddWithValue("@IDADE", dto.Idade);
                        cmd.Parameters.AddWithValue("@CIDADE", dto.Cidade);
                        cmd.Parameters.AddWithValue("@SEXO", dto.Sexo);
                        cmd.Parameters.AddWithValue("@CPF", dto.Cpf);
                        cmd.Parameters.AddWithValue("@CODIGO", dto.Codigo);
                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }


        //public ClientesDto MostraDadosCliente(string codigoCliente)
        //{
        //    try
        //    {


        //        select CODIGO,
        //NOME,
        //DATANASCIMENTO,
        //IDADE,
        //CIDADE,
        // CASE SEXO
        // WHEN 'F' THEN 'Feminino' 
        // WHEN 'M' THEN 'Masculino' end as SEXO,
        // CPF



        //FROM CRUD_ESTAGIO



        //    }
        //    catch (Exception erro)
        //    {
        //        throw new Exception(erro.Message);
        //    }
        //}


    }



}





























namespace Crud_Estagio.code.bll
{
    using Crud_Estagio.code.dal;
    using Crud_Estagio.code.dto;
    using System;
    using System.Data;

    public class ClientesBll
    {
        private ClientesDal dal = new ClientesDal();

        public Boolean Salvar(ClientesDto dto)
        {
            return dal.Salvar(dto);
        }

        public Boolean CpfJaCadastrado(string cpf)
        {
            return dal.CpfJaCadastrado(cpf);
        }

        public DataTable PesquisaClientes(string nome)
        {
            return dal.PesquisaClientes(nome);
        }

        public Boolean Atualizar(ClientesDto dto)
        {
            return dal.Atualizar(dto);
        }

        public bool ExcluirPorCodigo(int codigoCliente)
        {
            try
            {
                return dal.ExcluirClientePorCodigo(codigoCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir cliente: " + ex.Message);
            }
        }

        public ClientesDto DadosCliente(Int32 codigoCliente)
        {
            try
            {
                return dal.DadosCliente(codigoCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar dados: " + ex.Message);
            }
        }

        public DataTable ObterPorFiltro(string filtro, string valor)
        {
            // Chama o método da DAL e retorna os resultados
            return dal.ObterPorFiltro(filtro, valor);
        }

        public DataTable RetornaSexo()
        {
            return dal.RetornaSexo();
        }
    }
}

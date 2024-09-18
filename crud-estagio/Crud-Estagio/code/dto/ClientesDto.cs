namespace Crud_Estagio.code.dto
{
    using System;

    public class ClientesDto
    {
        public int Codigo { get; set; }

        public string? Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public int Idade { get; set; }

        public string? Cidade { get; set; }

        public string? Sexo { get; set; }

        public long Cpf { get; set; }

        public ClientesDto()
        {
            Codigo = 0;
            Nome = string.Empty;
            DataNascimento = DateTime.MinValue;
            Idade = 0;
            Cidade = string.Empty;
            Sexo = string.Empty;
            Cpf = 0;
        }
    }
}

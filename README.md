<div align="center">

# 👥 CRUD de Clientes

**Cadastro de clientes desktop em C# Windows Forms com SQLite.**

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_7-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![SQLite](https://img.shields.io/badge/SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white)

</div>

## 💡 Sobre

Aplicação Windows Forms feita durante o estágio para praticar as operações de gravação, consulta, alteração e exclusão. Os clientes (código, nome, data de nascimento, idade, cidade, sexo e CPF) ficam num banco SQLite, com o código separado em camadas DTO, BLL e DAL.

## ✨ Funcionalidades

- Gravar cliente com código gerado automaticamente
- Bloqueio de CPF duplicado
- Pesquisa de clientes por nome e pesquisa geral em grade
- Alterar e excluir cliente
- Menu de navegação entre as telas

## 🛠️ Tecnologias

- C# / .NET 7 (Windows Forms)
- SQLite (`System.Data.SQLite`)
- Arquitetura em camadas (DTO / BLL / DAL)

## 🚀 Como rodar

Requer Windows e .NET 7 SDK ou superior (ou Visual Studio 2022).

O caminho do banco está fixo em `code/dal/ClientesDal.cs` como `C:\Crud-Estagio\Database\crud`. Copie o arquivo `Database/crud` deste repositório para `C:\Crud-Estagio\Database\` ou ajuste esse caminho antes de rodar.

```bash
git clone https://github.com/KevinLopes23/Crud.git
cd Crud/crud-estagio/Crud-Estagio
dotnet run
```

## 📄 Licença

Distribuído sob a licença MIT. Veja [LICENSE](LICENSE).

## 👤 Autor

Feito por [Kevin Lopes](https://github.com/KevinLopes23)

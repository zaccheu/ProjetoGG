namespace CadastroClientes.Models.Repository
{
    public class ClientesRepository
    {
        public void Salvar(Clientes clientes)
        {
            File.AppendAllText(@"C:\\Users\\José\\Documents\\DEV\\ProjetoGG\\ProjetoGG\\CadastroBaseClientes\\BD.txt", "Rafael");
        }


        public List<Clientes> Listar ()
        {
            List <Clientes> clientesLista = new List<Clientes> ();
            
            //instanciando o cliente Rafael
            Clientes cliente = new Clientes ();
            cliente.UF = "SP";
            cliente.Telefone = "93472497";
            cliente.Documento = "22233349948";
            cliente.Email = "rafael@gmail.com";
            cliente.Nome = "Rafael da Silva";
            cliente.Sexo = "M";
            cliente.IdCliente = 10;
            clientesLista.Add(cliente);

            //instanciando o cliente Rafael
            cliente = new Clientes();
            cliente.UF = "MG";
            cliente.Telefone = "965472497";
            cliente.Documento = "65433349948";
            cliente.Email = "joao@gmail.com";
            cliente.Nome = "João da Silva";
            cliente.Sexo = "M";
            cliente.IdCliente = 22;
            clientesLista.Add(cliente);

            cliente = new Clientes();
            cliente.UF = "RJ";
            cliente.Telefone = "981172497";
            cliente.Documento = "68763349948";
            cliente.Email = "MARIA@gmail.com";
            cliente.Nome = "Maria da Silva";
            cliente.Sexo = "F";
            cliente.IdCliente = 23;
            clientesLista.Add(cliente);

            return clientesLista.OrderByDescending(t=>t.Nome).ToList(); 
        }
    }
}

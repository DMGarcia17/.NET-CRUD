namespace EfProject.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Cliente
    {
        public int ID { get; set; }
        
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string nombre { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat (DataFormatString="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public System.DateTime fechaAlta { get; set; }
        
        [Range(18,60)]
        public int edad { get; set; }


        public static Cliente GetClienteObj(Clientes clientes)
        {
            Cliente cli = new Cliente();
            cli.ID = clientes.ID;
            cli.nombre = clientes.nombre;
            cli.fechaAlta = clientes.fechaAlta;
            cli.edad = clientes.edad;
            return cli;
        }
        
        public static Clientes GetClientesObj(Cliente cliente)
        {
            Clientes cli = new Clientes();
            cli.ID = cliente.ID;
            cli.nombre = cliente.nombre;
            cli.fechaAlta = cliente.fechaAlta;
            cli.edad = cliente.edad;
            return cli;
        }
    }
}
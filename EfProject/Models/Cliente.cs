namespace EfProject.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Cliente
    {
        public int ID { get; set; }
        
        [DataType(DataType.Text)]
        [StringLength(60)]
        public string nombre { get; set; }
        
        [Display(Name = "Fecha de ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat (DataFormatString="{0:YYYY-MM-DD}",ApplyFormatInEditMode = true)]
        public System.DateTime fechaAlta { get; set; }
        
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
    }
}
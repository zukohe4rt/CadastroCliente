using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CadastroCliente.Models
{


    public class Cliente
    {
        public int Id { get; set; }


        [StringLength(10, MinimumLength = 4)]
        [Required(ErrorMessage = "informe o nome")]
        [Display(Name = "Nome:")]
        public string Name { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "informe o email")]

        public string Email { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "informe o sexo = exemplo = masculino")]

        public string Sexo { get; set; }

        [StringLength(2, MinimumLength = 2)]
        [MinLength(2)]
        [Required(ErrorMessage = "informe o DDD: exemplo = 11")]
        [DataType(DataType.PostalCode)]
        public int Ddd { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "informe o telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }


        [Required(ErrorMessage = "informe o endereço")]
        [StringLength(20)]
        public string Endereco { get; set; }


        [StringLength(20)]
        [MinLength(4)]
        [Required(ErrorMessage = "informe a cidade: exemplo = São Paulo")]


        public string Cidade { get; set; }


        [StringLength(2)]
        [Required(ErrorMessage = "informe o estado: exemplo = SP")]


        public string Estado { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "informe o Bairro")]


        public string Bairro { get; set; }


        [Required(ErrorMessage = "informe o Login")]

        [DataType(DataType.EmailAddress)]
        public string Login { get; set; }



        [StringLength(20)]
        [Required(ErrorMessage = "informe a senha")]
        [DataType(DataType.Password)]

        public string Senha { get; set; }



    }
}

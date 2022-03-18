using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    public class VendaCompleta
    {
        private int id;
        private double desconto;
        private double total;
        private string cpf_cnpj;
        private string nome;
        private DateTime criado_em;

        public VendaCompleta()
        {
                
        }                   
        
        public VendaCompleta(int id, double desconto, double total_venda, string cli_cpf_cnpj, string cli_name, DateTime venda_criado_em)
        {
            this.id = id;
            this.desconto = desconto;
            this.total = total_venda;
            this.cpf_cnpj = cli_cpf_cnpj;
            this.nome = cli_name;
            this.criado_em = venda_criado_em;
        }

        public int Id { get => id; set => id = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public double Total_venda { get => total; set => total = value; }
        public string Cli_cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public string Cli_name { get => nome; set => nome = value; }
        public DateTime Venda_criado_em { get => criado_em; set => criado_em = value; }
    }
}

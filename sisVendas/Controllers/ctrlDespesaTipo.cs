using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Data;

namespace sisVendas.Controllers
{
    class ctrlDespesaTipo
    {
        private Banco dataBase = new Banco();
        private DespesaTipo TipoSelecionado = new DespesaTipo();

        public bool SalvarDespesaTipo(string id, string name)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                TipoSelecionado.Id = number;

            TipoSelecionado.Nome = name;

            dataBase.Conecta();
            bool result = false;
            DespesaTipoDB tipoDB = new DespesaTipoDB(dataBase);
            if (number == 0)
            {
                result = tipoDB.Gravar(TipoSelecionado);
            }
            else
            {
                result = tipoDB.Atualizar(TipoSelecionado);
            }
            dataBase.Desconecta();

            return (result);
        }
        public DataTable BuscarDespesaTipo(string filter)
        {

            DataTable dtDespTipo = new DataTable();

            dtDespTipo.Columns.Add("desp_tipo_id", typeof(int));
            dtDespTipo.Columns.Add("desp_tipo_nome");
            dtDespTipo.Columns.Add("desp_tipo_criado_em", typeof(DateTime));

            dataBase.Conecta();
            DespesaTipoDB tipoDB = new DespesaTipoDB(dataBase);
            foreach (DespesaTipo exptype in tipoDB.Buscar(filter))
            {

                DataRow line = dtDespTipo.NewRow();

                line["desp_tipo_id"] = exptype.Id;
                line["desp_tipo_nome"] = exptype.Nome;
                line["desp_tipo_criado_em"] = exptype.Created_at;


                dtDespTipo.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtDespTipo);
        }
        public bool RemoverDespesaTipo(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            DespesaTipoDB tipoDB = new DespesaTipoDB(dataBase);
            res = tipoDB.Remover(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}


using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Controllers
{
    public class ctrlMunicipio
    {
        private Banco dataBase = new Banco();
        public DataTable Buscar(int codigo)
        {

            DataTable dttMunicipio = new DataTable();

            dttMunicipio.Columns.Add("muni_cod", typeof(int));
            dttMunicipio.Columns.Add("muni_nome");

            dataBase.Conecta();
            MunicipioDB muniDB = new MunicipioDB(dataBase);
            foreach (Municipio item in muniDB.buscar(codigo))
            {

                DataRow line = dttMunicipio.NewRow();

                line["muni_cod"] = item.Cod;
                line["muni_nome"] = item.Nome;


                dttMunicipio.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dttMunicipio);
        }
    }
}

using CAI_Prestamo.Entidades;
using CAI_Prestamo.Entidades.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Prestamo.Datos
{
    public class TipoPrestamoMapper
    {
        public List <TipoPrestamo> GetTiposPrestamos()
        {
            string json = WebHelper.Get("./prestamotipo");
            return MapList(json);
        }
        public List <TipoPrestamo> MapList (string json)
        {
            return JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
        }
        private TransactionResult MapResultado (string json)
        {
            return JsonConvert.DeserializeObject<TransactionResult>(json);
        }

    }
}

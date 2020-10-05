using calculaJuros.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculaJuros.Service
{
    public class IntegracaoTaxaJuros
    {
        private readonly RestRequests _restResquest;

        public IntegracaoTaxaJuros(RestRequests restRequests)
        {
            _restResquest = restRequests;        
        }

        public double BuscarTaxaJuros(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                    return 0;

                return _restResquest.Get(url)["valorDoJuros"];                
            }
            catch (Exception ex)
            {
                throw new Exception($"Não Foi Possível realizar a Operação. Erro: {ex}");
            }
        }
    }
}

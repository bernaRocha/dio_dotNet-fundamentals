using System;
using System.Collections.Generic;
using dio.series.Interfaces;

namespace dio.series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>(); // A lista aqui está separada do programa principal
        public void Atualiza(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
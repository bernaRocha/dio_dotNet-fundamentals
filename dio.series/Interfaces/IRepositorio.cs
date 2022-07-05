using System.Collections.Generic;

namespace dio.series.Interfaces
{
    public interface IRepositorio<T> // T é um tipo genérico
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
                
    }
}
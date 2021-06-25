using System.Collections.Generic;

namespace Primeiro_Desafio.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        void Adicionar (T objeto);
        void Excluir (int index);
        void Atualizar (int index, T novoObjeto);
        void Listar();
        T RetornaPorId (int index);
        int ProximoId();

    }
}
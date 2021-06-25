using System;
using System.Collections.Generic;
using Primeiro_Desafio.Interfaces;

namespace Primeiro_Desafio
{
    public class RepositorioSerie : IRepositorio<Serie>
    {
        public List<Serie> listaElementos = new List<Serie>();

        public void Adicionar(Serie objeto)
        {
            listaElementos.Add(objeto);
        }

        public void Atualizar(int index, Serie novoObjeto)
        {
            listaElementos[index] = novoObjeto;
        }

        public void Excluir(int index)
        {
            listaElementos[index].Excluir();
        }

        public List<Serie> Lista()
        {
            return listaElementos;
        }

        public void Listar()
        {
            if (listaElementos.Count == 0)
            {
                Console.WriteLine("Não há séries cadastradas");
                return;
            }

            foreach (Serie serie in listaElementos)
            {
                if (!serie.getExcluido())
                {
                    Console.WriteLine($"ID: {serie.getId()} - {serie.getTitulo()}");
                }
            }
        }

        public Serie RetornaPorId(int index)
        {
            return listaElementos[index];
        }

        public int ProximoId ()
        {
            return listaElementos.Count;
        }
    }
}
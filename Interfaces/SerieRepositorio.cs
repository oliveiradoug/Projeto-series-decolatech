using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.series.Interfaces
{
    class SerieRepositorio
    {
        public class SerieRepositorio : IRepositorio<Serie>
        {
            private List<Serie> ListaSerie = new List<Serie>();
            public void Atualiza(int id, Serie obejto)
            {
                ListaSerie(id) = objeto;
            }
            public void Exclui(int id)
            {
                ListaSerie(id).Excluir();
            }
            public void Insere(Serie entidade)
            {
                ListSerie.Add(objeto);
            }

            public List<Serie> Lista()
            {
                return ListaSerie;
            }
            public int ProximoId()
            {
                return ListaSerie.Count;

            }
            public int RetornaPorId(int Id)
            {
                return ListaSerie(Id);

            }

        }

    }
}

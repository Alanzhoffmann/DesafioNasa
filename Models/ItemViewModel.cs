using System;
using DesafioNasa.Entidades;

namespace DesafioNasa.Models
{
    public class ItemViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public int Prioridade { get; set; }

        public static explicit operator ItemViewModel(Item item)
        {
            return new ItemViewModel
            {
                Id = item.Id,
                Descricao = item.Descricao,
                Prioridade = item.Prioridade
            };
        }
    }
}

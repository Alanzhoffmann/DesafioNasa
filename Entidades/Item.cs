using System;

namespace DesafioNasa.Entidades
{
    public class Item
    {
        public Item(string descricao)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
        }

        private Item()
        {

        }

        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public int Prioridade { get; set; }
    }
}

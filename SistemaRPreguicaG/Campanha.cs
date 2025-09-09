using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRPreguicaG
{
    internal class Campanha
    {
        public int Id { get; set; }  // 👈 PROPRIEDADE FALTANTE

        public string Nome { get; set; }
        public int NexBase { get; set; }
        public int NumeroJogadores { get; set; }

        public override string ToString()
        {
            return $"{Nome} - NEX: {NexBase} - Jogadores: {NumeroJogadores}";
        }
    }
}
using System;

namespace ProvaAutomovel.Models
{
    public class Automovel
    {
        public Automovel() => CriadoEm = DateTime.Now;

        public int Id {get; set;}
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() => $"Modelo: {Marca} | Marca: {Modelo} | Ano: {Ano} | Cor: {Cor} | CriadoEm: {CriadoEm}";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace MontagemArvore
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var dados = ObterDadosEstrutura();

           

        }
        private static Estrutura[] ObterDadosEstrutura()
        {
            var estrulst = new List<Estrutura>();
            estrulst.Add(new Estrutura {
                Codigo = 1,
                Nome = "A",
                CodigoPai = null

            });
            estrulst.Add(new Estrutura
            {
                Codigo = 2,
                Nome = "B",
                CodigoPai = 1,

            });
            estrulst.Add(new Estrutura
            {
                Codigo = 3,
                Nome = "C",
                CodigoPai = 1,

            });
            estrulst.Add(new Estrutura
            {
                Codigo = 4,
                Nome = "D",
                CodigoPai = 2,

            });
            estrulst.Add(new Estrutura
            {
                Codigo = 5,
                Nome = "E",
                CodigoPai = 6,

            });
            estrulst.Add(new Estrutura
            {
                Codigo = 6,
                Nome = "F",
                CodigoPai = 2,

            });

            return estrulst.ToArray();
        }
    }

    public class Estrutura
    {
        public Estrutura()
        {
            Filhos = new List<Estrutura>();
            
            
        }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int? CodigoPai { get; set; }
        public Estrutura EstruturaPai { get; set; }
        public List<Estrutura> Filhos { get; set; }

        public void ListaEstrutura()
        {
            Estrutura filho = new Estrutura();

            filho.Codigo = 1;
            filho.Nome = "A";
            filho.CodigoPai = null;

            Filhos.Add(filho);
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        // Os atributos do elevador (Capacidade, total de andares do prédio,...)
        public int andar_atual;
        public int pessoas;
        public int total_andares;
        public int capacidade;

        public void Inicializar(int capacidade_pessoas, int numero_andares)
        {
            andar_atual = 0;
            pessoas = 0;
            total_andares = numero_andares;
            capacidade = capacidade_pessoas;

        }

        public void Entrar()
        {
            if (pessoas < capacidade)
            {
                pessoas++;
            }
        }

        public void Sair()
        {
            if (pessoas > 0)
            {
                pessoas--;
            }
        }

        public void Subir()
        {
            if (andar_atual < total_andares)
            {
                andar_atual++;
            }
        }

        public void Descer()
        {
            if (andar_atual > 0)
            {
                andar_atual--;
            }
        }

    }


}

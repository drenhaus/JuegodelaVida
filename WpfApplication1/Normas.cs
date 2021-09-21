using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NormasJuego
{
    class Normas
    {
        int vecinos_vivos;
        bool estado_actual_viva;
        bool estado_futuro_viva=false; // definimos que en un inicio estara muerta

        public void SetVecinosVivos(int num)
        { this.vecinos_vivos = num; }

        public void SetEstadoVida(bool vida)
        { this.estado_actual_viva = vida; }

        public bool ActualizarVida(bool vida_ahora, int vecinos)
        {
            if ((vida_ahora == true) && (vecinos == 2 || vecinos == 3))
            { this.estado_futuro_viva = true; }

            if ((vida_ahora == false) && (vecinos == 3))
            { this.estado_futuro_viva = true; }

            return this.estado_futuro_viva;
        }



    }
}

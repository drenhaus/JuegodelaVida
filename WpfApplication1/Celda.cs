using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NormasJuego;

namespace WpfApplication1
{
    class Celda
    {

       
        bool viva = false;
        int vecinos_vivos;
        

        
       
        public void SetVida(bool vida)
        {this.viva = vida;}


        public bool GetVida()
        {return (this.viva);}



        public void SetVecinosVivos(int num)
        { this.vecinos_vivos = num; }

        public void ActualizarCelda(Normas norma1)
        {
            this.viva = norma1.ActualizarVida(this.viva, this.vecinos_vivos);
        }

    }
}

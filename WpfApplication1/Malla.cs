using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NormasJuego;
using WpfApplication1;

namespace WpfApplication2
{
    class Malla
    {
        int x=0; //numero de colummnas
        int y=0; //numero de filas


        int numeroTotalDeVivos;
        int contadorVecinosVivos;
        Celda[,] matriz_malla;

        Normas norma1 = new Normas();

        public Celda[,] GetMatriz()
        {
            return this.matriz_malla;
        }


        public void SetNumeroDeFilasYColumnas(int fila, int columna)
        {
            this.y = fila;
            this.x = columna;
            
            this.matriz_malla = new Celda [y, x];

            Celda fill = new Celda(); // rellenamos la matriz con celdas
            fill.SetVida(false);

            for (int i = 0; i < y; i++)
                for (int j = 0; j < x; j++)
                {{
                    matriz_malla[i,j]=fill;

                }}
 
        }

        public void SetVidaDeCelda(int fila, int columna, bool vida)
        {
            matriz_malla[fila, columna].SetVida(vida);
        
        }


        public bool DameElEstadoDe(int posFILAS, int posCOLUMNAS)
        {

            return (this.matriz_malla[posFILAS, posCOLUMNAS].GetVida());
        }


        public int GetNumeroDeVivosDeLaMatriz()
        {
            numeroTotalDeVivos = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; i < y; j++)
                {
                    if (matriz_malla[j, i].GetVida() == true) ;
                    numeroTotalDeVivos++;
                }
            }
            return numeroTotalDeVivos;
        }


        public void NumeroDeVecinosVivos(int Fila, int Columna)
        {

            contadorVecinosVivos = 0;
            try
            {
                if (matriz_malla[Fila - 1, Columna].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }
            }

            catch
            { }

            try
            {
                if (matriz_malla[Fila + 1, Columna].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }

            }

            catch
            { }

            try
            {
                if (matriz_malla[Fila - 1, Columna + 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }
            }

            catch
            { }


            try
            {
                if (matriz_malla[Fila, Columna + 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }
            }

            catch
            { }


            try
            {
                if (matriz_malla[Fila + 1, Columna + 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }

            }

            catch
            { }

            try
            {
                if (matriz_malla[Fila - 1, Columna - 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }

            }

            catch
            { }
            try
            {
                if (matriz_malla[Fila, Columna - 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }
            }

            catch
            { }

            try
            {
                if (matriz_malla[Fila + 1, Columna - 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }

            }

            catch
            { }

            
            matriz_malla[Fila, Columna].SetVecinosVivos(contadorVecinosVivos);
            norma1.SetVecinosVivos(contadorVecinosVivos);
            

        }



        public void MallaFutura()
        {

            for (int i = 1; i < x; i++)
            {
                for (int j = 1; j < y; j++)
                {
                    
                    matriz_malla[j, i].ActualizarCelda();
                  
                }
            }

        }
    }

}

    

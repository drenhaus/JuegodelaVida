using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NormasJuego;

namespace WpfApplication1
{
    class Malla
    {
        int x; //numero de colummnas
        int y; //numero de filas


        int numeroTotalDeVivos;
        int contadorVecinosVivos;
        Celda[,] matriz_malla;






        public void SetNumeroDeFilasYColumnas(int YCord, int XCord)
        {
            this.y = YCord;
            this.x = XCord;
            matriz_malla = new Celda[y, x];
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


        public int NumeroDeVecinosVivos(int Fila, int Columna)
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

            return contadorVecinosVivos;

        }



        public void MallaFutura(Normas norma2)
        {

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; i < y; j++)
                {
                    matriz_malla[j, i].ActualizarCelda(norma2);
                }
            }

        }
    }

}

    

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
        Celda[,] matriz_malla; // matriz_malla_Clone =matriz_malla
        Celda[,] matriz_malla_Clone; //matriz espejo

        Normas norma1 = new Normas(); //   MIRAR

        public Celda[,] GetMatriz()
        {
            return this.matriz_malla;
        }

        public void ClonarMatrix()
        {
            
               for (int i = 0; i < x; i++)
                   for (int j = 0; j < y; j++)
                   {
                       {
                           Celda fill_clone = new Celda(); // rellenamos la matriz con celdas
                           matriz_malla_Clone[j, i] = fill_clone;
                           matriz_malla_Clone[j, i].SetVida(matriz_malla[j, i].GetVida());
                          // matriz_malla_Clone[j, i].SetVecinosVivos(matriz_malla[j, i].GetVecinosVivos()); // clonem 0 ja que no hem contat els veins encara
                       }
                   }

        }

        public void SetNumeroDeFilasYColumnas(int fila, int columna)
        {
            this.y = fila;
            this.x = columna;
            
            this.matriz_malla = new Celda [y, x];
            this.matriz_malla_Clone = new Celda[y, x];

           
           // fill.SetVida(false);  // mitrara treure esta a celda

            for (int i = 0; i < y; i++)
                for (int j = 0; j < x; j++)
                {{
                    Celda fill = new Celda(); // rellenamos la matriz con celdas
                    Celda fill_clone = new Celda(); // rellenamos la matriz con celdas
                    

                    matriz_malla[i,j]=fill;
                    matriz_malla_Clone[i, j] = fill_clone;
                }}
 
        }

        public void SetVidaDeCelda(int fila, int columna, bool vida) // ERRORSS
        {
            //this.matriz_malla[1, 1].SetVida(vida);
            
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
                    if (matriz_malla[j, i].GetVida() == true);
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
                if (matriz_malla_Clone[Fila - 1, Columna].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }
            }

            catch
            { }

            try
            {
                if (matriz_malla_Clone[Fila + 1, Columna].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }

            }

            catch
            { }

            try
            {
                if (matriz_malla_Clone[Fila - 1, Columna + 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }
            }

            catch
            { }


            try
            {
                if (matriz_malla_Clone[Fila, Columna + 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }
            }

            catch
            { }


            try
            {
                if (matriz_malla_Clone[Fila + 1, Columna + 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }

            }

            catch
            { }

            try
            {
                if (matriz_malla_Clone[Fila - 1, Columna - 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }

            }

            catch
            { }
            try
            {
                if (matriz_malla_Clone[Fila, Columna - 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }
            }

            catch
            { }

            try
            {
                if (matriz_malla_Clone[Fila + 1, Columna - 1].GetVida() == true)
                {
                    contadorVecinosVivos++;
                }

            }

            catch
            { }

            return contadorVecinosVivos;
           // matriz_malla[Fila, Columna].SetVecinosVivos(contadorVecinosVivos);
           //norma1.SetVecinosVivos(contadorVecinosVivos);
            

        }



        public void MallaFutura()
        {
            ClonarMatrix();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    matriz_malla_Clone[j, i].SetVecinosVivos(NumeroDeVecinosVivos(j, i));  // gusrada # de veisn en el clone  

                    
                    // origin te valor viu mort // clone te vius i veins

                    matriz_malla[j, i].ActualizarCelda(matriz_malla_Clone[j,i].GetVida(), matriz_malla_Clone[j,i].GetVecinosVivos()); //need clonar
                  
                }
            }

        }
    }

}

    

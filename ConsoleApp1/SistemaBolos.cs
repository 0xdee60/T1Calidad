using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SistemaBolos
    {
        public List<Juego> juegos { get; set; }
        public int total { get; set; }

        public int Iniciar()
        {
            juegos = new List<Juego>();
            return 1;
        }

        public int Lanzar(int turno1, int turno2, int jugador)
        {

            var juego = new Juego();
            juego.turno1 = turno1;
            juego.turno2 = turno2;
            juego.jugador = jugador;

            juegos.Add(juego);

            return 1;
        }

        public List<int> CalcularPuntosPorJuego(int jugador)
        {
            //Suma todos los putnos fuera de las reglas
            List<int> resultados = new List<int>();
            int pos1 = 0;
            foreach (var juego in juegos)
            {
                if (juego.jugador == jugador)
                {
                    if (juego.turno1 != 10 && (juego.turno1+juego.turno2) <10)
                    {
                        juego.puntos = juego.turno1 + juego.turno2;
                        resultados.Add(juego.puntos);
                        pos1++;
                    }

                }
                
            }

            int pos = 0;



            //Aplica reglas
            foreach (var juego in juegos)
            {
                if (juego.jugador == jugador)
                {
                    //Strike
                    if (juego.turno1 == 10)
                    {
                        if (pos == 0)
                        {
                            juego.puntos = 10 +
                                juegos[pos + 1].turno1 + juegos[pos + 1].turno2;
                            resultados.Add(juego.puntos);
                        }
                        else
                        {
                            if (pos < 9) {
                                juego.puntos = 10 + juegos[pos-1].puntos +
                                juegos[pos + 1].turno1 + juegos[pos + 1].turno2;
                                resultados.Add(juego.puntos);
                            }
                            else
                            {
                                juego.puntos = 10 + juegos[pos - 1].puntos;
                                resultados.Add(juego.puntos);
                            }
                        }
                    }
                    else
                    {
                        //Spare
                        if (juego.turno2 + juego.turno1 == 10)
                        {
                            juego.puntos = 10 + juegos[pos + 1].turno1;
                            resultados.Add(juego.puntos);

                            if (juego.puntos == 10 && pos == 9)
                            {
                                juego.puntos = 10 ;
                                resultados.Add(juego.puntos);
                            }
                          

                        }
                    }
                    

                    
                }
                pos++;

            }


            return resultados;
        }

        public int SumarPuntosJugador(int jugador)
        {
            int suma = 0;
            var x = CalcularPuntosPorJuego(jugador);

            foreach (var item in x)
            {
                suma = suma + item;
                
            }


            return suma;
        }

    }
}

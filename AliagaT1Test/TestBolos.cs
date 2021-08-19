using ConsoleApp1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AliagaT1Test
{
    [TestFixture]
    public class TestBolos
    {
        [Test]
        public void Test1()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(4,4,1);
            sb.Lanzar(3,2,1);

            List<int> result1 = sb.CalcularPuntosPorJuego(1);
            List<int> resultEsperado1 = new List<int>();
            resultEsperado1.Add(8);
            resultEsperado1.Add(5);
            Assert.AreEqual(result1,resultEsperado1);
        }

        [Test]
        public void Test2()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(3, 2, 1);

            List<int> result = sb.CalcularPuntosPorJuego(1);
            List<int> resultEsperado = new List<int>();
            resultEsperado.Add(5);
            resultEsperado.Add(15);
            Assert.AreEqual(result, resultEsperado);
        }
        [Test]
        public void Test3()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(3, 2, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 5, 1);

            List<int> result = sb.CalcularPuntosPorJuego(1);
            List<int> resultEsperado = new List<int>();
            resultEsperado.Add(5);
            resultEsperado.Add(7);
            resultEsperado.Add(22);
            Assert.AreEqual(result, resultEsperado);
        }
        [Test]
        public void Test4()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(3, 2, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 2, 1);

            List<int> result = sb.CalcularPuntosPorJuego(1);
            List<int> resultEsperado = new List<int>();

            resultEsperado.Add(5);
            resultEsperado.Add(7);
            resultEsperado.Add(7);
            resultEsperado.Add(7);
            resultEsperado.Add(7);
            resultEsperado.Add(7);
            resultEsperado.Add(4);
            resultEsperado.Add(22);
            resultEsperado.Add(21);
           


            Assert.AreEqual(result, resultEsperado);
        }



        [Test]
        public void Test5()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(3, 2, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 0, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 2, 1);

            List<int> result = sb.CalcularPuntosPorJuego(1);
            List<int> resultEsperado = new List<int>();

            resultEsperado.Add(5);
            resultEsperado.Add(7);
            resultEsperado.Add(7);
            resultEsperado.Add(7);
            resultEsperado.Add(7);
            resultEsperado.Add(7);
            resultEsperado.Add(2);
            resultEsperado.Add(4);
            resultEsperado.Add(22);
            resultEsperado.Add(16);



            Assert.AreEqual(result, resultEsperado);
        }


        [Test]
        public void Test6()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(5, 5, 1);
            sb.Lanzar(2, 2, 1);

            List<int> result = sb.CalcularPuntosPorJuego(1);
            List<int> resultEsperado = new List<int>();

            resultEsperado.Add(4);
            resultEsperado.Add(12);
            

            Assert.AreEqual(result, resultEsperado);
        }

        [Test]
        public void Test7()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(6, 4, 1);
            sb.Lanzar(2, 2, 1);

            List<int> result = sb.CalcularPuntosPorJuego(1);
            List<int> resultEsperado = new List<int>();

            resultEsperado.Add(4);
            resultEsperado.Add(12);


            Assert.AreEqual(result, resultEsperado);
        }

        [Test]
        public void Test8()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(0, 10, 1);
            sb.Lanzar(2, 2, 1);

            List<int> result = sb.CalcularPuntosPorJuego(1);
            List<int> resultEsperado = new List<int>();

            resultEsperado.Add(4);
            resultEsperado.Add(12);


            Assert.AreEqual(result, resultEsperado);
        }

        [Test]
        public void Test9()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(4, 4, 1);
            sb.Lanzar(3, 2, 2);
            sb.CalcularPuntosPorJuego(1);

            var result1 = sb.SumarPuntosJugador(1);
            int resultEsperado1 = 8;
           
            Assert.AreEqual(result1, resultEsperado1);
        }

        [Test]
        public void Test10()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(3, 2, 1);

            int result = sb.SumarPuntosJugador(1);
            
            Assert.AreEqual(result, 20);
        }

        [Test]
        public void Test11()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(3, 2, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 2, 1);

           

            int result = sb.SumarPuntosJugador(1);

            Assert.AreEqual(result,87 );
        }


        [Test]
        public void Test12()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(3, 2, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 2, 1);


            sb.Lanzar(3, 2, 2);
            sb.Lanzar(10, 0, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(10, 0,2);
            sb.Lanzar(0, 2, 2);


            int result1 = sb.SumarPuntosJugador(1);
            int result2 = sb.SumarPuntosJugador(2);

            int[] resultados = { result1, result2 };
            int[] esperados = { 87, 74 };
            Assert.AreEqual(resultados, esperados);
            
        }

        [Test]
        public void Test13()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(3, 2, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 2, 1);


            sb.Lanzar(3, 2, 2);
            sb.Lanzar(10, 0, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(10, 0, 2);
            sb.Lanzar(0, 2, 2);


            sb.Lanzar(3, 2, 3);
            sb.Lanzar(10, 0, 3);
            sb.Lanzar(4, 5, 3);
            sb.Lanzar(2, 5, 3);
            sb.Lanzar(5, 5, 3);
            sb.Lanzar(2, 5, 3);
            sb.Lanzar(2, 5, 3);
            sb.Lanzar(10, 0, 3);
            sb.Lanzar(0, 2, 3);

            int result1 = sb.SumarPuntosJugador(1);
            int result2 = sb.SumarPuntosJugador(2);
            int result3 = sb.SumarPuntosJugador(3);

            int[] resultados = { result1, result2,result3 };
            int[] esperados = { 87, 74, 81};
            Assert.AreEqual(resultados, esperados);
        }

        [Test]
        public void Test14()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(3, 2, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 2, 1);


            sb.Lanzar(3, 2, 2);
            sb.Lanzar(10, 0, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(10, 0, 2);
            sb.Lanzar(0, 2, 2);


            sb.Lanzar(3, 2, 3);
            sb.Lanzar(10, 0, 3);
            sb.Lanzar(4, 5, 3);
            sb.Lanzar(2, 5, 3);
            sb.Lanzar(5, 5, 3);
            sb.Lanzar(2, 5, 3);
            sb.Lanzar(2, 5, 3);
            sb.Lanzar(10, 0, 3);
            sb.Lanzar(0, 2, 3);


            sb.Lanzar(3, 2, 4);
            sb.Lanzar(10, 0, 4);
            sb.Lanzar(10, 0, 4);
            sb.Lanzar(2, 5, 4);
            sb.Lanzar(0, 10, 4);
            sb.Lanzar(2, 5, 4);
            sb.Lanzar(2, 5, 4);
            sb.Lanzar(10, 0, 4);
            sb.Lanzar(5, 2, 4);


            int result1 = sb.SumarPuntosJugador(1);
            int result2 = sb.SumarPuntosJugador(2);
            int result3 = sb.SumarPuntosJugador(3);
            int result4 = sb.SumarPuntosJugador(4);

            int[] resultados = { result1, result2, result3,result4 };
            int[] esperados = { 87, 74, 81,102 };
            Assert.AreEqual(resultados, esperados);
        }

        [Test]
        public void Test15()
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(3, 2, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(2, 5, 1);
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(2, 2, 1);


            sb.Lanzar(3, 2, 2);
            sb.Lanzar(10, 0, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(2, 5, 2);
            sb.Lanzar(10, 0, 2);
            sb.Lanzar(0, 2, 2);


            sb.Lanzar(3, 2, 3);
            sb.Lanzar(10, 0, 3);
            sb.Lanzar(4, 5, 3);
            sb.Lanzar(2, 5, 3);
            sb.Lanzar(5, 5, 3);
            sb.Lanzar(2, 5, 3);
            sb.Lanzar(2, 5, 3);
            sb.Lanzar(10, 0, 3);
            sb.Lanzar(0, 2, 3);


            sb.Lanzar(3, 2, 4);
            sb.Lanzar(10, 0, 4);
            sb.Lanzar(10, 0, 4);
            sb.Lanzar(2, 5, 4);
            sb.Lanzar(0, 10, 4);
            sb.Lanzar(2, 5, 4);
            sb.Lanzar(2, 5, 4);
            sb.Lanzar(10, 0, 4);
            sb.Lanzar(5, 2, 4);



            sb.Lanzar(3, 2, 5);
            sb.Lanzar(10, 0, 5);
            sb.Lanzar(10, 0, 5);
            sb.Lanzar(2, 5, 5);
            sb.Lanzar(0, 10, 5);
            sb.Lanzar(2, 5, 5);
            sb.Lanzar(2, 5, 5);
            sb.Lanzar(10, 0,5);
            sb.Lanzar(10, 0, 5);
            sb.Lanzar(2, 2, 5);

            int result1 = sb.SumarPuntosJugador(1);
            int result2 = sb.SumarPuntosJugador(2);
            int result3 = sb.SumarPuntosJugador(3);
            int result4 = sb.SumarPuntosJugador(4);
            int result5 = sb.SumarPuntosJugador(5);


            int[] resultados = { result1, result2, result3, result4,result5 };
            int[] esperados = { 87, 74, 81, 102, 126};
            Assert.AreEqual(resultados, esperados);
        }

    }
}

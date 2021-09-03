using System;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int can;
            int suma_par = 0;
            string num;
            int[] array = new int[10];
            Console.WriteLine("Cuantos elementos: ");
            can = int.Parse(Console.ReadLine());
            //Ingresar numero al array
            for(int i = 1; i < can; i++)
            {
                Console.WriteLine

            }
              
        }

        [Test]
        public void Esnumeropar()
        {
            var utils = new StringUtilities();
            var par = new int[] {1,2,3,4,5 };
           var result = utils.SumaPar(par);
           // Assert.AreNotEqual(6, result);
            Assert.AreEqual(6, result);

        }

        [Test]
        public void Esnumeropar2()
        {
            var utils = new StringUtilities();
            var par = new int[] { 10, 20, 33, 7, 5 };
            var result = utils.SumaPar(par);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void Esnumeropar3()
        {
            var utils = new StringUtilities();
            var par = new int[] { 10, 20, 33, 7, 5 };
            var result = utils.SumaPar(par);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void Esnumeropar4()
        {
            var utils = new StringUtilities();
            var par = new int[] { 10, 20, 33, 7, 5 };
            var result = utils.SumaPar(par);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void Esnumeropar5()
        {
            var utils = new StringUtilities();
            var par = new int[] { 10, 20, 33, 7, 5 };
            var result = utils.SumaPar(par);
            Assert.AreEqual(30, result);
            EXAMEN YA ESTOY PREPARADO
        }


        

    }
}
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
        public void NumeroRomano()
        {
            var utils = new StringUtilities();
            var num = new int[] {20};
           var result = utils.Romano(num);
           // Assert.AreNotEqual(6, result);
            Assert.AreEqual('X', result);

        }


        [Test]
        public void NumeroRomano1()
        {
            var utils = new StringUtilities();
            var num = new int[] { 30 };
            var result = utils.Romano(num);
            // Assert.AreNotEqual(6, result);
            Assert.AreEqual('XXX', result);

        }



    

        

    }
}

using NUnit.Framework;
using System;

namespace Tarea1
{
    class Algoritmo1
    {
      
}
    [Test]
    public void NumeroRomano()
    {
        var utils = new StringUtilities();
        var num = new int[] { 20 };
        var result = utils.Romano(num);
        // Assert.AreNotEqual(6, result);
        Assert.AreEqual('XX', result);

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
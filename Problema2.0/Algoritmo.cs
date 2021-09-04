using NUnit.Framework;

namespace Problema2._0
{
    class Algoritmo
    {
    }

    [Test]
    public void QuienGana()
    {
        var utils = new StringUtilities();
        
        var result = utils.Romano(num);
        // Assert.AreNotEqual(6, result);
        Assert.isTrue(Tijera, result);

    }


    [Test]
    public void QuienGana1()
    {
        var utils = new StringUtilities();
        var num = new int[] { 30 };
        var result = utils.Romano(num);
        // Assert.AreNotEqual(6, result);
        Assert.AreEqual('XXX', result);

    }
}

using appAlcancia.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace uTestAlcancia
{   
    [TestClass]
   public  class uTestMoneda
    {
        private clsMoneda ObjMoneda;
        [TestMethod]
       public void uTestdarDenominacion()
        {
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(-1, ObjMoneda.darDenominacion());
        }
        [TestMethod]
        public void uTestdarAño()
        {
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(-1, ObjMoneda.darAño());
        }
    /*    [TestMethod]
        public void uTestdarPropietario()
        {
            ObjMoneda = new clsMoneda();
            ObjMoneda.Generar();
            Assert.AreNotEqual(null, ObjMoneda.darPropietario());
        }

        [TestMethod]
/*        public void uTestdarAlcancia()
        {
            ObjMoneda = new clsMoneda();
            ObjMoneda.Generar();
            Assert.AreNotEqual(null, ObjMoneda.darAlcancia());
        }*/



    }

}

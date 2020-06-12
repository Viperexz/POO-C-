using appAlcancia.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace uTestAlcancia
{
    
    [TestClass]
   public  class uTestMoneda
    {
        #region OBJ
        private clsMoneda ObjMoneda;
        #endregion

        #region testConstructor
        [TestMethod]
        public void uTestConstructor()
        {
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(-1, ObjMoneda.darDenominacion());
            Assert.AreEqual(-1, ObjMoneda.darAño());
        }
        [TestMethod]
        public void uTestConstructorPrm()
        {
            ObjMoneda = new clsMoneda(100,2000);
            Assert.AreEqual(100, ObjMoneda.darDenominacion());
            Assert.AreEqual(2000, ObjMoneda.darAño());
        }
        #endregion

        #region testAcesor
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
        [TestMethod]
        public void uTestdarPropietario()
        {
            ObjMoneda = new clsMoneda();
            ObjMoneda.Generar();
            Assert.AreNotEqual(null, ObjMoneda.darPropietario());
        }

        [TestMethod]
        public void uTestdarAlcancia()
        {
            ObjMoneda = new clsMoneda();
            ObjMoneda.Generar();
            Assert.AreNotEqual(null, ObjMoneda.darAlcancia());
        }
        #endregion

        #region testMutador
        #endregion




    }

}

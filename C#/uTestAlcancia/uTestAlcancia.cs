using appAlcancia.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace uTestAlcancia
{
    [TestClass]
    public class uTetstAlcancia
    {
        #region OBJ
        private clsAlcancia ObjAlcancia;
        private clsPersona ObjPersona;
        private clsMoneda ObjMoneda;
        private clsBillete ObjBillete;
        #endregion

        #region testConstructores

        [TestMethod]
        public void uTestConstructor()
        {
            ObjAlcancia = new clsAlcancia();
            Assert.AreEqual(-1, ObjAlcancia.darCapacidadMoneda());
            Assert.AreEqual(-1, ObjAlcancia.darCapacidadBillete());
        }

        [TestMethod]
        public void uTestConstructorPrm()
        {
            ObjAlcancia = new clsAlcancia(10, 10);
            Assert.AreEqual(10, ObjAlcancia.darCapacidadMoneda());
            Assert.AreEqual(10, ObjAlcancia.darCapacidadBillete());
        }
        #endregion

        #region testAccesores
        [TestMethod]
        public void uTestdarCapacidadMonedas()
        {
            ObjAlcancia = new clsAlcancia();
            Assert.AreEqual(-1, ObjAlcancia.darCapacidadMoneda());
        }
        [TestMethod]
        public void uTestdarCapacidadBilletes()
        {
            ObjAlcancia = new clsAlcancia();
            Assert.AreEqual(-1, ObjAlcancia.darCapacidadBillete());
        }
        #endregion

        #region testAsociar
        [TestMethod]

        public void uTestAsociarPersona()
        {
            clsAlcancia Objeto = new clsAlcancia();
            Objeto.Generar();
            clsPersona ObjAsociado = new clsPersona(10031, "Oscar");
            Assert.AreEqual(true, Objeto.asociarAhorradorCon(ObjAsociado));
            clsPersona ObjEsperado = new clsPersona();
            Assert.AreEqual(true, Objeto.recuperarPersonaCon(10031, ref ObjEsperado));
            Assert.AreEqual(ObjEsperado, ObjAsociado);
        }

        [TestMethod]
        public void uTestAsociarMoneda()
        {
            clsAlcancia Objeto = new clsAlcancia();
            Objeto.Generar();
            clsMoneda ObjAsociado = new clsMoneda(200, 2012);
            Assert.AreEqual(true, Objeto.asociarMonedaCon(ObjAsociado));
            clsMoneda ObjEsperado = new clsMoneda();
            Assert.AreEqual(true, Objeto.recuperarMonedaCon(200, ref ObjEsperado));
            Assert.AreEqual(ObjEsperado, ObjAsociado);
        }
        [TestMethod]
        public void uTestAsociarBillete()
        {
            clsAlcancia Objeto = new clsAlcancia();
            Objeto.Generar();
            clsBillete ObjAsociado = new clsBillete(10000, 2000, 05, 12, "10031");
            Assert.AreEqual(true, Objeto.asociarBilleteCon(ObjAsociado));
            clsBillete ObjEsperado = new clsBillete();
            Assert.AreEqual(true, Objeto.recuperarBilleteCon(10000, ref ObjEsperado));
            Assert.AreEqual(ObjEsperado, ObjAsociado);
        }

        #endregion

        #region testDisociadores
        [TestMethod]
        public void uTestDisociarPersona()
        {
            clsAlcancia Objeto = new clsAlcancia();
            Objeto.Generar();
            clsPersona ObjAsociado = null;
            Assert.AreEqual(true, Objeto.disociar(10030, ref ObjAsociado));
            Assert.AreEqual(10030, ObjAsociado.darOID());
        }
        [TestMethod]
        public void uTestDisociarMoneda()
        {
            clsAlcancia Objeto = new clsAlcancia();
            Objeto.Generar();
            clsMoneda ObjAsociado = null;
            Assert.AreEqual(true, Objeto.disociar(100, ref ObjAsociado));
            Assert.AreEqual(100, ObjAsociado.darDenominacion());
        }
        [TestMethod]
        public void uTestDisociarBillete()
        {
            clsAlcancia Objeto = new clsAlcancia();
            Objeto.Generar();
            clsBillete ObjAsociado = null;
            Assert.AreEqual(true, Objeto.disociarBilleteCon(1000, ref ObjAsociado));
            Assert.AreEqual(1000, ObjAsociado.darDenominacion());
        }
        #endregion

        #region testRecuperadores

        [TestMethod]
        public void uTestRecuperarPersona()
        {
            ObjAlcancia = new clsAlcancia();
            ObjPersona = new clsPersona();
            ObjAlcancia.Generar();
            Assert.AreNotEqual(false, ObjAlcancia.recuperarPersonaCon(10030, ref ObjPersona));
        }


        
        [TestMethod]
        public void uTestRecuperarMoneda()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(true, ObjAlcancia.recuperarMonedaCon(500, ref ObjMoneda));
        }

        
        [TestMethod]
        public void uTestRecuperarBillete()
        {
            ObjAlcancia = new clsAlcancia();
            ObjBillete = new clsBillete();
            ObjAlcancia.Generar();
            Assert.AreNotEqual(false, ObjAlcancia.recuperarBilleteCon(1000, ref ObjBillete));
            Assert.AreNotEqual(null, ObjAlcancia.recuperarBilleteCon(1000, ref ObjBillete));

        }
        #endregion

       

        
    }
}
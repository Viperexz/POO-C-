using appAlcancia.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace uTestAlcancia
{
    [TestClass]
    public class uTetstAlcancia
    {
        private clsAlcancia ObjAlcancia;
        private clsPersona ObjPersona;
        private clsMoneda ObjMoneda;
        private clsBillete ObjBillete;

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

        #region testRecuperadores

        [TestMethod]
        public void uTestRecuperarPersona()
        {
            ObjAlcancia = new clsAlcancia();
            ObjPersona = new clsPersona();
            ObjAlcancia.Generar();
            Assert.AreNotEqual(false, ObjAlcancia.recuperar(10030, ref ObjPersona));
        }


        
        [TestMethod]
        public void uTestRecuperarMoneda()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(true, ObjAlcancia.recuperar(500, ref ObjMoneda));
        }

        
        [TestMethod]
        public void uTestRecuperarBillete()
        {
            ObjAlcancia = new clsAlcancia();
            ObjBillete = new clsBillete();
            ObjAlcancia.Generar();
            Assert.AreNotEqual(false, ObjAlcancia.recuperar(1000, ref ObjBillete));
            Assert.AreNotEqual(null, ObjAlcancia.recuperar(1000, ref ObjBillete));

        }
        #endregion

        #region testAsociar
        [TestMethod]

        public void uTestAsociarPersona()
        {
            clsAlcancia Objeto = new clsAlcancia();
            Objeto.Generar();
            clsPersona ObjAsociado = new clsPersona(10031,"Oscar");
            Assert.AreEqual(true, Objeto.asociar(ObjAsociado));
            clsPersona ObjEsperado = new clsPersona();
            Assert.AreEqual(true, Objeto.recuperar(10031, ref ObjEsperado));
            Assert.AreEqual(ObjEsperado, ObjAsociado);
        }

        [TestMethod]
        public void uTestAsociarMoneda()
        {
            clsAlcancia Objeto = new clsAlcancia();
            Objeto.Generar();
            clsMoneda ObjAsociado = new clsMoneda(200,2012);
            Assert.AreEqual(true, Objeto.asociar(ObjAsociado));
            clsMoneda ObjEsperado = new clsMoneda();
            Assert.AreEqual(true, Objeto.recuperar(200, ref ObjEsperado));
            Assert.AreEqual(ObjEsperado, ObjAsociado);
        }
        [TestMethod]
        public void uTestAsociarBillete()
        {
            clsAlcancia Objeto = new clsAlcancia();
            Objeto.Generar();
            clsBillete ObjAsociado = new clsBillete(10000,2000,05,12,"10031");
            Assert.AreEqual(true, Objeto.asociar(ObjAsociado));
            clsBillete ObjEsperado = new clsBillete();
            Assert.AreEqual(true, Objeto.recuperar(10000, ref ObjEsperado));
            Assert.AreEqual(ObjEsperado, ObjAsociado);
        }

        #endregion

        
    }
}
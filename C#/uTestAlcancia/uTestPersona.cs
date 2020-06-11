using appAlcancia.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace uTestAlcancia
{
    [TestClass]
    public class uTetstPersona
    {

        //Objetos
        private clsPersona ObjPersona;
        private clsBillete ObjBillete;
        private clsMoneda ObjMoneda;

        #region testAccesores
        [TestMethod]
        public void uTestdarOID()
        {
            ObjPersona = new clsPersona();
            Assert.AreEqual(-1, ObjPersona.darOID());
        }
        [TestMethod]
        public void uTestdarNombre()
        {
            ObjPersona = new clsPersona();
            Assert.AreNotEqual(null, ObjPersona.darNombre());
        }
        #endregion

        #region testMutadores
        [TestMethod]
        public void uTestPonerNombre()
        {
            ObjPersona = new clsPersona();
            ObjPersona.poner("Luis");
            Assert.AreEqual("Luis", ObjPersona.darNombre());
        }
        /*
         [TestMethod]
         public void uTestPonerAlcancia()
         {
            ObjPersona = new clsPersona();
        //  ObjPersona.poner();
            Assert.AreNotEqual(null, ObjPersona.darAlcancia());
         }*/
        [TestMethod]
        public void uTestConstructorPrm()
        {
            ObjPersona = new clsPersona(1000,"Luis");
            Assert.AreEqual(1000, ObjPersona.darOID());
            Assert.AreEqual("Luis", ObjPersona.darNombre());
        }
        #endregion

      
        #region testRecuperadores
        [TestMethod]
        public void uTestRecuperarMoneda()
        {
            
            ObjPersona = new clsPersona();
            ObjMoneda = new clsMoneda();
            ObjPersona.Generar();
            Assert.AreNotEqual(false, ObjPersona.recuperador(500, ref ObjMoneda));

        }

        [TestMethod]
        public void uTestRecuperarBillete()
        {
            
            ObjPersona = new clsPersona();
            ObjBillete = new clsBillete();
            ObjPersona.Generar();
            Assert.AreNotEqual(false, ObjPersona.recuperador(1000, ref ObjBillete));

        }
        #endregion

        #region testAsociar
      
        [TestMethod]
        public void uTestAsociarMoneda()
        {
            clsPersona Objeto = new clsPersona();
            Objeto.Generar();
            clsMoneda ObjAsociado = new clsMoneda(200, 2012);
            Assert.AreEqual(true, Objeto.asociar(ObjAsociado));
            clsMoneda ObjEsperado = new clsMoneda();
            Assert.AreEqual(true, Objeto.recuperador(200, ref ObjEsperado));
            Assert.AreEqual(ObjEsperado, ObjAsociado);
        }
        [TestMethod]
        public void uTestAsociarBillete()
        {
            clsPersona Objeto = new clsPersona();
            Objeto.Generar();
            clsBillete ObjAsociado = new clsBillete(10000, 2000, 05, 12, "10031");
            Assert.AreEqual(true, Objeto.asociar(ObjAsociado));
            clsBillete ObjEsperado = new clsBillete();
            Assert.AreEqual(true, Objeto.recuperador(10000, ref ObjEsperado));
            Assert.AreEqual(ObjEsperado, ObjAsociado);
        }

        #endregion

    }
}
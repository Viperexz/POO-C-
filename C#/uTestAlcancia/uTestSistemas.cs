using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;
namespace uTestAlcancia
{
    [TestClass]
    public class uTestSistemas
    {
        #region Obj de prueba
        clsSistema ObjSistema;
        clsPersona ObjPersona;
        clsMoneda ObjMoneda;
        clsBillete ObjBillete;
        #endregion

        #region testAcesores
        [TestMethod]
        public void uTestdarAlcancia()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreNotEqual(null, ObjSistema.darAlcancia());
        }

        [TestMethod]
        public void uTestRecuperarPersona()
        {
            ObjSistema = new clsSistema();
            ObjPersona = new clsPersona();
            ObjSistema.Generar();
            Assert.AreNotEqual(false, ObjSistema.recuperador(10031, ref ObjPersona));
        }
        #endregion

        #region testRecuperadores
        [TestMethod]
        public void uTestRecuperarMoneda()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(true, ObjSistema.recuperador(500, ref ObjMoneda));
        }


        [TestMethod]
        public void uTestRecuperarBillete()
        {
            ObjSistema = new clsSistema();
            ObjBillete = new clsBillete();
            ObjSistema.Generar();
            Assert.AreNotEqual(false, ObjSistema.recuperador(1000, ref ObjBillete));
            Assert.AreNotEqual(null, ObjSistema.recuperador(1000, ref ObjBillete));

        }
        #endregion

        #region testAsociadores

        [TestMethod]
        public void uTestAsociarNuevaPersona()
        {
            clsSistema Objeto = new clsSistema();
            Objeto.Generar();
            Assert.AreEqual(true, Objeto.asociar(new clsPersona()));
            Assert.AreEqual(true, Objeto.recuperador(-1, ref ObjPersona));
        }


        [TestMethod]
        public void uTestAsociarPersonaExistente()
        {
            clsSistema Objeto = new clsSistema();
            Objeto.Generar();
            Assert.AreEqual(false, Objeto.asociar(new clsPersona(10031,"Pablo")));
            Assert.AreEqual(true, Objeto.recuperador(10031, ref ObjPersona));
            Assert.AreNotEqual("Pablo", ObjPersona.darNombre());
        }


        [TestMethod]
        public void uTestAsociarMoneda()
        {
            clsSistema Objeto = new clsSistema();
            Objeto.Generar();
            clsMoneda ObjAsociado = new clsMoneda(200, 2012);
            Assert.AreEqual(true, Objeto.asociar(ObjAsociado));
            clsMoneda ObjEsperado = new clsMoneda();
            Assert.AreEqual(true, Objeto.recuperador(200, ref ObjEsperado));
            Assert.AreEqual(ObjEsperado, ObjAsociado);
        }
        [TestMethod]
        public void uTestAsociarBilleteNuevo()
        {
            clsSistema Objeto = new clsSistema();
            Objeto.Generar();
            Assert.AreEqual(true, Objeto.asociar(new clsBillete()));
            Assert.AreEqual(true, Objeto.recuperador(-1, ref ObjBillete));
        }

        #endregion

        #region testDisociar
        [TestMethod]
        public void uTestDisociarMonedasDenominacion()
        {
            clsSistema Objeto = new clsSistema();
            Objeto.Generar();
            clsMoneda ObjAsociado = null;
            Assert.AreEqual(true, Objeto.disociar(100, ref ObjAsociado));
            Assert.AreEqual(100, ObjAsociado.darDenominacion());
        }
        #endregion

        #region testCRUD
        #region testRegistrador
        [TestMethod]
        public void utestRegistrarAlcancia()
        {
            ObjSistema = new clsSistema();
            ObjSistema.registrarAlcancia(400, 100);
            Assert.AreEqual(true, ObjSistema.registrarAlcancia(400, 100));
            Assert.AreEqual(400, ObjSistema.darAlcancia().darCapacidadMoneda());
            Assert.AreEqual(100, ObjSistema.darAlcancia().darCapacidadBillete());
        }
        [TestMethod]
        public void utestRegistrarPersonaConOID()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.registrarPersona(0031, "Javier"));
            Assert.AreEqual(true, ObjSistema.recuperador(0031,ref ObjPersona));
        }

        [TestMethod]
        public void utestRegistrarMoneda()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.registrarMoneda(100, 1999));
            Assert.AreEqual(true, ObjSistema.recuperador(100, ref ObjMoneda));
        }

        [TestMethod]
        public void utestRegistrarBillete()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.registrarBillete(10000,2000,05,06,"103194"));
            Assert.AreEqual(true, ObjSistema.recuperador("103194",ref ObjBillete));
        }

        #endregion
        #endregion



    }

}

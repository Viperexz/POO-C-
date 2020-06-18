using System.Collections.Generic;
using System.Security.Policy;

namespace appAlcancia.Dominio
{
    public class clsPersona
    {
        #region Atributos

        #region Propios
        /// <summary>
        /// Atributo identificador unico (Patron OID).
        /// </summar
        private int atrOID = -1;
        /// <summary>
        /// Nombre de la persona.
        /// </summary>
        private string atrNombre = "n.n";
        #endregion

        #region Asociativos
        /// <summary>
        /// Asocia la persona a la clase monedas.
        /// </summary>
        private List<clsMoneda> atrMonedas = null;

        /// <summary>
        /// Asocia la persona a la clase billetes.
        /// </summary>
        private List<clsBillete> atrBilletes = null;

        /// <summary>
        /// Asocia la persona a la clase alcancia.
        /// </summary>
        private clsAlcancia atrAlcancias = null;
        #endregion

        #region auxObj
        /// <summary>
        /// Atributo Auxiliar de la clase Moneda.
        /// </summary
        private clsMoneda auxObjMoneda = null;
        /// <summary>
        /// Atributo Auxiliar de la clase Billete.
        /// </summary
        private clsBillete auxObjBillete = null;
        /// <summary>
        /// Atributo Auxiliar de la clase Moneda.
        /// </summary
        private clsAlcancia auxObjAlcancia = null;

        #endregion
        #endregion
        //=================================================
        #region Metodos

        #region Constructor
        /// <summary>
        /// Crea y devuelve una nueva instancia (objeto de Persona - No parametrizado).
        /// </summary>
        public clsPersona()
        { 
            
        }

        /// <summary>
        /// Crea y devuelve una nueva instancia (objeto de Persona).
        /// </summary>
        /// <param name="prmOID">Identificador unico (Patron OID).</param>
        /// <param name="prmNombre">Año de Emisión.</param>
        public clsPersona(int prmOID,string prmNombre)
        {
            atrOID = prmOID;
            atrNombre = prmNombre;
        }
        #endregion

        #region Utilitario
        public void Generar()
        {
            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda(100, 1995));
            atrMonedas.Add(new clsMoneda(500, 2000));

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete(1000, 1990, 02, 05, "20000"));
            atrBilletes.Add(new clsBillete(2000, 2010, 06, 12, "562350"));
        }
        #endregion

        #region Acessores
        /// <summary>
        /// Devuelve el OID de la persona.
        /// </summary>
        /// <returns>Valor Entero</returns>
        public int darOID() 
        {
            return atrOID; 
        }
        /// <summary>
        /// Devuelve el Nombre de la persona.
        /// </summary>
        /// <returns>Valor cadena de caracteres</returns>
        public string darNombre() 
        {
            return atrNombre; 
        }
        /// <summary>
        /// Devuelve la alcancia en la que ahorra la persona.
        /// </summary>
        /// <returns>Valor clase alcancia</returns>
        public clsAlcancia darAlcancia()
        {
            return atrAlcancias;
        }

        /// <summary>
        /// Devuelve una copia de la coleccion de la clase monedas.
        /// </summary>
        /// <returns>Objeto alcancia</returns>
        public List<clsMoneda> darMonedas()
        {
            return atrMonedas;
        }

        /// <summary>
        /// Devuelve una copia de la coleccion de la clase monedas.
        /// </summary>
        /// <returns>Objeto alcancia</returns>
        public List<clsBillete> darBillete()
        {
            return atrBilletes;
        }


        #endregion

        #region Mutadores
        /// <summary>
        /// Modifica el nombre de la persona.
        /// </summary>
        /// <param name="prmNombre">Nombre de la persona.</param>
        public bool poner(string prmNombre)
        {
            atrNombre = prmNombre;
            return true;
        }

        /// <summary>
        /// Modfica la alcancia.
        /// </summary>
        /// <param name="prmObjeto">Objeto de la clase Alcancia.</param>
        public void poner(clsAlcancia prmObjeto)
        {
            atrAlcancias = prmObjeto;
        }

        #endregion

        #region Asociadores
        /// <summary>
        /// Asocia la clase moneda.
        /// </summary>
        /// <param name="prmObjeto">Objeto de la clase Moneda.</param>
        /// <returns>Valor Boleano</returns>
        public bool asociar(clsMoneda prmObjeto)
        {
            atrMonedas.Add(prmObjeto);
            return true;
        }
        /// <summary>
        /// Asocia la clase billete.
        /// </summary>
        /// <param name="prmOID">Objeto de la clase billete</param>
        /// <returns>Valor Boleano</returns>
        public bool asociar(clsBillete prmObjeto)
        {
            if (recuperarBilleteCon(prmObjeto.darDenominacion()) == null)
            {
                atrBilletes.Add(prmObjeto);
                return true;
            }
            return false;
        }
        #endregion

        #region Disociadores
        public clsAlcancia disociarAlcancia()
        {
            auxObjAlcancia = atrAlcancias;
            if(auxObjAlcancia != null)
            {
                atrAlcancias.disociarAhorradorCon(this);
                atrAlcancias = null;
            }
            return auxObjAlcancia;
        }

        /// <summary>
        /// Disocia la clase personas de la clase Moneda. 
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda.</param>
        /// <param name="prmObjeto">Objeto de la clase moneda.</param>
        /// <returns>Valor Boleano</returns>
        public clsMoneda disociarMonedaCon(int prmDenominacion)
        {
            auxObjMoneda = recuperarMonedaCon(prmDenominacion);
            atrMonedas.Remove(auxObjMoneda);
            return auxObjMoneda;
        }
        /// <summary>
        /// Disocia la clase persona de la clase Billete.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion del billete.</param>
        /// <param name="prmObjeto">Objeto de la clase billete.</param>
        /// <returns>Valor Boleano</returns>
        public clsBillete disociarBilleteCon(int prmDenominacion)
        {
            auxObjBillete = recuperarBilleteCon(prmDenominacion);
            atrBilletes.Remove(auxObjBillete);
            return auxObjBillete;
        }
        #endregion

        #region Recuperadores
        public clsMoneda recuperarMonedaCon(int prmDenominacion)
        {
            for (int varIndice = 0; varIndice < atrMonedas.Count; varIndice++)
                if (atrMonedas[varIndice].darDenominacion() == prmDenominacion)
                    return atrMonedas[varIndice];
            return null;
        }
        /// <summary>
        /// Recupera un onjeto de la clase Billete usando la Denominacion.
        /// </summary>
        /// <param name="prmOID">Valor entero de capacidad monedas.</param>
        /// <param name="prmObjeto">Valor entero de capacidad billetes.</param>
        /// <returns>Valor booleano</returns
        public clsBillete recuperarBilleteCon(int prmDenominacion)
        {
            for (int varIndice = 0; varIndice < atrBilletes.Count; varIndice++)
                if (atrBilletes[varIndice].darDenominacion() == prmDenominacion)
                    return atrBilletes[varIndice];
            return null;
        }
        #endregion

        public clsPersona destruir()
        {
            disociarAlcancia();
            disociarBilleteCon();
            disociarMonedasCon();
            return this;

        }

        #endregion
    }
}

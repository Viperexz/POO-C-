using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsAlcancia
    {
        #region Atributos

        #region Propio
        /// <summary>
        /// Limite de monedas en la alcancia.
        /// </summary>
        private int atrCapacidadMonedas = -1;

        /// <summary>
        /// Limite de billetes en la alcancia.
        /// </summary>
        private int atrCapacidadBilletes = -1;

        #endregion

        #region Asociativos
        /// <summary>
        /// 
        /// </summary>
        private List<clsPersona> atrAhorradores = null;

        /// <summary>
        /// 
        /// </summary>
        private List<clsMoneda> atrMonedas = null;

        /// <summary>
        /// 
        /// </summary?
        private List<clsBillete> atrBilletes = null;

        #endregion

        #region ObjAux
        /// <summary>
        /// Atributo Auxiliar de la clase Persona.
        /// </summary
        private clsPersona auxObjAhorrador = null;
        /// <summary>
        /// Atributo Auxiliar de la clase Moneda.
        /// </summary
        private clsMoneda auxObjMoneda = null;
        /// <summary>
        /// Atributo Auxiliar de la clase Billete.
        /// </summary
        private clsBillete auxObjBillete = null;
        #endregion

        #endregion
        //=================================================
        #region Metodos

        #region Constructor
        /// <summary>
        /// Crea y devuelve una nueva instancia (objeto de Alcancia - No parametrizado).
        /// </summary>
        public clsAlcancia() 
        { 

        }

        /// <summary>
        /// Crea y devuelve una nueva instancia (objeto de Alcancia).
        /// </summary>
        /// <param name="prmCapacidadMonedas">Valor entero de capacidad monedas.</param>
        /// <param name="prmCapacidadBilletes">Valor entero de capacidad billetes.</param>
        public clsAlcancia(int prmCapacidadMonedas, int prmCapacidadBilletes) 
        {
            atrCapacidadMonedas = prmCapacidadMonedas;
            atrCapacidadBilletes = prmCapacidadBilletes;
        }
        #endregion

        #region Acessores
        /// <summary>
        /// Devuelve la capacidad de la alcancia para monedas.
        /// </summary>
        /// <returns>Valor Entero</returns
        public int darCapacidadMoneda() {
        
            return atrCapacidadMonedas; 
        }
        /// <summary>
        /// Devuelve la capacidad de la alcancia para billetes.
        /// </summary>
        /// <returns>Valor Entero</returns
        public int darCapacidadBillete()
        {
           
            return atrCapacidadBilletes;
        }
        #endregion

        #region Utilitario
        public void Generar()
        {
            atrAhorradores = new List<clsPersona>();
            atrAhorradores.Add(new clsPersona(10030, "Luis"));

            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda(100, 1995));
            atrMonedas.Add(new clsMoneda(500, 2000));

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete(1000, 1990, 02, 05, "20000"));
            atrBilletes.Add(new clsBillete(2000, 2010, 06, 12, "562350"));
        }
        #endregion

        #region Asociadores
        /// <summary>
        /// Asocia un objeto de la alcancia con persona.
        /// <param name="prmObjeto">Objeto de la clase.</param>
        /// </summary>
        /// <returns>Valor booleano true si fue asociado</returns
        public bool asociarAhorradorCon(clsPersona prmObjeto)
        {
            if (recuperarAhorradorCon(prmObjeto.darOID()) == null)
            {
                atrAhorradores.Add(prmObjeto);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Asocia un objeto de la alcancia con Moneda.
        /// <param name="prmObjeto">Objeto de la clase.</param>
        /// </summary>
        /// <returns>Valor booleano true si fue asociado</returns
        public bool asociarMonedaCon(clsMoneda prmObjeto)
        {
            atrMonedas.Add(prmObjeto);
            return true;
        }
        /// <summary>
        /// Asocia un objeto de la alcancia con Billete.
        /// <param name="prmObjeto">Objeto de la clase.</param>
        /// </summary>
        /// <returns>Valor booleano true si fue asociado</returns
        public bool asociarBilleteCon(clsBillete prmObjeto)
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
        /// <summary>
        /// Disocia un objeto de la alcancia con Persona usando el OID.
        /// </summary>
        /// <param name="prmOID">Valor entero de capacidad monedas.</param>
        /// <returns>Obj disociado - en caso de no encontrar el obj retorna null</returns
        public clsPersona disociarAhorradorCon(int prmOID)
        {
            auxObjAhorrador = recuperarAhorradorCon(prmOID);
            atrAhorradores.Remove(auxObjAhorrador);
            return auxObjAhorrador;
        }
        /// <summary>
        /// Disocia un objeto de la alcancia con Moneda usando la denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Valor entero de capacidad monedas.</param>
        /// <returns>Obj disociado - en caso de no encontrar el obj retorna null</returns
        public clsMoneda disociarMonedaCon(int prmDenominacion)
        {
            auxObjMoneda = recuperarMonedaCon(prmDenominacion);
            atrMonedas.Remove(auxObjMoneda);
            return auxObjMoneda;
        }
        /// <summary>
        /// Disocia un objeto de la alcancia con Billete usando la denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Valor entero de capacidad monedas.</param>
        /// <returns>Valor booleano</returns
        public clsBillete disociarBilleteCon(int prmDenominacion)
        {
            auxObjBillete = recuperarBilleteCon(prmDenominacion);
            atrBilletes.Remove(auxObjBillete);
            return auxObjBillete;
        }
        #endregion

        #region Recuperadores

        /// <summary>
        /// Recupera un onjeto de la clase persona usando el OID.
        /// </summary>
        /// <param name="prmOID">Valor entero de capacidad monedas.</param>
        /// <param name="prmObjeto">Valor entero de capacidad billetes.</param>
        /// <returns>Valor booleano</returns
        public clsPersona recuperarAhorradorCon(int prmOID)
        {
            for (int varIndice = 0; varIndice < atrAhorradores.Count; varIndice++)
                if (atrAhorradores[varIndice].darOID() == prmOID)
                    return atrAhorradores[varIndice];
            return null;
        }

        /// <summary>
        ///  Recupera un onjeto de la clase Moneda usando la Denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Valor entero de capacidad monedas.</param>
        /// <param name="prmObjeto">Valor entero de capacidad billetes.</param>
        /// <returns>Valor booleano</returns
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

        #endregion
    }
}

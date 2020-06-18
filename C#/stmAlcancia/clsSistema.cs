using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsSistema
    {

        #region Atributos

        #region Asociativos
        /// <summary>
        /// Atributo asociativo de la clase alcancia.
        /// </summary
        private clsAlcancia atrAlcancia = null;
        /// <summary>
        /// Atributo asociativo de la clase personas.
        /// </summary
        private List<clsPersona> atrAhorradores =  new List<clsPersona>();
        /// <summary>
        /// Atributo asociativo de la clase Moneda.
        /// </summary
        private List<clsMoneda> atrMonedas = new List<clsMoneda>();
        /// <summary>
        /// Atributo asociativo de la clase Billete.
        /// </summary
        private List<clsBillete> atrBilletes = new List<clsBillete>();

        #endregion


        #region ObjAux
        /// <summary>
        /// Atributo Auxiliar de la clase Persona.
        /// </summary
        private clsPersona auxObjAhorrador = null;
        /// <summary>
        /// Atributo Auxiliar de la clase Alcancia.
        /// </summary
        private clsAlcancia auxObjAlcancia = null;
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

        #region Generar

        public void Generar()
        {
            atrAlcancia = new clsAlcancia();

            atrAhorradores = new List<clsPersona>();
            atrAhorradores.Add(new clsPersona(5, "Luis"));
            atrAhorradores.Add(new clsPersona(10, "Andres"));

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
        /// Devuelve el objeto de la clase alcancia.
        /// </summary>
        /// <returns>Objeto alcancia</returns>
        public clsAlcancia darAlcancia()
        {
            return atrAlcancia;
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
       

        /// <summary>
        /// Devuelve una copia de la coleccion de la clase monedas.
        /// </summary>
        /// <returns>Objeto alcancia</returns>
        public List<clsPersona> darAhorradores()
        {
            return atrAhorradores;
        }
       

        #endregion

       

        #region Mutadores
        /// <summary>
        /// Modifica el objeto alcancia.
        /// </summary>
        /// <returns>Valor boleano(true/false)</returns>
        public bool poner(clsAlcancia prmObjeto)
        {
            atrAlcancia = prmObjeto;
            return true;
        }

        #endregion

        #region Asociadores
        /// <summary>
        /// Asocia la clase persona.
        /// </summary>
        /// <param name="prmObjeto">Objeto de la clase persona.</param>
        /// <returns>Valor Boleano</returns>
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
        /// Asocia la clase moneda.
        /// </summary>
        /// <param name="prmObjeto">Objeto de la clase Moneda.</param>
        /// <returns>Valor Boleano</returns>
        public bool asociarMonedaCon(clsMoneda prmObjeto)
        {
                atrMonedas.Add(prmObjeto);
                return true;
        }

        /// <summary>
        /// Asocia la clase billete.
        /// </summary>
        /// <param name="prmObjeto">Objeto de la clase Billete.</param>
        /// <returns>Valor Boleano</returns>
        public bool asociarBilleteCon(clsBillete prmObjeto)
        {
            if (recuperarBilleteCon(prmObjeto.darDenominacion()) == null)
            {
                atrBilletes.Add(prmObjeto);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Asocia la clase Alcancia.
        /// </summary>
        /// <param name="prmObjeto">Objeto de la clase Alcancia.</param>
        public bool asociar(clsAlcancia prmObjeto)
        {
            return false;
        }

        #endregion

        #region Disociadores
        
        /// <summary>
        /// Disocia la clase personas de la clase Moneda. 
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda.</param>
        /// <param name="prmObjeto">Objeto de la clase moneda.</param>
        /// <returns>Valor Boleano</returns>
        public clsPersona disociarAhorradorCon(int prmOID)
        {
            auxObjAhorrador = recuperarAhorradorCon(prmOID);
            atrAhorradores.Remove(auxObjAhorrador);
            return auxObjAhorrador;
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
        /// Disocia la clase personas de la clase Moneda. 
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda.</param>
        /// <param name="prmObjeto">Objeto de la clase moneda.</param>
        /// <returns>Valor Boleano</returns>
        public clsBillete disociarBilleteCon(int prmDenominacion)
        {
            auxObjBillete = recuperarBilleteCon(prmDenominacion);
            atrBilletes.Remove(auxObjBillete);
            return auxObjBillete;
        }

        /// <summary>
        /// Disocia la clase personas de la clase Moneda. 
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda.</param>
        /// <param name="prmObjeto">Objeto de la clase moneda.</param>
        /// <returns>Valor Boleano</returns>
        public clsBillete disociarBilleteCon(string prmSerial)
        {
            auxObjBillete = recuperarBilleteCon(prmSerial);
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

        /// <summary>
        /// Recupera el objeto billete usando la denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion del billete.</param>
        /// <param name="prmObjeto">Objeto de la clase Billete.</param>
        /// <returns>Valor Boleano</returns>
        public clsBillete recuperarBilleteCon(string prmSerial)
        {
            for (int varIndice = 0; varIndice < atrBilletes.Count; varIndice++)
                if (atrBilletes[varIndice].darSerial() == prmSerial)
                    return atrBilletes[varIndice];
            return null;
        }
        #endregion

        #region CRUD

        #region Registrar

        /// <summary>
        /// Registra la alcancia.
        /// </summary>
        /// <param name="prmCapacidadMonedas">Capacidad de la alancia para las monedas.</param>
        /// <param name="prmCapacidadBilletes">Capacidad de la alancia para los billetes.</param>
        /// <returns>Valor Boleano</returns>
        public bool registrarAlcancia(int prmCapacidadMonedas, int prmCapacidadBilletes)
        {
             return poner(new clsAlcancia(prmCapacidadMonedas, prmCapacidadBilletes));
        }

        /// <summary>
        /// Registra la persona.
        /// </summary>
        /// <param name="prmOID">Capacidad de la alancia para las monedas.</param>
        /// <param name="prmNombre">Capacidad de la alancia para los billetes.</param>
        /// <returns>Valor Boleano</returns>
        public bool registrarPersona(int prmOID, string prmNombre)
        {
            return asociarAhorradorCon(new clsPersona(prmOID, prmNombre)); 
        }

        /// <summary>
        /// Registra la moneda.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda. </param>
        /// <param name="prmAno">Año de emision del la moneda.</param>
        /// <returns>Valor Boleano</returns>
        public bool registrarMoneda(int prmDenominacion, int prmAño)
        {
            return asociarMonedaCon(new clsMoneda(prmDenominacion,prmAño));
        }

        /// <summary>
        /// Registra el billete.
        /// </summary>
        /// <param name="prmSerial">Identificador unico del billete (Patron OID).</param>
        /// <param name="prmDenominacion">Denominacion del billete.</param>
        /// <param name="prmMes">Mes de emision.</param>
        /// <param name="prmDia">Dia de emision.</param>
        /// <returns>Valor Boleano</returns>
        public bool registrarBillete(int prmDenominacion, int prmAño, int prmMes, int prmDia, string prmSerial)
        {
            return asociarBilleteCon(new clsBillete(prmDenominacion,prmAño,prmMes,prmDia,prmSerial));
        }
        #endregion

        #region Actualizar

        /// <summary>
        /// Actualiza la persona.
        /// </summary>
        /// <param name="prmOID">Capacidad de la alancia para las monedas.</param>
        /// <param name="prmNombre">Capacidad de la alancia para los billetes.</param>
        /// <returns>Valor Boleano</returns>
        public bool actualizarPersona(int prmOID, string prmNombre)
        {
            if(recuperarAhorradorCon(prmOID).poner(prmNombre)) return true;

            return false;
        }

        #endregion

        #region Eliminar

        /// <summary>
        /// Elimina la persona usando el OID.
        /// </summary>
        /// <param name="prmOID">Capacidad de la alancia para las monedas.</param>
        /// <param name="prmObjeto">Objeto de la clase personas.</param>
        /// <returns>Valor Boleano</returns>
        public clsPersona eliminarPersona(int prmOID)
        {
            auxObjAhorrador = disociarAhorradorCon(prmOID);
            if (auxObjAhorrador != null)
                return auxObjAhorrador.destruir();

            return null;
        }

        /// <summary>
        /// Elimina la moneda usando la Denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda. </param>
        /// <param name="prmObjeto">Objeto de la clase.</param>
        /// <returns>Valor Boleano</returns
        public bool eliminarMoneda(int prmDenominacion)
        {
            return false;
        }

        /// <summary>
        /// Elimina el billete usando la Denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion del billete.</param>
        /// <param name="prmObjeto">Objeto de la clase.</param>
        /// <returns>Valor Boleano</returns>
        public bool eliminarBillete(int prmDenominacion)
        {
            return false;
        }
        /// <summary>
        /// Elimina la moneda usando la alcancia.
        /// </summary>
        /// <param name="prmObjeto">Objeto de la clase.</param>
        /// <returns>Valor Boleano</returns>
        public bool eliminarAlcancia(ref clsAlcancia prmObjeto)
        {
            return false;
        }
        #endregion


        #endregion

        #endregion
    }
}

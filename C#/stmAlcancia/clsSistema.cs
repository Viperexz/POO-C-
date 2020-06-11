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
        private List<clsBillete> atrBillete = new List<clsBillete>();

        #endregion

        #endregion
        //=================================================
        #region Metodos

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
            return atrBillete;
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

            atrBillete = new List<clsBillete>();
            atrBillete.Add(new clsBillete(1000, 1990, 02, 05, "20000"));
            atrBillete.Add(new clsBillete(2000, 2010, 06, 12, "562350"));
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
        public bool asociar(clsPersona prmObjeto)
        {
            clsPersona varObjExistente = new clsPersona();
            if (recuperar(prmObjeto.darOID(), ref varObjExistente) == false)
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
        public bool asociar(clsMoneda prmObjeto)
        {
                atrMonedas.Add(prmObjeto);
                return true;
        }

        /// <summary>
        /// Asocia la clase billete.
        /// </summary>
        /// <param name="prmObjeto">Objeto de la clase Billete.</param>
        /// <returns>Valor Boleano</returns>
        public bool asociar(clsBillete prmObjeto)
        {
            clsBillete varObjExistente = new clsBillete();
            if (recuperar(prmObjeto.darSerial(), ref varObjExistente) == false)
            {
                atrBillete.Add(prmObjeto);
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
        public bool disociar(int prmOID, ref clsPersona prmObjeto)
        {
            clsPersona varObjeto = null;
            if (recuperar(prmOID, ref varObjeto) == true)
            {
                prmObjeto = varObjeto;
                return atrAhorradores.Remove(prmObjeto);
            }
            prmObjeto = null;
            return false;
        }

        /// <summary>
        /// Disocia la clase personas de la clase Moneda. 
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda.</param>
        /// <param name="prmObjeto">Objeto de la clase moneda.</param>
        /// <returns>Valor Boleano</returns>
        public bool disociar(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            clsMoneda varObjeto = null;
            if (recuperar(prmDenominacion, ref varObjeto) == true)
            {
                prmObjeto = varObjeto;
                return atrMonedas.Remove(prmObjeto);
            }
            prmObjeto = null;
            return false;

   
        }

        /// <summary>
        /// Disocia la clase personas de la clase Moneda. 
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda.</param>
        /// <param name="prmObjeto">Objeto de la clase moneda.</param>
        /// <returns>Valor Boleano</returns>
        public bool disociar(int prmDenominacion, ref clsBillete prmObjeto)
        {
            clsBillete varObjeto = null;
            if (recuperar(prmDenominacion, ref varObjeto) == true)
            {
                prmObjeto = varObjeto;
                return atrBillete.Remove(prmObjeto);
            }
            prmObjeto = null;
            return false;

        }
        #endregion

        #region Recuperadores
        /// <summary>
        /// Recupera el objeto Persona usando el OID.
        /// </summary>
        /// <param name="prmOID">Identificador (Patron OID).</param>
        /// <param name="prmObjeto">Objeto de la clase Moneda.</param>
        /// <returns>Valor Boleano</returns>
        public bool recuperar(int prmOID, ref clsPersona prmObjeto)
        {
            foreach (clsPersona varObjeto in atrAhorradores)
            {
                if (varObjeto.darOID() == prmOID)
                {
                    prmObjeto = varObjeto;
                    return true;
                }

            }
            return false;
        }

        public clsPersona recuperarPersona(int prmOID)
        {
            foreach (clsPersona varObjeto in atrAhorradores)
            {
                if (varObjeto.darOID() == prmOID)
                {
                    return varObjeto;
                }
            }
            return null;
        }

        /// <summary>
        /// Recupera el objeto moneda usando la denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda.</param>
        /// <param name="prmObjeto">Objeto de la clase Moneda.</param>
        /// <returns>Valor Boleano</returns>
        public bool recuperar(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            foreach (clsMoneda varObjeto in atrMonedas)
            {
                if (varObjeto.darDenominacion() == prmDenominacion)
                {
                    prmObjeto = varObjeto;
                    return true;
                }

            }
            return false;
        }

        /// <summary>
        /// Recupera el objeto billete usando la denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion del billete.</param>
        /// <param name="prmObjeto">Objeto de la clase Billete.</param>
        /// <returns>Valor Boleano</returns>
        public bool recuperar(string prmSerial, ref clsBillete prmObjeto)
        {
            foreach (clsBillete varObjeto in atrBillete)
            {
                if (varObjeto.darSerial() == prmSerial)
                {
                    prmObjeto = varObjeto;
                    return true;
                }

            }
            return false;
        }

        /// <summary>
        /// Recupera el objeto billete usando la denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion del billete.</param>
        /// <param name="prmObjeto">Objeto de la clase Billete.</param>
        /// <returns>Valor Boleano</returns>
        public bool recuperar(int prmDenominacion, ref clsBillete prmObjeto)
        {
            foreach (clsBillete varObjeto in atrBillete)
            {
                if (varObjeto.darDenominacion() == prmDenominacion)
                {
                    prmObjeto = varObjeto;
                    return true;
                }

            }
            return false;
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
            return asociar(new clsPersona(prmOID, prmNombre)); 
        }

        /// <summary>
        /// Registra la moneda.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda. </param>
        /// <param name="prmAno">Año de emision del la moneda.</param>
        /// <returns>Valor Boleano</returns>
        public bool registrarMoneda(int prmDenominacion, int prmAño)
        {
            return asociar(new clsMoneda(prmDenominacion,prmAño));
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
            return asociar(new clsBillete(prmDenominacion,prmAño,prmMes,prmDia,prmSerial));
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
            if(recuperarPersona(prmOID).poner(prmNombre)) return true;

            return false;
        }

        /// <summary>
        /// Actualiza la moneda.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda. </param>
        /// <param name="prmAno">Año de emision del la moneda.</param>
        /// <returns>Valor Boleano</returns>
        public bool actualizaMoneda(int prmDenominacion, int prmAno)
        {
            return false;
        }

        /// <summary>
        /// Actualiza el billete.
        /// </summary>
        /// <param name="prmSerial">Identificador unico del billete (Patron OID).</param>
        /// <param name="prmDenominacion">Denominacion del billete.</param>
        /// <param name="prmMes">Mes de emision.</param>
        /// <param name="prmDia">Dia de emision.</param>
        /// <returns>Valor Boleano</returns>
        public bool actualizarBillete(string prmSerial, int prmDenominacion, int prmMes, int prmDia)
        {
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
        public bool eliminarPersona(int prmOID, ref clsPersona prmObjeto)
        {
            return false;
        }

        /// <summary>
        /// Elimina la moneda usando la Denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda. </param>
        /// <param name="prmObjeto">Objeto de la clase.</param>
        /// <returns>Valor Boleano</returns
        public bool eliminarMoneda(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            return false;
        }

        /// <summary>
        /// Elimina el billete usando la Denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion del billete.</param>
        /// <param name="prmObjeto">Objeto de la clase.</param>
        /// <returns>Valor Boleano</returns>
        public bool eliminarBillete(int prmDenominacion, ref clsBillete prmObjeto)
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

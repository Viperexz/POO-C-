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
        private List<clsMoneda> atrMoneda = null;

        /// <summary>
        /// 
        /// </summary?
        private List<clsBillete> atrBillete = null;

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

        #region Generar
        public void Generar()
        {
            atrAhorradores = new List<clsPersona>();
            atrAhorradores.Add(new clsPersona(10030, "Luis"));

            atrMoneda = new List<clsMoneda>();
            atrMoneda.Add(new clsMoneda(100, 1995));
            atrMoneda.Add(new clsMoneda(500, 2000));

            atrBillete = new List<clsBillete>();
            atrBillete.Add(new clsBillete(1000, 1990, 02, 05, "20000"));
            atrBillete.Add(new clsBillete(2000, 2010, 06, 12, "562350"));
        }
        #endregion

        #region Asociadores
        /// <summary>
        /// Asocia un objeto de la alcancia con persona.
        /// <param name="prmObjeto">Objeto de la clase.</param>
        /// </summary>
        /// <returns>Valor booleano</returns
        public bool asociar(clsPersona prmObjeto)
        {
           atrAhorradores.Add(prmObjeto);
            return true;
        }
        /// <summary>
        /// Asocia un objeto de la alcancia con Moneda.
        /// <param name="prmObjeto">Objeto de la clase.</param>
        /// </summary>
        /// <returns>Valor booleano</returns
        public bool asociar(clsMoneda prmObjeto)
        {
            atrMoneda.Add(prmObjeto);
            return true;
        }
        /// <summary>
        /// Asocia un objeto de la alcancia con Billete.
        /// <param name="prmObjeto">Objeto de la clase.</param>
        /// </summary>
        /// <returns>Valor booleano</returns
        public bool asociar(clsBillete prmObjeto)
        {
            atrBillete.Add(prmObjeto);
            return true;
        }
        #endregion

        #region Disociadores
        /// <summary>
        /// Disocia un objeto de la alcancia con Persona usando el OID.
        /// </summary>
        /// <param name="prmOID">Valor entero de capacidad monedas.</param>
        /// <param name="prmObjeto">Valor entero de capacidad billetes.</param>
        /// <returns>Valor booleano</returns
        public bool disociar(int prmOID,ref clsPersona prmObjeto)
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
        /// Disocia un objeto de la alcancia con Moneda usando la denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Valor entero de capacidad monedas.</param>
        /// <param name="prmObjeto">Valor entero de capacidad billetes.</param>
        /// <returns>Valor booleano</returns
        public bool disociar(int prmDenominacion,ref clsMoneda prmObjeto)
        {
            clsMoneda varObjeto = null;
            if (recuperar(prmDenominacion, ref varObjeto) == true)
            {
                prmObjeto = varObjeto;
                return atrMoneda.Remove(prmObjeto);
            }
            prmObjeto = null;
            return false;
        }
        /// <summary>
        /// Disocia un objeto de la alcancia con Billete usando la denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Valor entero de capacidad monedas.</param>
        /// <param name="prmObjeto">Valor entero de capacidad billetes.</param>
        /// <returns>Valor booleano</returns
        public bool disociar(int prmDenominacion,ref clsBillete prmObjeto)
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
        /// Recupera un onjeto de la clase persona usando el OID.
        /// </summary>
        /// <param name="prmOID">Valor entero de capacidad monedas.</param>
        /// <param name="prmObjeto">Valor entero de capacidad billetes.</param>
        /// <returns>Valor booleano</returns
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

        /// <summary>
        ///  Recupera un onjeto de la clase Moneda usando la Denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Valor entero de capacidad monedas.</param>
        /// <param name="prmObjeto">Valor entero de capacidad billetes.</param>
        /// <returns>Valor booleano</returns
        public bool recuperar(int prmDenominacion,ref clsMoneda prmObjeto)
        {
            foreach (clsMoneda varObjeto in atrMoneda)
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
        /// Recupera un onjeto de la clase Billete usando la Denominacion.
        /// </summary>
        /// <param name="prmOID">Valor entero de capacidad monedas.</param>
        /// <param name="prmObjeto">Valor entero de capacidad billetes.</param>
        /// <returns>Valor booleano</returns
        public bool recuperar(int prmDenominacion,ref clsBillete prmObjeto)
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

        #endregion
    }
}

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
        private List<clsMoneda> atrMoneda = null;

        /// <summary>
        /// Asocia la persona a la clase billetes.
        /// </summary>
        private List<clsBillete> atrBillete = null;

        /// <summary>
        /// Asocia la persona a la clase alcancia.
        /// </summary>
        private clsAlcancia atrAlcancias = null;
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
       
        #region Acessores
        /// <summary>
        /// Devuelve el OID de la persona.
        /// </summary>
        /// <returns>Valor Entero</returns>
        public int darOID() 
        {
            //Todo -Implementar
            return atrOID; 
        }
        /// <summary>
        /// Devuelve el Nombre de la persona.
        /// </summary>
        /// <returns>Valor cadena de caracteres</returns>
        public string darNombre() 
        {
            //Todo -Implementar
            return atrNombre; 
        }
        /// <summary>
        /// Devuelve la alcancia en la que ahorra la persona.
        /// </summary>
        /// <returns>Valor clase alcancia</returns>
        public clsAlcancia darAlcancia()
        {
            //Todo -Implementar
            return atrAlcancias;
        }

        /// <summary>
        /// Devuelve una copia de la coleccion de la clase monedas.
        /// </summary>
        /// <returns>Objeto alcancia</returns>
        public List<clsMoneda> darMonedas()
        {
            return atrMoneda;
        }

        /// <summary>
        /// Devuelve una copia de la coleccion de la clase monedas.
        /// </summary>
        /// <returns>Objeto alcancia</returns>
        public List<clsBillete> darBillete()
        {
            return atrBillete;
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
            //Todo -Implementar
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
            atrMoneda.Add(prmObjeto);
            return true;
        }
        /// <summary>
        /// Asocia la clase billete.
        /// </summary>
        /// <param name="prmOID">Objeto de la clase billete</param>
        /// <returns>Valor Boleano</returns>
        public bool asociar(clsBillete prmObjeto)
        {
            atrBillete.Add(prmObjeto);
            return true;
        }
        #endregion

        #region Disociadores
        /// <summary>
        /// Disocia la clase personas de la clase Moneda. 
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda.</param>
        /// <param name="prmObjeto">Objeto de la clase moneda.</param>
        /// <returns>Valor Boleano</returns>
        private bool disociar(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            //Todo -Implementar
            return false;
        }
        /// <summary>
        /// Disocia la clase persona de la clase Billete.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion del billete.</param>
        /// <param name="prmObjeto">Objeto de la clase billete.</param>
        /// <returns>Valor Boleano</returns>
        private bool disociar(int prmDenominacion, ref clsBillete prmObjeto)
        {
            //Todo -Implementar
            return false;
        }
        #endregion

        #region Recuperadores
        /// <summary>
        /// Recupera el objeto moneda usando la denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda.</param>
        /// <param name="prmObjeto">Objeto de la clase Moneda.</param>
        /// <returns>Valor Boleano</returns>
        public bool recuperar(int prmDenominacion, ref clsMoneda prmObjeto)
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
        /// Recupera el objeto billete usando la denominacion.
        /// </summary>
        /// <param name="prmDenominacion">Denominacion de la moneda.</param>
        /// <param name="prmObjeto">Objeto de la clase Moneda.</param>
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


        public void Generar()
        {
            atrMoneda = new List<clsMoneda>();
            atrMoneda.Add(new clsMoneda(100,1995));
            atrMoneda.Add(new clsMoneda(500,2000));
            
            atrBillete = new List<clsBillete>();
            atrBillete.Add(new clsBillete(1000,1990,02,05,"20000"));
            atrBillete.Add(new clsBillete(2000, 2010,06,12,"562350"));
        }

        #endregion
    }
}

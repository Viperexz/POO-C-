﻿namespace appAlcancia.Dominio
{
    public class clsMoneda
    {
        #region Atributos

        #region Propios
        /// <summary>
        /// Donominacion de la moneda.
        /// </summary
        protected int atrDenominacion = -1;
        /// <summary>
        /// Año de emision de la moneda.
        /// </summary
        protected int atrAño = -1;
        #endregion

        #region Asociativos
        /// <summary>
        /// Atributo asociativo con la clase Persona.
        /// </summary
        protected clsPersona atrPropietario = null;
        /// <summary>
        /// Atributo asociativo con la clase Alcancia.
        /// </summary
        protected clsAlcancia atrAlcancia = null;
        #endregion

        #endregion
        //=================================================
        #region Metodos

        #region Constructor
        /// <summary>
        /// Crea y devuelve una nueva instancia (objeto de Moneda - No parametrizado).
        /// </summary>
        public clsMoneda() 
        { 

        }
        /// <summary>
        /// Crea y devuelve una nueva instancia (objeto de Moneda).
        /// </summary>
        /// <param name="prmDenominacion">Valor Monetario.</param>
        /// <param name="prmAño">Año de Emisión.</param>
        public clsMoneda(int prmDenominacion, int prmAño)
        {
            atrDenominacion = prmDenominacion;
            atrAño = prmAño;
        }
        #endregion

        #region Acessores
        /// <summary>
        /// Devuelve el año de emision de la moneda.
        /// </summary>
        /// <returns>Valor Entero</returns>
        public int darAño()
        {
            return atrAño;
        }

        /// <summary>
        /// Devuelve la denominacion de la moneda.
        /// </summary>
        /// <returns>Valor Entero</returns>
        public int darDenominacion()
        {
            return atrDenominacion;
        }

        /// <summary>
        /// Devuelve el propietario de la moneda.
        /// </summary>
        /// <returns> clsPersona </returns>
        public clsPersona darPropietario()
        {
            return atrPropietario;
        }

        /// <summary>
        /// Devuelve donde esta guardada la moneda.
        /// </summary>
        /// <returns>clsAlcanciao</returns>
        public clsAlcancia darAlcancia()
        {
            return atrAlcancia;
        }

        #endregion

        #region Mutadores
        /// <summary>
        /// Asigna dueño a la moneda.
        /// </summary>
        /// <returns>Valor boleano(true/false)</returns>
        protected bool poner(clsPersona prmObjeto)
        {
            atrPropietario = prmObjeto;    
            return false;
        }
        /// <summary>
        /// Asigna alcancia a la moneda.
        /// </summary>
        /// <returns>Valor boleano(true/false)</returns>
        protected bool poner(clsAlcancia prmObjeto)
        {
            atrAlcancia = prmObjeto;
            return false;
        }
        #endregion

        #endregion
        public void Generar()
        {
            atrAlcancia = new clsAlcancia();
            atrPropietario = new clsPersona(5, "Luis");
            atrPropietario = new clsPersona(10, "Andres");

       
        }



    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WService
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService : System.Web.Services.WebService
    {

        CapaDatos.Clases.ClsPersonas vClspersonas = new CapaDatos.Clases.ClsPersonas();
        //CapaDatos.Clases.ClsMedicos vClsmedicos = new CapaDatos.Clases.ClsMedicos();

        [WebMethod]
        public string MantenimientoPersona(string pNif, String pNombre_Completo, String pDireccion, String pTelefono, String pPoblacion, String pProvincia, String pCodigo_Postal, String pNum_Seguridad_Social, String pAccion)
        {
            this.vClspersonas.aNif = pNif;
            this.vClspersonas.aNombre_Completo = pNombre_Completo;
            this.vClspersonas.aDireccion = pDireccion;
            this.vClspersonas.aTelefono = pTelefono;
            this.vClspersonas.aPoblacion = pPoblacion;
            this.vClspersonas.aProvincia = pProvincia;
            this.vClspersonas.aCodigo_Postal = pCodigo_Postal;
            this.vClspersonas.aNum_Seguridad_Social = pNum_Seguridad_Social;

            return vClspersonas.MantenimientoPersona(vClspersonas, pAccion);
        }

        [WebMethod]
        public DataSet GetListaPersonas(string pNif, String pNombre_Completo, String pDireccion, String pTelefono, String pPoblacion, String pProvincia, String pCodigo_Postal, String pNum_Seguridad_Social, String pAccion)
        {
            DataSet Dts = new DataSet();
            this.vClspersonas.aNif = pNif;
            this.vClspersonas.aNombre_Completo = pNombre_Completo;
            this.vClspersonas.aDireccion = pDireccion;
            this.vClspersonas.aTelefono = pTelefono;
            this.vClspersonas.aPoblacion = pPoblacion;
            this.vClspersonas.aProvincia = pProvincia;
            this.vClspersonas.aCodigo_Postal = pCodigo_Postal;
            this.vClspersonas.aNum_Seguridad_Social = pNum_Seguridad_Social;

            return vClspersonas.GetListaPersonas(vClspersonas, pAccion);
        }

        [WebMethod]
       // public string MantenimientoMedico(string pNif_Medico, DateTime pFecha_Alta, DateTime pFecha_Baja, String pNum_Colegiado, String pEstatus, String pAccion)
       // {
            //this.vClsmedicos.aNif = pNif_Medico;
            //this.vClsmedicos.aNombre_Completo = pFecha_Alta;
            //this.vClsmedicos.aDireccion = pFecha_Baja;
            //this.vClsmedicos.aTelefono = pNum_Colegiado;
            //this.vClsmedicos.aPoblacion = pEstatus;

            //return vClspersonas.MantenimientoMedico(vClsmedicos, pAccion);
        //}

        [WebMethod]
        //public DataSet GetListaMedicos(string pNif_Medico, DateTime pFecha_Alta, DateTime pFecha_Baja, String pNum_Colegiado, String pEstatus, String pAccion)
        //{
            //DataSet Dts = new DataSet();
            //this.vClsmedicos.aNif = pNif_Medico;
            //this.vClsmedicos.aNombre_Completo = pFecha_Alta;
            //this.vClsmedicos.aDireccion = pFecha_Baja;
            //this.vClsmedicos.aTelefono = pNum_Colegiado;
            //this.vClsmedicos.aPoblacion = pEstatus;
        
            //return vClspersonas.GetListaMedico(vClsmedicos, pAccion);
        //}
    }
}

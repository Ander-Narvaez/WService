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
    }
}

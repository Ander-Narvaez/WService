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

        CapaDatos.Clases.ClsPersonas vClspersonas   = new CapaDatos.Clases.ClsPersonas();
        CapaDatos.Clases.ClsMedicos vClsmedicos     = new CapaDatos.Clases.ClsMedicos();
        CapaDatos.Clases.ClsEmpleados vClsempleados = new CapaDatos.Clases.ClsEmpleados();
        CapaDatos.Clases.ClsPacientes vClspacientes = new CapaDatos.Clases.ClsPacientes();
        
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


        public DateTime Convert_Date(String pFecha)
        {
            return DateTime.Parse(pFecha);
        }

        [WebMethod]
        public string MantenimientoMedico(string pNif_Medico, String pFecha_Alta, String pFecha_Baja, String pNum_Colegiado, String pEstatus, String pAccion)
        {
            this.vClsmedicos.aNif_Medico = pNif_Medico;
            this.vClsmedicos.aFecha_Alta = Convert_Date(pFecha_Alta);
            this.vClsmedicos.aFecha_Baja = Convert_Date(pFecha_Baja); 
            this.vClsmedicos.aNum_Colegiado = pNum_Colegiado;
            this.vClsmedicos.aEstatus = pEstatus;

            return vClsmedicos.MantenimientoMedicos(vClsmedicos, pAccion);
        }

        [WebMethod]
        public DataSet GetListaMedicos(string pNif_Medico, String pFecha_Alta, String pFecha_Baja, String pNum_Colegiado, String pEstatus, String pAccion)
        {
            
            DataSet Dts = new DataSet();
            this.vClsmedicos.aNif_Medico = pNif_Medico;   
            this.vClsmedicos.aNum_Colegiado = pNum_Colegiado;
            if (pFecha_Alta != "0001-01-01T00:00:00")
            {
                if (pFecha_Alta != "" & pFecha_Baja != "")
                {
                    this.vClsmedicos.aFecha_Alta = DateTime.ParseExact(pFecha_Alta, "dd/MM/yyyy", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                    this.vClsmedicos.aFecha_Baja = DateTime.ParseExact(pFecha_Baja, "dd/MM/yyyy", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                }
            }
            return vClsmedicos.GetListaMedicos(vClsmedicos, pAccion);
        }

        [WebMethod]
        public string MantenimientoEmpleados(string pNif_Empleado, String pPuesto_Empleado, String pAccion)
        {
            this.vClsempleados.aNif_Empleado    = pNif_Empleado;
            this.vClsempleados.aPuesto_Empleado = pPuesto_Empleado;

            return vClsempleados.MantenimientoEmpleados(vClsempleados, pAccion);
        }

        [WebMethod]
        public DataSet GetListaEmpleados(string pNif_Empleado, String pPuesto_Empleado, String pAccion)
        {
            DataSet Dts = new DataSet();
            this.vClsempleados.aNif_Empleado = pNif_Empleado;
            this.vClsempleados.aPuesto_Empleado = pPuesto_Empleado;

            return vClsempleados.GetListaEmpleados(vClsempleados, pAccion);
        }

        [WebMethod]
        public string MantenimientoPacientes(string pNif_Paciente, String pMedico, String pAccion)
        {
            this.vClspacientes.aNif_Paciente = pNif_Paciente;
            this.vClspacientes.aMedico = pMedico;

            return vClspacientes.MantenimientoPacientes(vClspacientes, pAccion);
        }

        [WebMethod]
        public DataSet GetListaPacientes(string pNif_Paciente, String pMedico, String pAccion)
        {
            DataSet Dts = new DataSet();
            this.vClspacientes.aNif_Paciente = pNif_Paciente;
            this.vClspacientes.aMedico = pMedico;

            return vClspacientes.GetListaPacientes(vClspacientes, pAccion);
        }
    }
}

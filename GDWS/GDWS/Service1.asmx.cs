using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace GDWS
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            TextWriter CsqWrite = new StreamWriter(@"D:\Temp\temp.dd");
            CsqWrite.Write("%BTW% /F=");
            CsqWrite.Write(" /D=%Trigger File Name% ");
            CsqWrite.Write(" /prn=");
            CsqWrite.WriteLine("/P /Close /FP /C=001 /DbTextHeader=3 /R=3");
            CsqWrite.WriteLine("%END%");
            CsqWrite.Write("DESCRIPTION,");
            CsqWrite.Write("REVISION,");
            CsqWrite.Write("COMCODE,");
            CsqWrite.Write("QUANTITY,");
            CsqWrite.Write("UNITSN,");
            CsqWrite.Write("BOXNUMBER,");
            CsqWrite.Write("SKIDNUMBER,");
            CsqWrite.Write("CLEI,");
            CsqWrite.Write("ECI,");
            CsqWrite.Write("CUSTPARTNUMBER,");
            CsqWrite.Write("CUSTREVISION,");
            CsqWrite.Write("REPAIRSTATUS,");
            CsqWrite.Write("REPAIRSTATUSBARCODE,");
            CsqWrite.Write("ALUREF,");
            CsqWrite.Write("LOCATION,");
            CsqWrite.Write("ROHSLOGO,");
            CsqWrite.Write("SFTYMARK1,");
            CsqWrite.Write("SFTYMARK2,");
            CsqWrite.Write("SFTYMARK3,");
            CsqWrite.Write("SFTYMARK4,");
            CsqWrite.Write("SFTYMARK5,");
            CsqWrite.Write("SFTYMARK6,");
            CsqWrite.Write("DATECODE,");
            CsqWrite.Write("DATECODEBARCODE,");
            CsqWrite.Write("RMA,");
            CsqWrite.Write("ORDER,");
            CsqWrite.Write("SN1,");
            CsqWrite.Write("SN2,");
            CsqWrite.Write("SN3,");
            CsqWrite.Write("SN4,");
            CsqWrite.Write("SN5,");
            CsqWrite.Write("SN6,");
            CsqWrite.Write("SN7,");
            CsqWrite.Write("SN8,");
            CsqWrite.Write("SN9,");
            CsqWrite.WriteLine("SN10");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Write(",");
            CsqWrite.Close();
            return "Hello";
        }
    }
}
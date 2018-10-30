using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using MlAutoResrv.X_Class;
using System.Net;
using MlAutoResrv.ReservReq;
using MlAutoResrv.ReservRes;
using Newtonsoft.Json;
using System.IO;

namespace MlAutoResrv
{
    #region "COM"
    [Guid("E79F359E-4DD7-44FE-898A-8027A04F8BBE")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [ComVisibleAttribute(true)]
    public interface iInterface
    {
        //Method
        [DispId(1)] string GETtVersionDll();
        [DispId(2)] cATReservRes POSTtAutoReserv(string ptUrl, string ptUser, string ptPassword, cATReservReq poATReservReq);     
    }
    #endregion
    [Guid("B42ED084-0336-4097-BB3C-9E245941D81A")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("cAutoReservPost")]
    [ComVisibleAttribute(true)]
    public class cAutoReservPost : iInterface
    {
        private static readonly log4net.ILog oC_log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public string GETtVersionDll()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        public cATReservRes POSTtAutoReserv(string ptUrl,string ptUser,string ptPassword, cATReservReq poATReservReq)
        {
            cReservationReq oReservationReq = new cReservationReq(poATReservReq);
            cJsonReq oJsonReq = new cJsonReq(oReservationReq);
            cReservationRes oReservationRes = new cReservationRes();
            cATReservRes oATReservRes = new cATReservRes();
            string tJsonStr = "";
            string tResult = "";
            try
            {
                tJsonStr = JsonConvert.SerializeObject(oJsonReq);
                oC_log.Debug("Send Request to : "+ ptUrl + 
                    "\r\n<<<======JsonREQ======>>>\r\n" + tJsonStr + "\r\n<<<======EndJsonREQ======>>>");
                HttpWebRequest oWebReq = (HttpWebRequest)WebRequest.Create(ptUrl);
                oWebReq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(ptUser + ":" + ptPassword)));
                oWebReq.Method = "POST";                
                byte[] aData = Encoding.ASCII.GetBytes(tJsonStr.ToString());
                oWebReq.ContentLength = aData.Length;
                oWebReq.ContentType = "application/json;charset=UTF-8";
                using (var oStream = oWebReq.GetRequestStream())
                {
                    oStream.Write(aData, 0, aData.Length);
                }
                using (HttpWebResponse oResp = (HttpWebResponse)oWebReq.GetResponse())
                using(StreamReader oSr = new StreamReader(oResp.GetResponseStream()))
                {
                    tResult = oSr.ReadToEnd();             
                    cJsonRes oJsonRes = JsonConvert.DeserializeObject<cJsonRes>(tResult);
                    oATReservRes = oJsonRes.ReservationRes.GEToATReservRes();
                    oC_log.Debug("Receive response from : " + ptUrl +
                    "\r\n<<<======JsonRES======>>>\r\n" + tResult + "\r\n<<<======EndJsonRES======>>>");
                }               
                oATReservRes.bResult = true;
                oATReservRes.tMessage = "success";
            }
            catch (Exception ex)
            {
                oATReservRes.bResult = false;
                oATReservRes.tMessage = ex.Message.ToString();
            }
            return oATReservRes;
        }       
    }
}

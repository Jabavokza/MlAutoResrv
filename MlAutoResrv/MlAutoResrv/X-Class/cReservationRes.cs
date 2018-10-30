using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using MlAutoResrv.X_Class;

namespace MlAutoResrv.ReservRes 
{
    public class cJsonRes
    {
        [JsonProperty("POSReservationRes_MT")]
        public cReservationRes ReservationRes { get; set; }
        public cJsonRes(cReservationRes poReservationRes)
        {
            ReservationRes = poReservationRes;
        }
    }
    public class cReservationRes
    {

        [JsonProperty("Header")]
        public Header Header { get; set; }

        public cATReservRes GEToATReservRes()
        {
            cATReservRes oATReservRes = new cATReservRes();
            oATReservRes.PstngDate = this.Header.PSTNG_DATE;
            oATReservRes.PosTransID = this.Header.POS_TRANSID;
            foreach (Item oItem in this.Header.Item)
            {
                cItemRes oItemRes = new cItemRes
                {
                    EANUpc = oItem.EAN_UPC,
                    RetCode = oItem.RET_CODE,
                    MsgCode = oItem.MSG_CODE,
                    MsgText = oItem.MSG_TEXT 
                };
                oATReservRes.ItemList.Add(oItemRes);
            }
            return oATReservRes;
        }
    }
    public class Item
    {

        [JsonProperty("EAN_UPC")]
        public string EAN_UPC { get; set; }

        [JsonProperty("RET_CODE")]
        public string RET_CODE { get; set; }

        [JsonProperty("MSG_CODE")]
        public string MSG_CODE { get; set; }

        [JsonProperty("MSG_TEXT")]
        public string MSG_TEXT { get; set; }
    }

    public class Header
    {

        [JsonProperty("PSTNG_DATE")]
        public string PSTNG_DATE { get; set; }

        [JsonProperty("POS_TRANSID")]
        public string POS_TRANSID { get; set; }

        [JsonProperty("Item")]
        public IList<Item> Item { get; set; }
    }

    
}

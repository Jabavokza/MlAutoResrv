using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using MlAutoResrv.X_Class; 

namespace MlAutoResrv.ReservReq
{
    public class cJsonReq
    {
        [JsonProperty("ReservationReq")]
        public cReservationReq ReservationReq { get; set; }
        public cJsonReq(cReservationReq poReservationReq)
        {
            ReservationReq = poReservationReq;
        }
    }
    public class cReservationReq
    {
        [JsonProperty("Header")]
        public Header Header { get; set; }

        public cReservationReq(cATReservReq poATReservReq)
        {
            Header = new Header
            {
                PSTNG_DATE = poATReservReq.PstngDate ,
                POS_TRANSID = poATReservReq.PosTransID ,
                ACTION = poATReservReq.Action ,
                DOC_DATE = poATReservReq.DocDate ,
                STORE = poATReservReq.Store
            };
            Header.Item = new List<Item>();
            foreach (cItemReq oItemReq in poATReservReq.ItemList)
            {
                Item oItem = new Item
                {
                    EAN_UPC = oItemReq.EANCode ,
                    ENTRY_QNT = oItemReq.EntryQnt ,
                    ENTRY_UOM = oItemReq.EntryCode ,
                    MOVE_PLANT = oItemReq.MovePlant ,
                    PLANT = oItemReq.Plant ,
                    STGR_LOC = oItemReq.StrgLoc ,
                    MOVE_TYPE = oItemReq.MoveType
                };
                oItem.SERIAL = new List<SERIAL>();
                foreach (cSerial oSerial in oItemReq.SerialList)
                {
                    SERIAL oSERIAL = new SERIAL
                    {
                        MATDOC_ITM = oSerial.MatDocItm,
                        SERIALNO = oSerial.SerialNo             
                    };
                    oItem.SERIAL.Add(oSERIAL); 
                }
                Header.Item.Add(oItem); 
            }
        }
    }

    public class SERIAL
    {
        [JsonProperty("MATDOC_ITM")]
        public string MATDOC_ITM { get; set; }

        [JsonProperty("SERIALNO")]
        public string SERIALNO { get; set; }
    }

    public class Item
    {

        [JsonProperty("PLANT")]
        public string PLANT { get; set; }

        [JsonProperty("STGR_LOC")]
        public string STGR_LOC { get; set; }

        [JsonProperty("MOVE_TYPE")]
        public string MOVE_TYPE { get; set; }

        [JsonProperty("ENTRY_QNT")]
        public string ENTRY_QNT { get; set; }

        [JsonProperty("ENTRY_UOM")]
        public string ENTRY_UOM { get; set; }

        [JsonProperty("MOVE_PLANT")]
        public string MOVE_PLANT { get; set; }

        [JsonProperty("EAN_UPC")]
        public string EAN_UPC { get; set; }

        [JsonProperty("SERIAL")]
        public IList<SERIAL> SERIAL { get; set; }
    }

    public class Header
    {

        [JsonProperty("PSTNG_DATE")]
        public string PSTNG_DATE { get; set; }

        [JsonProperty("DOC_DATE")]
        public string DOC_DATE { get; set; }

        [JsonProperty("POS_TRANSID")]
        public string POS_TRANSID { get; set; }

        [JsonProperty("ACTION")]
        public string ACTION { get; set; }

        [JsonProperty("STORE")]
        public string STORE { get; set; }

        [JsonProperty("Item")]
        public IList<Item> Item { get; set; }
    }

     
}

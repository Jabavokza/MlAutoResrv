using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MlAutoResrv.X_Class
{
    [Guid("4F1B66DB-15E6-461C-86A2-45A3A1D3DEE5")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [ComVisibleAttribute(true)]
    public interface iInterfaceReq
    {
        //Method
        [DispId(1)] void SETxValue(string ptPstngDate, string ptDocDate, string ptPosTransID, string ptAction,string ptStore);
        [DispId(2)] void ADDxItem(cItemReq poItemPost);
        [DispId(3)] cATReservReq GET();
    }
    [Guid("24102CC3-8B63-411C-9027-223A87E6E210")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("cATReservReq")]
    [ComVisibleAttribute(true)]
    public class cATReservReq : iInterfaceReq
    {
        public string PstngDate { get; set; }
        public string DocDate { get; set; }
        public string PosTransID { get; set; }
        public string Action { get; set; }
        public string Store { get; set; }// Kin ML-POSC-0241  2018-10-26

        public List<cItemReq> ItemList = new List<cItemReq>();
        public void SETxValue(string ptPstngDate,string ptDocDate,string ptPosTransID,string ptAction,string ptStore)
        {
            PstngDate = ptPstngDate;
            DocDate = ptDocDate;
            PosTransID = ptPosTransID;
            Action = ptAction;
            Store = ptStore;
            ItemList = new List<cItemReq>();
        }
        public void ADDxItem(cItemReq poItemReq)
        {
            ItemList.Add(poItemReq);
        }
        public cATReservReq GET()
        {
            //cATReservReq oClone = new cATReservReq
            //{
            //    PstngDate = PstngDate,
            //    DocDate = DocDate,
            //    PosTransID = PosTransID,
            //    Action = Action
            //};
            //oClone.ItemList = new List<cItemReq>();
            //foreach (cItemReq oItemReq in this.ItemList)
            //{
            //    cItemReq oCloneItem = new cItemReq
            //    {
            //        EANCode = oItemReq.EANCode,
            //        EntryCode = oItemReq.EntryCode,
            //        EntryQnt = oItemReq.EntryQnt,
            //        MovePlant = oItemReq.MovePlant,
            //        MoveType = oItemReq.MoveType,
            //        Plant = oItemReq.Plant,
            //        StrgLoc = oItemReq.StrgLoc
            //    };
            //    oCloneItem.SerialList = new List<cSerial>();
            //    foreach (cSerial oSerial in oItemReq.SerialList)
            //    {
            //        oCloneItem.SerialList.Add(new cSerial
            //        {
            //            MatDocItm = oSerial.MatDocItm,
            //            SerialNo = oSerial.SerialNo
            //        });
            //    }
            //    oClone.ItemList.Add(oCloneItem);
            //}
            return this;
        }
    }
       
    [Guid("ADDB30EA-1CA6-4B07-84C6-4965BB0A5CD3")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [ComVisibleAttribute(true)]
    public interface iInterfaceItemReq
    {
        //Method
        [DispId(1)] void SETxValue(string ptPlant, string ptStrgLoc, string ptMoveType, string ptEntryQnt, string ptEntryCode
            , string ptMovePlant, string ptEANCode);
        [DispId(2)] void ADDxSerial(string ptMatDocItm, string ptSerialNo);
        [DispId(3)] cItemReq GET();
    }
    [Guid("07212BDE-5E78-4F5F-8BC0-E67A7DB13FCE")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("cItemReq")]
    [ComVisibleAttribute(true)]
    public class cItemReq : iInterfaceItemReq
    {
        public string Plant { get; set; }
        public string StrgLoc { get; set; }
        public string MoveType { get; set; }
        public string EntryQnt { get; set; }
        public string EntryCode { get; set; }
        public string MovePlant { get; set; }
        public string EANCode { get; set; }
        public List<cSerial> SerialList = new List<cSerial>();
        public void SETxValue(string ptPlant, string ptStrgLoc, string ptMoveType, string ptEntryQnt, string ptEntryUom
            , string ptMovePlant, string ptEANCode)
        {
            Plant = ptPlant;
            StrgLoc = ptStrgLoc;
            MoveType = ptMoveType;
            EntryQnt = ptEntryQnt.Replace("-","");
            EntryCode = ptEntryUom;
            MovePlant = ptMovePlant;
            EANCode = ptEANCode;
            SerialList = new List<cSerial>();
        }
        public void ADDxSerial(string ptMatDocItm, string ptSerialNo)
        {
            cSerial oSerial = new cSerial() { MatDocItm = ptMatDocItm, SerialNo = ptSerialNo };
            SerialList.Add(oSerial);
        }
        public cItemReq GET()
        {
            cItemReq cCloneItem = new cItemReq
            {
                Plant = Plant,
                StrgLoc = StrgLoc,
                EANCode = EANCode,
                EntryCode = EntryCode,
                EntryQnt = EntryQnt,
                MovePlant = MovePlant,
                MoveType = MoveType,
                SerialList = new List<cSerial>()
            };
            foreach(cSerial oSerial in SerialList)
            {
                cCloneItem.SerialList.Add(new cSerial
                {
                    MatDocItm = oSerial.MatDocItm,
                    SerialNo = oSerial.SerialNo
                });
            }
            return cCloneItem;
        }
    }
    public class cSerial
    {
        public string MatDocItm { get; set; }
        public string SerialNo { get; set; }
        public void SETxValue(string ptMatDocItm, string ptSerialNo)
        {
            MatDocItm = ptMatDocItm;
            SerialNo = ptSerialNo;
        }
    }
}

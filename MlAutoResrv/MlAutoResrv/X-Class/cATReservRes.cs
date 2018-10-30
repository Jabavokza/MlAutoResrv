using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MlAutoResrv.X_Class
{
    [Guid("9D8099E1-3754-427A-A52E-BB06A261AE19")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [ComVisibleAttribute(true)]
    public interface iInterfaceRes
    {
        //Method
        [DispId(1)] bool GETbResult();
        [DispId(2)] string GETtMessage();
        [DispId(3)] string GETtPstngDate();
        [DispId(4)] string GETtPosTransID();
        [DispId(5)] cItemRes GETaItemList(int index);
        [DispId(6)] int GETaItemListCount();
    }
    [Guid("F19AEF42-B1CD-4B33-B291-B2BAB9E1E943")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("cATReservRes")]
    [ComVisibleAttribute(true)]
    public class cATReservRes : iInterfaceRes
    {
        public bool bResult { get; set; }
        public string tMessage { get; set; }
        public string PstngDate { get; set; }
        public string PosTransID { get; set; }
        public List<cItemRes> ItemList = new List<cItemRes>();
        public bool GETbResult()
        {
            return bResult;
        }
        public string GETtMessage()
        {
            return tMessage;
        }
        public string GETtPstngDate()
        {
            return PstngDate;
        }
        public string GETtPosTransID()
        {
            return PosTransID;
        }
        public cItemRes GETaItemList(int index)
        {
            return ItemList[index];
        }
        public int GETaItemListCount()
        {
            return ItemList.Count;
        }
    }

    [Guid("AC3A08A5-53A8-4B38-973B-CD55511859EE")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [ComVisibleAttribute(true)]
    public interface iInterfaceItemRes
    {
        //Method
        [DispId(1)] string GETtEANUpc();
        [DispId(2)] string GETtRetCode();
        [DispId(3)] string GETtMsgCode();
        [DispId(4)] string GETtMsgText();
    }
    [Guid("118673C9-3B84-4532-A787-84D43AE4E226")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("cItemRes")]
    [ComVisibleAttribute(true)]
    public class cItemRes : iInterfaceItemRes
    {       
        public string EANUpc { get; set; }
        public string RetCode { get; set; }
        public string MsgCode { get; set; }
        public string MsgText { get; set; }
        public string GETtEANUpc()
        {
            return EANUpc;
        }
        public string GETtRetCode()
        {
            return RetCode;
        }
        public string GETtMsgCode()
        {
            return MsgCode;
        }
        public string GETtMsgText()
        {
            return MsgText;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MlAutoResrv;
using MlAutoResrv.X_Class;

namespace TestForm
{
    public partial class wMain : Form
    {
        private cAutoReservPost oAutoReservPost = new cAutoReservPost();
        private cATReservReq oATReservReq = new cATReservReq();
        private cATReservRes oATReservRes = new cATReservRes();
        private cItemReq oItemReq = new cItemReq();
        public wMain()
        {
            InitializeComponent();
            cInitValue();
        }
        private void cInitValue()
        {
            otbDocDate.Text = DateTime.Today.ToString("yyyyMMdd");
            otbPstngDate.Text = DateTime.Today.ToString("yyyyMMdd");
            otbPosTransId.Text = "9000100001";
            ocbAction.SelectedIndex = 1;
            otbPlant.Text = "17KB";
            otbStgrLoc.Text = "1001";
            otbMoveType.Text = "311";
            otbEntryQnt.Text = "2.0";
            otbEntryUom.Text = "EA";
            otbMovePlant.Text = "17KB";
            otbEANUpc.Text = "8855451002477";
            otbMatDocItm.Text = "0001";
            otbSerialNo.Text = "098765439765";
            olbPostItem.Nodes.Add("Header");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            cItemReq oItemReq = new cItemReq();
            string tPSTNG_DATE, tDOC_DATE, tPOS_TRANSID, tACTION,tSTORE = "";
            string tPLANT, tSTGR_LOC, tMOVE_TYPE, tENTRY_QNT, tENTRY_UOM, tMOVE_PLANT, tEAN_UPC;
            string tMATDOC_ITM, tSERIALNO;
            TreeNode[] aTreeNode;
            TreeNode[] aItemNode;
            TreeNode[] aSerialsNode;
            TreeNode[] aSerialNode;
            if (olbPostItem.Nodes.ContainsKey("PSTNG_DATE"))
            {
                aTreeNode = olbPostItem.Nodes.Find("PSTNG_DATE", false);
                tPSTNG_DATE = aTreeNode[0].Text.Replace("PSTNG_DATE: ", "");
            }
            else
            {
                MessageBox.Show("Error in PSTNG_DATE value");
                return;
            }
            if (olbPostItem.Nodes.ContainsKey("DOC_DATE"))
            {
                aTreeNode = olbPostItem.Nodes.Find("DOC_DATE", false);
                tDOC_DATE = aTreeNode[0].Text.Replace("DOC_DATE: ", "");
            }
            else
            {
                MessageBox.Show("Error in DOC_DATE value");
                return;
            }
            if (olbPostItem.Nodes.ContainsKey("POS_TRANSID"))
            {
                aTreeNode = olbPostItem.Nodes.Find("POS_TRANSID", false);
                tPOS_TRANSID = aTreeNode[0].Text.Replace("POS_TRANSID: ", "");
            }
            else
            {
                MessageBox.Show("Error in POS_TRANSID value");
                return;
            }
            if (olbPostItem.Nodes.ContainsKey("ACTION"))
            {
                aTreeNode = olbPostItem.Nodes.Find("ACTION", false);
                tACTION = aTreeNode[0].Text.Replace("ACTION: ", "");
            }
            else
            {
                MessageBox.Show("Error in ACTION value");
                return;
            }

            if (olbPostItem.Nodes.ContainsKey("STORE"))
            {
                aTreeNode = olbPostItem.Nodes.Find("STORE", false);
                tSTORE = aTreeNode[0].Text.Replace("STORE: ", "");
            }
            else
            {
                MessageBox.Show("Error in STORE value");
                return;
            }

            oATReservReq.SETxValue(tPSTNG_DATE, tDOC_DATE, tPOS_TRANSID, tACTION, tSTORE);
            if (olbPostItem.Nodes.ContainsKey("ITEMS"))
            {
                aTreeNode = olbPostItem.Nodes.Find("ITEMS", false);
                foreach(TreeNode oItemNode in aTreeNode[0].Nodes)
                {
                    if (oItemNode.Name == "ITEM")
                    {
                        if (oItemNode.Nodes.ContainsKey("PLANT"))
                        {
                            aItemNode = oItemNode.Nodes.Find("PLANT", false);
                            tPLANT = aItemNode[0].Text.Replace("PLANT: ", "");
                        }
                        else
                        {
                            MessageBox.Show("Error in PLANT value");
                            return;
                        }
                        if (oItemNode.Nodes.ContainsKey("STGR_LOC"))
                        {
                            aItemNode = oItemNode.Nodes.Find("STGR_LOC", false);
                            tSTGR_LOC = aItemNode[0].Text.Replace("STGR_LOC: ", "");
                        }
                        else
                        {
                            MessageBox.Show("Error in STGR_LOC value");
                            return;
                        }
                        if (oItemNode.Nodes.ContainsKey("MOVE_TYPE"))
                        {
                            aItemNode = oItemNode.Nodes.Find("MOVE_TYPE", false);
                            tMOVE_TYPE = aItemNode[0].Text.Replace("MOVE_TYPE: ", "");
                        }
                        else
                        {
                            MessageBox.Show("Error in MOVE_TYPE value");
                            return;
                        }
                        if (oItemNode.Nodes.ContainsKey("ENTRY_QNT"))
                        {
                            aItemNode = oItemNode.Nodes.Find("ENTRY_QNT", false);
                            tENTRY_QNT = aItemNode[0].Text.Replace("ENTRY_QNT: ", "");
                        }
                        else
                        {
                            MessageBox.Show("Error in ENTRY_QNT value");
                            return;
                        }
                        if (oItemNode.Nodes.ContainsKey("ENTRY_UOM"))
                        {
                            aItemNode = oItemNode.Nodes.Find("ENTRY_UOM", false);
                            tENTRY_UOM = aItemNode[0].Text.Replace("ENTRY_UOM: ", "");
                        }
                        else
                        {
                            MessageBox.Show("Error in ENTRY_UOM value");
                            return;
                        }
                        if (oItemNode.Nodes.ContainsKey("MOVE_PLANT"))
                        {
                            aItemNode = oItemNode.Nodes.Find("MOVE_PLANT", false);
                            tMOVE_PLANT = aItemNode[0].Text.Replace("MOVE_PLANT: ", "");
                        }
                        else
                        {
                            MessageBox.Show("Error in MOVE_PLANT value");
                            return;
                        }
                        if (oItemNode.Nodes.ContainsKey("EAN_UPC"))
                        {
                            aItemNode = oItemNode.Nodes.Find("EAN_UPC", false);
                            tEAN_UPC = aItemNode[0].Text.Replace("EAN_UPC: ", "");
                        }
                        else
                        {
                            MessageBox.Show("Error in EAN_UPC value");
                            return;
                        }
                        oItemReq.SETxValue(tPLANT, tSTGR_LOC, tMOVE_TYPE, tENTRY_QNT, tENTRY_UOM, tMOVE_PLANT, tEAN_UPC);
                        if (oItemNode.Nodes.ContainsKey("SERIALS"))
                        {
                            aSerialsNode = oItemNode.Nodes.Find("SERIALS", false);
                            foreach (TreeNode oSerialNode in aSerialsNode[0].Nodes)
                            {
                                if (oSerialNode.Name == "SERIAL")
                                {
                                    if (oSerialNode.Nodes.ContainsKey("MATDOC_ITM"))
                                    {
                                        aSerialNode = oSerialNode.Nodes.Find("MATDOC_ITM", false);
                                        tMATDOC_ITM = aSerialNode[0].Text.Replace("MATDOC_ITM: ", "");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error in MATDOC_ITM value");
                                        return;
                                    }
                                    if (oSerialNode.Nodes.ContainsKey("SERIALNO"))
                                    {
                                        aSerialNode = oSerialNode.Nodes.Find("SERIALNO", false);
                                        tSERIALNO = aSerialNode[0].Text.Replace("SERIALNO: ", "");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error in SERIALNO value");
                                        return;
                                    }
                                    oItemReq.ADDxSerial(tMATDOC_ITM, tSERIALNO);
                                }
                            }
                        }
                        oATReservReq.ADDxItem(oItemReq.GET());
                    }
                }
            }
            else
            {
                MessageBox.Show("Error in ITEMS value");
                return;
            }
            //oATReservRes = oAutoReservPost.POSTtAutoReserv()
           
            oATReservRes = oAutoReservPost.POSTtAutoReserv(otbURL.Text, otbUsername.Text,otbPassword.Text, oATReservReq.GET());
            this.otbResult.Text = 
                "Result: " + oATReservRes.GETbResult().ToString() +"\r\n"+
                "Message: " + oATReservRes.GETtMessage() + "\r\n" +
                "PstngDate: " + oATReservRes.GETtPstngDate() + "\r\n" +
                "PosTransID: " + oATReservRes.GETtPosTransID() +"\r\n";
            int nItemIndex = 0;
            foreach (cItemRes oItemRes in oATReservRes.ItemList)
            {
                nItemIndex++;
                this.otbResult.Text += "    Item:" + nItemIndex.ToString() + "\r\n" +
                    "       EAN_UPC:" + oItemRes.EANUpc + "\r\n" +
                    "       RET_CODE:" + oItemRes.RetCode + "\r\n" +
                    "       MSG_CODE:" + oItemRes.MsgCode + "\r\n" +
                    "       MSG_TEXT:" + oItemRes.MsgText + "\r\n";
            }

        }

        private void ocmAddSerial_Click(object sender, EventArgs e)
        {
            if (olbPostItem.SelectedNode.Name == "SERIALS")
            {
                TreeNode oSelNode = olbPostItem.SelectedNode;
                int nIndex = oSelNode.Nodes.Count;
                TreeNode oNewItem = new TreeNode("SERIAL");
                oNewItem.Name = "SERIAL";
                oNewItem.Nodes.Add("MATDOC_ITM", "MATDOC_ITM: " + otbMatDocItm.Text);
                oNewItem.Nodes.Add("SERIALNO", "SERIALNO: " + otbSerialNo.Text);
                oSelNode.Nodes.Add(oNewItem);
                W_RENUMxNode(oSelNode);
            }
        }

        private void ocmAddItem_Click(object sender, EventArgs e)
        {
            if (olbPostItem.SelectedNode.Name == "ITEMS")
            {
                TreeNode oSelNode = olbPostItem.SelectedNode;
                int nIndex = oSelNode.Nodes.Count;
                TreeNode oNewItem = new TreeNode("ITEM");
                oNewItem.Name = "ITEM";
                oNewItem.Nodes.Add("EAN_UPC", "EAN_UPC: " + otbEANUpc.Text);
                oNewItem.Nodes.Add("PLANT", "PLANT: " + otbPlant.Text);
                oNewItem.Nodes.Add("ENTRY_UOM", "ENTRY_UOM: " + otbEntryUom.Text);
                oNewItem.Nodes.Add("ENTRY_QNT", "ENTRY_QNT: " + otbEntryQnt.Text);
                oNewItem.Nodes.Add("MOVE_TYPE", "MOVE_TYPE: " + otbMoveType.Text);
                oNewItem.Nodes.Add("MOVE_PLANT", "MOVE_PLANT: " + otbMovePlant.Text);
                oNewItem.Nodes.Add("STGR_LOC", "STGR_LOC: " + otbStgrLoc.Text);
                oNewItem.Nodes.Add("SERIALS", "SERIALS");
                oSelNode.Nodes.Add(oNewItem);
                W_RENUMxNode(oSelNode);
            }
        }

        private void W_RENUMxNode(TreeNode poItemsNode)
        {
            int nIndex = 0;
            string tStr = null;
            if (poItemsNode.Name == "ITEMS")
            {
                tStr = "ITEM:";
            }
            else if(poItemsNode.Name == "SERIALS")
            {
                tStr = "SERIAL:";
            }
            else
            {
                return;
            }
            foreach (TreeNode oTrItem in poItemsNode.Nodes)
            {
                nIndex++;
                oTrItem.Text = tStr + nIndex.ToString();
            }
        }

        private void ocmSetHead_Click(object sender, EventArgs e)
        {
            if (!olbPostItem.Nodes.ContainsKey("PSTNG_DATE"))
                olbPostItem.Nodes.Add("PSTNG_DATE", "PSTNG_DATE: " + otbPstngDate.Text);
            else
                olbPostItem.Nodes["PSTNG_DATE"].Text = "PSTNG_DATE: " + otbPstngDate.Text;

            if (!olbPostItem.Nodes.ContainsKey("DOC_DATE"))
                olbPostItem.Nodes.Add("DOC_DATE", "DOC_DATE: " + otbDocDate.Text);
            else
                olbPostItem.Nodes["DOC_DATE"].Text = "DOC_DATE: " + otbDocDate.Text;
            if (!olbPostItem.Nodes.ContainsKey("POS_TRANSID"))
                olbPostItem.Nodes.Add("POS_TRANSID", "POS_TRANSID: " + otbPosTransId.Text);
            else
                olbPostItem.Nodes["POS_TRANSID"].Text = "POS_TRANSID: " + otbPosTransId.Text;
            if (!olbPostItem.Nodes.ContainsKey("ACTION"))
                olbPostItem.Nodes.Add("ACTION", "ACTION: " + ocbAction.Text);
            else
                olbPostItem.Nodes["ACTION"].Text = "ACTION: " + ocbAction.Text;
            if (!olbPostItem.Nodes.ContainsKey("STORE"))
                olbPostItem.Nodes.Add("STORE", "STORE");
            else
                olbPostItem.Nodes["STORE"].Text = "STORE: " + otbStore.Text;
            if (!olbPostItem.Nodes.ContainsKey("ITEMS"))
                olbPostItem.Nodes.Add("ITEMS", "ITEMS");
        }

        private void olbPostItem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ocmAddItem.Enabled = olbPostItem.SelectedNode.Name == "ITEMS";
            ocmAddSerial.Enabled = olbPostItem.SelectedNode.Name == "SERIALS";
            ocmDelete.Enabled = (olbPostItem.SelectedNode.Name == "SERIAL") || (olbPostItem.SelectedNode.Name == "ITEM");
        }

        private void ocmDelete_Click(object sender, EventArgs e)
        {
            DialogResult oDlRes = MessageBox.Show("Delete this " + olbPostItem.SelectedNode.Text + " node?", "Confirm deletion", MessageBoxButtons.YesNo);
            if (oDlRes == DialogResult.Yes)
            {
                TreeNode oParent = olbPostItem.SelectedNode.Parent;
                olbPostItem.SelectedNode.Remove();
                W_RENUMxNode(oParent);
            }
        }

    }
}

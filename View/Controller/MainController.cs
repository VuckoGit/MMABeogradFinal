using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;
using Domain;
namespace View.Controller
{
    public class MainController
    {
        internal void OpenUCManufacturer(FRMMain frmMain)
        {
            frmMain.SetPanel(new UCManufacturer(new Controller.ManufacturerController()));
        }

        internal void OpenUCProduct(FRMMain frmMain)
        {
            frmMain.SetPanel(new UCProduct(new Controller.ProductController()));
        }
        internal void OpenUCAllProducts(FRMMain frmMain)
        {
            frmMain.SetPanel(new UCAllProducts(new Controller.ProductController(frmMain)));
        }
        internal void OpenUCEditProduct(FRMMain frmMain, Product product)
        {
            frmMain.SetPanel(new UCEditProduct(new Controller.ProductController(frmMain,product)));
        }

       
        internal void OpenUCPurchaseOrder(FRMMain frmMain)
        {
            frmMain.SetPanel(new UCPurchaseOrder(new Controller.PurchaseOrderController()));

        }

        internal void OpenUCAllPurchaseOrder(FRMMain fRMMain)
        {
            fRMMain.SetPanel(new UCAllPurchaseOrder(new Controller.PurchaseOrderController(fRMMain)));
        }
        internal void OpenUCCancelPurchaseOrder(FRMMain frmMain, PurchaseOrder purchaseOrder)
        {
          frmMain.SetPanel(new UCCancelPurchaseOrder(new Controller.PurchaseOrderController(frmMain,purchaseOrder)));
        }


        internal void OpenUCReceptionList(FRMMain frmMain)
        {
            frmMain.SetPanel(new UCReceptionList(new Controller.ReceptionListController()));

        }

        internal void OpenUCAllReceptionList(FRMMain fRMMain)
        {
            fRMMain.SetPanel(new UCAllReceptionList(new Controller.ReceptionListController(fRMMain)));
        }

        internal void OpenUCCancelReceptionList(FRMMain frmMain, ReceptionList receptionList)
        {
            frmMain.SetPanel(new UCCancelReceptionList(new Controller.ReceptionListController(frmMain, receptionList)));

        }


        internal void CloseMainForm()
        {
            Communication.Communication.Instance.Disconnect();
            MainCoordinator.Instance.OpenLoginForm();
        }
    }
}

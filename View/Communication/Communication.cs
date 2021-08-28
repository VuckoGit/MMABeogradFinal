using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Communication
{
   public class Communication
    {
        private static Communication instance;

        private Socket socket;
        private CommunicationClient client;
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }
        private Communication()
        {

        }
        public void Connect()
        {
            if (socket != null && socket.Connected)
            {
                return;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            client = new CommunicationClient(socket);

        }

        internal void Disconnect()
        {
            socket.Close();
            socket = null;
        }
        internal User Login(string username, string password)
        {
            Request request = new Request()
            {
                Operation = Operation.Login,
                RequestObject = new User { Username = username, Password = password }
            };
            client.SendRequest(request);
            return (User)client.GetResponseResult();
        }

       

        internal void SaveProduct(Product p)
        {
            Request request = new Request() { Operation = Operation.SaveProduct };
            request.RequestObject = p;
            client.SendRequest(request);
            client.GetResponseResult();
        }

        

        internal List<Product> GetAllProducts()
        {
            Request request = new Request() { Operation = Operation.GetAllProducts };
            client.SendRequest(request);
            return (List<Product>)client.GetResponseResult();
        }


        internal List<Product> Search(string txtSearch)
        {

            Request request = new Request() { Operation = Operation.SearchProducts, RequestObject = new Product { SearchParametar=txtSearch } };
            client.SendRequest(request);
         
            return (List<Product>)client.GetResponseResult();
        }

        internal void EditProduct(Product p)
        {
            Request request = new Request() { Operation = Operation.EditProduct };
            request.RequestObject = p;
            client.SendRequest(request);
            client.GetResponseResult();
        }
        internal void SaveManufacturer(Manufacturer m)
        {
            Request request = new Request() { Operation = Operation.SaveManufacturer, RequestObject = m };
            client.SendRequest(request);
            client.GetResponseResult();
        }

       

        internal List<Manufacturer> GetAllManufacuturers()
        {
            Request request = new Request() { Operation = Operation.GetAllManufacturers };
            client.SendRequest(request);
            return (List<Manufacturer>)client.GetResponseResult();
        }

        internal List<PurchaseOrder> GetallPurchaseOrder()
        {
            Request request = new Request() { Operation = Operation.GetAllPurchaseOrder };
            client.SendRequest(request);
            return (List<PurchaseOrder>)client.GetResponseResult();
        }

        internal void SavePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            Request request = new Request() { Operation = Operation.SavePurchaseOrder };
            request.RequestObject = purchaseOrder;
            client.SendRequest(request);
            client.GetResponseResult();
        }
        internal List<PurchaseOrder> SearchPurchaseOrder(string txtSearch)
        {

            Request request = new Request() { Operation = Operation.SearchPurchaseOrder, RequestObject = new PurchaseOrder { SearchParametar = txtSearch } };
            client.SendRequest(request);

            return (List<PurchaseOrder>)client.GetResponseResult();
        }


        internal List<PurchaseOrderItem> LoadPurchaseOrderItems(PurchaseOrder purchaseOrder)
        {
            Request request = new Request() { Operation = Operation.LoadPurchaseOrderItems,RequestObject= purchaseOrder };
            client.SendRequest(request);
            return (List<PurchaseOrderItem>)client.GetResponseResult();
        }

        internal void CancelPurchaseOrder(PurchaseOrder po)
        {
            Request request = new Request() { Operation = Operation.CancelPurchaseOrder };
            request.RequestObject = po;
            client.SendRequest(request);
            client.GetResponseResult();



        }
        internal List<ReceptionList> GetAllReceptionList()
        {
            Request request = new Request() { Operation = Operation.GetAllReceptionList };
            client.SendRequest(request);
            return (List<ReceptionList>)client.GetResponseResult();
        }


        internal List<ReceptionListItem> LoadReceptionListItems(ReceptionList receptionList)
        {
            Request request = new Request() { Operation = Operation.LoadReceptionListItems, RequestObject = receptionList };
            client.SendRequest(request);
            return (List<ReceptionListItem>)client.GetResponseResult();
        }
        internal void CancelReceptionList(ReceptionList rl)
        {
            Request request = new Request() { Operation = Operation.CancelReceptionList };
            request.RequestObject = rl;
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void SaveReceptionList(ReceptionList receptionList)
        {
            Request request = new Request() { Operation = Operation.SaveReceptionList };
            request.RequestObject = receptionList;
            client.SendRequest(request);
            client.GetResponseResult();
        }
        internal List<ReceptionList> SearchReceptionList(string txtSearch)
        {

            Request request = new Request() { Operation = Operation.SearchReceptionList, RequestObject = new ReceptionList { SearchParametar = txtSearch } };
            client.SendRequest(request);

            return (List<ReceptionList>)client.GetResponseResult();
        }
    }
}

using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.IO;
using System.Runtime.Serialization;
using Controller;

namespace Server
{
  public class ClientHandler
    {
        private Socket client;
        private readonly BindingList<User> users;

        private User loggedInUser;
        public ClientHandler(Socket client, System.ComponentModel.BindingList<User> users)
        {
            this.client = client;
            this.users = users;
        }

        public void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(client);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = ProcessRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.IsSuccessful = false;
                        response.Error = ex.Message;
                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("The connection was lost");
                users.Remove(loggedInUser);

            }
            catch (SerializationException)
            {
                Console.WriteLine("The connection was lost");
                users.Remove(loggedInUser);

            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.IsSuccessful = true;
            switch (request.Operation)
            {
                case Operation.Login:
                    response.Result = Controller.Controller.Instance.Login((User)request.RequestObject);
                    if (response.Result == null)
                    {
                        break;
                    }
                    loggedInUser = (User)response.Result;
                    users.Add(loggedInUser);
                    break;
                case Operation.GetAllManufacturers:
                    response.Result = Controller.Controller.Instance.GetAllManufacturers();
                    break;
                case Operation.SaveManufacturer:
                    Controller.Controller.Instance.SaveManufacturer((Manufacturer)request.RequestObject);
                    break;
                case Operation.SaveProduct:
                    Controller.Controller.Instance.SaveProduct((Product)request.RequestObject);
                    break;
                case Operation.GetAllProducts:
                    response.Result = Controller.Controller.Instance.GetAllProducts();
                    break;
                case Operation.SearchProducts:
                   response.Result = Controller.Controller.Instance.SearchProducts((Product)request.RequestObject);
                    if (response.Result == null)
                    {
                        break;
                    }                    
                    break;
                case Operation.EditProduct:
                    Controller.Controller.Instance.EditProduct((Product)request.RequestObject);
                    break;
                case Operation.SavePurchaseOrder:
                    Controller.Controller.Instance.SavePurchaseOrder((PurchaseOrder)request.RequestObject);
                    break;
                case Operation.GetAllPurchaseOrder:
                    response.Result = Controller.Controller.Instance.GetAllPurchaseOrder();
                    break;
                case Operation.SearchPurchaseOrder:
                    response.Result = Controller.Controller.Instance.SearchPurchaseOrder((PurchaseOrder)request.RequestObject);
                    if (response.Result == null)
                    {
                        break;
                    }
                    break;
                case Operation.LoadPurchaseOrderItems:
                    response.Result = Controller.Controller.Instance.LoadPurchaseOrderItems((PurchaseOrder)request.RequestObject);
                    break;
                case Operation.CancelPurchaseOrder:
                    Controller.Controller.Instance.CancelPurchaseOrder((PurchaseOrder)request.RequestObject);
                    break;
                case Operation.SaveReceptionList:
                    Controller.Controller.Instance.SaveReceptionList((ReceptionList)request.RequestObject);
                    break;
                case Operation.GetAllReceptionList:
                    response.Result = Controller.Controller.Instance.GetAllReceptionList();
                    break;
                case Operation.SearchReceptionList:
                    response.Result = Controller.Controller.Instance.SearchReceptionList((ReceptionList)request.RequestObject);
                    if (response.Result == null)
                    {
                        break;
                    }
                    break;
                case Operation.LoadReceptionListItems:
                    response.Result = Controller.Controller.Instance.LoadReceptionListItems((ReceptionList)request.RequestObject);
                    break;
                case Operation.CancelReceptionList:
                    Controller.Controller.Instance.CancelReceptionList((ReceptionList)request.RequestObject);
                    break;
            }
            return response;
        }

        internal void Stop()
        {
            client.Close();
        }
    }
}


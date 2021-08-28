using Domain;
using Storage;
using Storage.Implementation.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using SystemOperations.ManufacturerSO;
using SystemOperations.ProductSO;
using SystemOperations.PurchaseOrder;
using SystemOperations.ReceptionList;
using SystemOperations.UserSO;

namespace Controller
{
    public class Controller
    {
        private IgenericRepository repository;

        public User User { get; set; }


        private static Controller instance;

        private static object _lock = new object();
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }

        private Controller()
        {
            repository = new GenericRepository();
        }

        public User Login(User user)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(user);
            return so.Result;
        }

        public List<Product> GetAllProducts()
        {
            GetAllProductsSO so = new GetAllProductsSO();
            so.ExecuteTemplate(new Product());
            return so.Result;
        }


        public void SaveProduct(Product p)
        {
            AddNewProductSO so = new AddNewProductSO();
            so.ExecuteTemplate(p);
        }

        public List<Product> SearchProducts(Product product)
        {
            SearchProductSO so = new SearchProductSO();
            so.ExecuteTemplate(product);
            return so.Result;
        }

        public void EditProduct(Product product)
        {
            EditProductSO so = new EditProductSO();
            so.ExecuteTemplate(product);
        }

        public void SaveManufacturer(Manufacturer m)
        {
            SystemOperationBase systemOperation = new AddNewManufacturerSO();
            systemOperation.ExecuteTemplate(m);
        }

        public void SavePurchaseOrder(PurchaseOrder po)
        {
            AddNewPurchaseOrderSO systemOperation = new AddNewPurchaseOrderSO();
            systemOperation.ExecuteTemplate(po);

        }

        public List<Manufacturer> GetAllManufacturers()
        {
            GetAllManufacturersSO systemOperation = new GetAllManufacturersSO();
            systemOperation.ExecuteTemplate(new Manufacturer());
            return systemOperation.Result;
        }

        public List<PurchaseOrder> GetAllPurchaseOrder()
        {
            GetAllPurchaseOrderSO systemOperation = new GetAllPurchaseOrderSO();
            systemOperation.ExecuteTemplate(new PurchaseOrder());
            return systemOperation.Result;
        }

        public List<PurchaseOrder> SearchPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            SearchPurchaseOrderSO so = new SearchPurchaseOrderSO();
            so.ExecuteTemplate(purchaseOrder);
            return so.Result;
        }


        public List<PurchaseOrderItem> LoadPurchaseOrderItems(PurchaseOrder purchaseOrder)
        {

            PurchaseOrderItem poi = new PurchaseOrderItem();
            poi.SearchParametar = purchaseOrder.PurchaseOrderId.ToString();
            LoadPurchaseOrderItemsSO systemOperation = new LoadPurchaseOrderItemsSO();
            systemOperation.ExecuteTemplate(poi);
            return systemOperation.Result;
        }

        public void CancelPurchaseOrder(PurchaseOrder purchaseOrder)
        {

            CancelPurchaseOrderSO so = new CancelPurchaseOrderSO();
            so.ExecuteTemplate(purchaseOrder);

        }

        public List<ReceptionListItem> LoadReceptionListItems(ReceptionList receptionList)
        {

            ReceptionListItem rli = new ReceptionListItem();
            rli.SearchParametar = receptionList.ReceptionListId.ToString();
            LoadReceptionListItemsSO systemOperation = new LoadReceptionListItemsSO();
            systemOperation.ExecuteTemplate(rli);
            return systemOperation.Result;
        }
        public List<ReceptionList> GetAllReceptionList()
        {
            GetAllReceptionListSO systemOperation = new GetAllReceptionListSO();
            systemOperation.ExecuteTemplate(new ReceptionList());
            return systemOperation.Result;
        }
        public void CancelReceptionList(ReceptionList receptionList)
        {
            CancelReceptionListSO so = new CancelReceptionListSO();
            so.ExecuteTemplate(receptionList);
        }

        public List<ReceptionList> SearchReceptionList(ReceptionList receptionList)
        {
            SearchReceptionListSO so = new SearchReceptionListSO();
            so.ExecuteTemplate(receptionList);
            return so.Result;
        }

    

        public void SaveReceptionList(ReceptionList receptionList)
        {

            AddNewReceptionListSO systemOperation = new AddNewReceptionListSO();
            systemOperation.ExecuteTemplate(receptionList);
        }
    }
}
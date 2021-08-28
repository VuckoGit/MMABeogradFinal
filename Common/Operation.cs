using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum Operation
    {
        GetAllManufacturers,       
        Login,
        SaveManufacturer,
        GetAllProducts,
        SaveProduct,
        SearchProducts,
        EditProduct,
        SavePurchaseOrder,
        GetAllPurchaseOrder,
        SearchPurchaseOrder,
        LoadPurchaseOrderItems,
        CancelPurchaseOrder,
        LoadReceptionListItems,
        CancelReceptionList,
        SearchReceptionList,
        SaveReceptionList,
        GetAllReceptionList
    }
}

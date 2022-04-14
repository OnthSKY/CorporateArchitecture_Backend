using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Product Messages
        public static string ProductAdded = "Product has added successfully";
        public static string ProductDeleted = "Product has deleted successfully";
        public static string ProductUpdated = "Product has updated successfully";

        //Category Messages

        public static string CategoryAdded = "Category has added successfully";
        public static string CategoryDeleted = "Category has deleted successfully";
        public static string CategoryUpdated = "Category has updated successfully";

        //Customer Messages

        public static string CustomerAdded = "Customer has added successfully";
        public static string CustomerDeleted = "Customer has deleted successfully";
        public static string CustomerUpdated = "Customer has updated successfully";

        //Order Messages

        public static string OrderAdded = "Order has added successfully";
        public static string OrderDeleted = "Order has deleted successfully";
        public static string OrderUpdated = "Order has updated successfully";
        //
        public static string MaintenanceTime = "Server is under maintenance";

        public static string FilteringSuccessful = "Filtering has done successfully";
        public static string ListingSuccessful = "Listing has done successfully";
        public static string ProductCountOfCategory = "Product count has exceeded";
        public static string ProductNameAlreadyExist = "This name is taken ";
        public static string CategoryLimitExceded = "Category limit exceded !";
        public static string AuthorizationDenied = "You don't have an Authorization";
        public static string UserRegistered = "User registering has done successfully";
        public static string UserNotFound = "User not Found";
        public static string PasswordError = "Password is not Correct";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists = "User already Exists";
        public static string AccessTokenCreated = "Token creating has done successfully";
    }
}

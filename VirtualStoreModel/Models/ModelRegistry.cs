using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pisa.Utils.Reflection;

namespace Pisa.VirtualStore.Models
{
    public class ModelRegistry
    {
        IList<Type> _allModelsList = new List<Type>();

        private static readonly ModelRegistry _instance = new ModelRegistry();
        public static ModelRegistry GetInstance() {
            return _instance;
        }

        private ModelRegistry() {
            RegisterNamespaceClasses(typeof(Models.Archived.ArchivedCalculusAppliedOffer).Namespace);
            RegisterNamespaceClasses(typeof(Models.Audit.AuditAuthor).Namespace);
            RegisterNamespaceClasses(typeof(Models.Calculus.CalculusAppliedOffer).Namespace);
            RegisterNamespaceClasses(typeof(Models.Client.ClientBasket).Namespace);
            RegisterNamespaceClasses(typeof(Models.Contact.Contact).Namespace);
            RegisterNamespaceClasses(typeof(Models.General.GeneralMedia).Namespace);
            RegisterNamespaceClasses(typeof(Models.Offer.OfferInfo).Namespace);
            RegisterNamespaceClasses(typeof(Models.Order.OrderInfo).Namespace);
            RegisterNamespaceClasses(typeof(Models.Product.ProductInfo).Namespace);
            RegisterNamespaceClasses(typeof(Models.Security.SecurityAccount).Namespace);
            RegisterNamespaceClasses(typeof(Models.Service.ServiceByStore).Namespace);
            RegisterNamespaceClasses(typeof(Models.Store.StoreInfo).Namespace);
        }

        private void RegisterNamespaceClasses(string nameSpace) {
            IEnumerable<Type> types = TypeUtils.GetTypesFromNamespace(this.GetType().Assembly, nameSpace);
            foreach (Type t in types)
                RegisterModel(t);
        }

        private void RegisterModel(Type modelType)
        {
            if (modelType == null)
                throw new Exception("Unable to register a null model.");

            if (_allModelsList.Contains(modelType))
                throw new Exception("Model of the type " + modelType.Name + " has been already registered.");
            _allModelsList.Add(modelType);
        }

        public IEnumerable<Type> GetAllModels()
        {
            foreach (Type t in _allModelsList)
                yield return t;
        }
    }
}

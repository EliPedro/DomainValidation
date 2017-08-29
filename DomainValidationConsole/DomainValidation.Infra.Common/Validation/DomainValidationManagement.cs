using System.Collections;
using System.Collections.Generic;
using System.Web;

namespace DomainValidation.Infra.Common.Validation
{
    public class DomainValidationManagement
    {
        public static bool HasErros => HttpContext.Current.Items["DomainValidation"] != null;

        public static void Add(DomainValidation newDomainValidation)
        {
            if (HttpContext.Current.Items["DomainValidation"] == null)
                HttpContext.Current.Items["DomainValidation"] = new List<DomainValidation>();

            (HttpContext.Current.Items["DomainValidation"] as List<DomainValidation>).Add(newDomainValidation);
        }

        public static List<DomainValidation> GetAll()
        {
            return (List<DomainValidation>)HttpContext.Current.Items["DomainValidation"];
        }
    }
}

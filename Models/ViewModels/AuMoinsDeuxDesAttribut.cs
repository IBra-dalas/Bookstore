using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace NewResto.Models.ViewModels
{
    public class AuMoinsDeuxDesAttribut 
    {
        public string param1 { get; set; }
        public string param2 { get; set; }
        public string ErrorMessage { get; private set; }

        

       /* protected override ValidationResult sValid(object value, ValidationContext validationContext)
        {
            PropertyInfo[] propertyInfos = validationContext.ObjectType.GetProperties();
            PropertyInfo info1 = propertyInfos.FirstOrDefault(p => p.Name == param1);
            PropertyInfo info2 = propertyInfos.FirstOrDefault(p => p.Name == param2);

            string valeur1 = info1.GetValue(validationContext.ObjectInstance) as string;
            string valeur2 = info2.GetValue(validationContext.ObjectInstance) as string;

            if (string.IsNullOrWhiteSpace(valeur1) && string.IsNullOrWhiteSpace(valeur2))
                return new ValidationResult(ErrorMessage);
            return ValidationResult.Success;
        }
      */

        //public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext content)
        //{
        //    ModelClientValidationRule regle = new ModelClientValidationRule();
        //    regle.ValidationType = "Verifcontact";
        //    regle.ErrorMessage = ErrorMessage;
        //    regle.ValidationParameters.Add("param1", param1);
        //    regle.ValidationParameters.Add("param2", param2);

        //    return new List<ModelClientValidationRule> { regle };
        //}
    }
}

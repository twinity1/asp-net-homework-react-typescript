using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AspHomework2.Extensions
{
    public class ModelStateErrorList
    {
        private List<string> _errors = new List<string>();
        
        //převede errory do 1d listu
        public ModelStateErrorList(ModelStateDictionary modelState)
        {
            var errors = new List<string>();

            foreach (KeyValuePair<string,ModelStateEntry> keyValuePair in modelState)
            {
                foreach (var valueError in keyValuePair.Value.Errors)
                {
                    errors.Add(valueError.ErrorMessage);
                }
            }

            _errors = errors;
        }
        
        public List<string> AsList()
        {
            return _errors;
        }
    }
}
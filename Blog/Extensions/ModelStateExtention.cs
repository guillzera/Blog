using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blog.Extensions
{
    public static class ModelStateExtention
    {
        public static List<string> GetErrors(this ModelStateDictionary modelstate)
        {
            var result = new List<string>();
            foreach (var item in modelstate.Values)
                result.AddRange(item.Errors.Select(x => x.ErrorMessage));
            
            return result;
        }
    }
}

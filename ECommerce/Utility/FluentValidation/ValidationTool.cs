using FluentValidation;

namespace ECommerce.Utility.FluentValidation
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator, Object entity)
        {
            var context = new ValidationContext<Object>(entity);
            var result = validator.Validate(context);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}

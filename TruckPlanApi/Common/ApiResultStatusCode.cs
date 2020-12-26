using System.ComponentModel.DataAnnotations;

namespace Common
{
    public enum ApiResultStatusCode
    {
        [Display(Name = "Mission Accomplished")]
        Success = 0,

        [Display(Name = "Service Error")]
        ServerError = 1,

        [Display(Name = "Bad Request")]
        BadRequest = 2,

        [Display(Name = "Not Found")]
        NotFound = 3,

        [Display(Name = "Empty List")]
        ListEmpty = 4,

        [Display(Name = "Logical Error occured")]
        LogicError = 5,

        [Display(Name = "Un Authorized")]
        UnAuthorized = 6
    }
}

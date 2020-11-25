using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalApi.Controllers
{
    public class UserManagerResponse
    {
        internal IEnumerable<string> Errors;
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
namespace StudentSystem.Web.Controllers
{
    using StudentSystem.Data;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;
    using System.Web.Http;
    
    public class BaseApiController : ApiController
    {
        protected IStudentSystemData data;
        
        public BaseApiController(IStudentSystemData data)
        {
            this.data = data;
        }
    }
}
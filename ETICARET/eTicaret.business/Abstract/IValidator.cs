using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicaret.business.Abstract
{
    public interface IValidator<T>
    {
        string ErrorMessage{get;set;}
        bool Validation(T entity);
    }
}
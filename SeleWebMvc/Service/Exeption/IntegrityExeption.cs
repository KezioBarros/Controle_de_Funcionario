using System;

namespace SeleWebMvc.Service.Exeption
{
    public class IntegrityExeption : ApplicationException
    {
        public IntegrityExeption(string message) : base(message)
        {

        }
    }
}

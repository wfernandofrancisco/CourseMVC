using System;

namespace CourseMVC.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message): base(message)
        {
        }


    }
}

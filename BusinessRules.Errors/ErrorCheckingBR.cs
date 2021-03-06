﻿using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.Errors
{
    public abstract class ErrorCheckingBR
    {
        public bool IsDescriptionEmpty(string descr)
        {
            List<string> listOfHtmlTags = new List<string> 
            { 
                "<!DOCTYPE html>\r\n",
                "<html>\r\n",
                "<head>\r\n",
                "</head>\r\n",
                "<body>\r\n\r\n",
                "</body>\r\n",
                "</html>"
            };

            foreach (var item in listOfHtmlTags)
                descr = descr.Replace(item, string.Empty);

            return string.IsNullOrEmpty(descr);
        }
    }
}

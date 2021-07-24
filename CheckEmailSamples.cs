﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY_19_UserRegistration
{
   public  class CheckEmailSamples
    {
        
        
            public static string Regex_SampleEmails = "^[A-Za-z]+([-.+#^*][0-9]+)?[0-9]*[@][A-Za-z0-9]+[.][A-Za-z]{2,}([.][a-zA-Z]{2,})?$";

            public static bool ValidateEmail(string SampleEmail)
            {
                return Regex.IsMatch(SampleEmail, Regex_SampleEmails);
            }
        }
    }


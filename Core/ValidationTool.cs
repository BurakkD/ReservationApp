﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                Console.WriteLine("İşlem Başarısız");
            }
            else
            {
                Console.WriteLine("İşlem Başarılı");
            }
        }
    }
}
using System;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DotNetCore3Sample.Client.Pages
{
    public class Example2Model : ComponentBase
    {
        protected ValidationParams param = new ValidationParams();

        private static readonly Dictionary<int, string> DefaultOptionValues = new Dictionary<int, string>(
            new Dictionary<int, string>()
            {
                {0, "Tarou"},
                {1, "Hanako"},
                {2, "Franky"}
            });


        protected Dictionary<int, string> OptionValues = new Dictionary<int, string>(DefaultOptionValues);


        protected void AddOptionValue(string name)
        {
            if (string.IsNullOrEmpty(name))
                return;

            OptionValues.Add(OptionValues.Count, name);
        }

        protected async Task HandleInvalid()
        {
            Console.WriteLine("OnHandleInvalid()");
            // Initilize OptionValues and param.name
            await Task.Run(() => {
                OptionValues = new Dictionary<int, string>(DefaultOptionValues);
                param.name = null;
            });
        }
    }

    public class ValidationParams
    {
        [Required(ErrorMessage = "You need select a Name.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Name must be in 4-100 length.")]
        public string name { get; set; }
    }
}
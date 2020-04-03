using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ROSESHIELD.WEB.Pages
{
    public class IndexModel : PageModel
    {
        public class Salvar {
            public string firstname { get; set; }
        }
                    

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(Salvar entity)
        {

        }
    }
}

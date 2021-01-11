using MessageStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MessageStore.Controllers
{
    public class HomeController : Controller
    {
        private static List<Message> _messages = new List<Message>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
                
        public IActionResult Send(Message message)
        {
            if (message != null && !string.IsNullOrEmpty(message?.Text))
            {
                message.Date = DateTime.Now;
                _messages.Add(message);
            }
            return View();
        }

        public IActionResult GetMessages()
        {            
            return View(_messages.OrderByDescending(_ => _.Date).Take(5).ToList());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApiJsonData.Models.SampleApp.Models;

namespace WebApiJsonData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {

        private readonly Opciones _options;

        /// <summary>
        ///There are several ways to achieve this. You can:
        ///  Inject an IOptions<T> instance and cast it to IOptionsSnapshot<T>.
        ///  OptionsManager<T> as a Singleton in the DI container, and inject it directly.
        ///  Use IOptionsMonitor<T>. Be aware that if the underlying configuration changes, the singleton objects will change too.
        /// </summary>
        /// <param name="optionsAccessor"></param>
        /// <param name="optAccesor"></param>
        public InfoController(IOptionsMonitor<Opciones> optionsAccessor, IOptionsMonitor<Conexiones> optAccesor)
        {
            _options = optionsAccessor.CurrentValue;
            _options.conexiones = optAccesor.CurrentValue;
        }

        // GET: api/Info
        [HttpGet]
        //public IEnumerable<string> Get()
        public Opciones Get()
        {
            //return new string[] { _options.Option1, _options.Option2.ToString() };
            return _options;
        }

        // GET: api/Info/5
        [HttpGet("opcion2", Name = "Get")]
        public string GetOpcion2() {

            var valor1 = _options.Option2;
            return valor1.ToString();
        }


    }
}

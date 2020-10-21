using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ASPNETWEBAPP.Models;
using ASPNETWEBAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETWEBAPP.Controllers
{
    public class ContentController : BaseController
    {

        private ProductService productService;

        public ContentController(ProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult GetXml()
        {
            MemoryStream stream = new MemoryStream();
            XmlSerializer sr = new XmlSerializer(typeof(List<Product>));
            sr.Serialize(stream, productService.GetProducts());
            stream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(stream, "text/xml");
        }
        public IActionResult GetJson()
        {
            return new JsonResult(productService.GetProducts());
        }
    }
}

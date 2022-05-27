using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreArf.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net.Http;

namespace DevExtremeAspNetCoreArf.Controllers.ApiControllers
{

	[Route("api/[controller]/[action]")]
    public class GeoNamesController : Controller
    {
        [HttpGet]
        public object Countries(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.Countries, loadOptions);
        }

        [HttpGet]
        public object Cities(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.Cities, loadOptions);
        }

        [HttpGet]
        public object Opportunitys(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.Opportunitys, loadOptions);
        }

        [HttpGet]
        public object ProcessTypes(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.ProcessTypes, loadOptions);
        }
    }
}
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreArf.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevExtremeAspNetCoreArf.Controllers.ApiControllers
{

    [Route("api/[controller]/[action]")]
    public class DataSourceController : Controller
    {
        [HttpGet]
        public object Countries(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(DataSource.Countries, loadOptions);
        }

        [HttpGet]
        public object Opportunitys(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(DataSource.Opportunitys, loadOptions);
        }

        [HttpGet]
        public object ProcessTypes(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(DataSource.ProcessTypes, loadOptions);
        }

        [HttpGet]
        public object Lasers(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(DataSource.Lasers, loadOptions);
        }

        [HttpGet]
        public object Wavelengths(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(DataSource.Wavelengths, loadOptions);
        }

        [HttpGet]
        public object ProcessGases(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(DataSource.ProcessGases, loadOptions);
        }

        [HttpGet]
        public object Rates1To5(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(DataSource.Rates1To5, loadOptions);
        }        
        
        [HttpGet]
        public object Languages(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(DataSource.Languages, loadOptions);
        }
    }
}
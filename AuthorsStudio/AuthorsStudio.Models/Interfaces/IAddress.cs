using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public interface IAddress
    {
        Guid AddressId { get; }

        string FlatNumberOrName { get; set; }

        string BuildingNumberOrName { get; set; }

        string StreetName { get; set; }

        string TownOrCityName { get; set; }

        string RegionName { get; set; }

        string Postcode { get; set; }

        string FullAddress { get; set; }     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public class Address : IAddress
    {
        #region Private Properties

        private Guid _addressId;
        private string _buildingNumberOrName;
        private string _flatNumberOrName;
        private string _postcode;
        private string _regionName;
        private string _streetName;
        private string _townOrCityName;

        #endregion

        #region Public Properties

        public Guid AddressId
        {
            get { return _addressId; }
        }

        public string BuildingNumberOrName
        {
            get { return _buildingNumberOrName; }
            set { _buildingNumberOrName = value; }
        }

        public string FlatNumberOrName
        {
            get { return _flatNumberOrName; }
            set { _flatNumberOrName = value; }
        }

        public string FullAddress
        {
            get { return GetFullAddress(); }
        }

        public string Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }

        public string RegionName
        {
            get { return _regionName; }
            set { _regionName = value; }
        }

        public string StreetName
        {
            get { return _streetName; }
            set { _streetName = value; }
        }

        public string TownOrCityName
        {
            get { return _townOrCityName; } 
            set { _townOrCityName = value; }
        }

        #endregion

        #region Constructor

        public Address(Guid addressId, string flatNumberOrName, string buildingNumberOrName, 
            string streetName, string townOrCityName, string regionName, string postcode)
        {
            _addressId = addressId;
            _flatNumberOrName = flatNumberOrName;
            _buildingNumberOrName = buildingNumberOrName;
            _streetName = streetName;
            _townOrCityName = townOrCityName;
            _regionName = regionName;
            _postcode = postcode;
        }

        #endregion

        #region Private Methods

        private string GetFullAddress()
        {
            StringBuilder sbFullAddress = new StringBuilder();

            if (!String.IsNullOrEmpty(_flatNumberOrName))
            {
                sbFullAddress.Append(_flatNumberOrName);
                sbFullAddress.Append(", ");
            }

            if (!String.IsNullOrEmpty(_buildingNumberOrName))
            {
                sbFullAddress.Append(_buildingNumberOrName);
                sbFullAddress.Append(Environment.NewLine);
            }

            if (!String.IsNullOrEmpty(_streetName))
            {
                sbFullAddress.Append(_streetName);
                sbFullAddress.Append(Environment.NewLine);
            }

            if (!String.IsNullOrEmpty(_townOrCityName))
            {
                sbFullAddress.Append(_townOrCityName);
                sbFullAddress.Append(Environment.NewLine);
            }

            if (!String.IsNullOrEmpty(_regionName))
            {
                sbFullAddress.Append(_regionName);
                sbFullAddress.Append(Environment.NewLine);
            }

            if (!String.IsNullOrEmpty(_postcode))
            {
                sbFullAddress.Append(_postcode);
            }

            return sbFullAddress.ToString();
        }

        #endregion

        #region Public Methods

        public void SetAddress(string buildingNumberOrName, string streetName, string townOrCityName, 
            string regionName, string postcode)
        {
            SetAddress(null, buildingNumberOrName, streetName, townOrCityName, regionName, postcode);
        }

        public void SetAddress(string flatNumberOrName, string buildingNumberOrName, string streetName, 
            string townOrCityName, string regionName, string postcode)
        {
            _flatNumberOrName = flatNumberOrName;
            _buildingNumberOrName = buildingNumberOrName;
            _streetName = streetName;
            _townOrCityName = townOrCityName;
            _regionName = regionName;
            _postcode = postcode;
        }

        #endregion

        #region Public Static Methods

        public static IAddress CreateNewAddress(string flatNumberOrName, string buildingNumberOrName,
            string streetName, string townOrCityName, string regionName, string postcode)
        {
            return new Address(Guid.NewGuid(), flatNumberOrName, buildingNumberOrName, streetName, townOrCityName, regionName, postcode);
        }

        #endregion
    }
}

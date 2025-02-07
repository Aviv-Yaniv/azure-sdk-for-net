// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Datacenter address for given storage location. </summary>
    public partial class DatacenterAddressLocationResponse : DatacenterAddressResponse
    {
        /// <summary> Initializes a new instance of DatacenterAddressLocationResponse. </summary>
        internal DatacenterAddressLocationResponse()
        {
            DatacenterAddressType = DatacenterAddressType.DatacenterAddressLocation;
        }

        /// <summary> Initializes a new instance of DatacenterAddressLocationResponse. </summary>
        /// <param name="datacenterAddressType"> Data center address type. </param>
        /// <param name="supportedCarriersForReturnShipment"> List of supported carriers for return shipment. </param>
        /// <param name="dataCenterAzureLocation"> Azure Location where the Data Center serves primarily. </param>
        /// <param name="contactPersonName"> Contact person name. </param>
        /// <param name="company"> Company name. </param>
        /// <param name="street1"> Street address line 1. </param>
        /// <param name="street2"> Street address line 2. </param>
        /// <param name="street3"> Street address line 3. </param>
        /// <param name="city"> City name. </param>
        /// <param name="state"> name of the state. </param>
        /// <param name="zip"> Zip code. </param>
        /// <param name="country"> name of the country. </param>
        /// <param name="phone"> Phone number. </param>
        /// <param name="phoneExtension"> Phone extension. </param>
        /// <param name="addressType"> Address type. </param>
        /// <param name="additionalShippingInformation"> Special instruction for shipping. </param>
        internal DatacenterAddressLocationResponse(DatacenterAddressType datacenterAddressType, IReadOnlyList<string> supportedCarriersForReturnShipment, string dataCenterAzureLocation, string contactPersonName, string company, string street1, string street2, string street3, string city, string state, string zip, string country, string phone, string phoneExtension, string addressType, string additionalShippingInformation) : base(datacenterAddressType, supportedCarriersForReturnShipment, dataCenterAzureLocation)
        {
            ContactPersonName = contactPersonName;
            Company = company;
            Street1 = street1;
            Street2 = street2;
            Street3 = street3;
            City = city;
            State = state;
            Zip = zip;
            Country = country;
            Phone = phone;
            PhoneExtension = phoneExtension;
            AddressType = addressType;
            AdditionalShippingInformation = additionalShippingInformation;
            DatacenterAddressType = datacenterAddressType;
        }

        /// <summary> Contact person name. </summary>
        public string ContactPersonName { get; }
        /// <summary> Company name. </summary>
        public string Company { get; }
        /// <summary> Street address line 1. </summary>
        public string Street1 { get; }
        /// <summary> Street address line 2. </summary>
        public string Street2 { get; }
        /// <summary> Street address line 3. </summary>
        public string Street3 { get; }
        /// <summary> City name. </summary>
        public string City { get; }
        /// <summary> name of the state. </summary>
        public string State { get; }
        /// <summary> Zip code. </summary>
        public string Zip { get; }
        /// <summary> name of the country. </summary>
        public string Country { get; }
        /// <summary> Phone number. </summary>
        public string Phone { get; }
        /// <summary> Phone extension. </summary>
        public string PhoneExtension { get; }
        /// <summary> Address type. </summary>
        public string AddressType { get; }
        /// <summary> Special instruction for shipping. </summary>
        public string AdditionalShippingInformation { get; }
    }
}

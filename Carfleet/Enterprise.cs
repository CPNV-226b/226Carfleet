using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Carfleet
{
    public class Enterprise
    {
        #region private attributes
        private string _name;
        private string _street;
        private string _city;
        private string _phonenumber;
        private string _emailaddress;
        private List<Vehicle> _vehicles = new List<Vehicle>();
        private List<Driver> _drivers = new List<Driver>();
        #endregion private attributes

        #region public methods
        public Enterprise(string name, string street, string city, string phonenumber, string emailaddress)
        {
            _name = name;
            _street = street;
            _city = city;
            _phonenumber = phonenumber;
            _emailaddress = emailaddress;
        }

        public void Add(Vehicle vehicleToAdd)
        {
            throw new NotImplementedException();
        }

        public void Add(Driver driver)
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicleByChassisNumber(string chassisNumber) 
        {
            throw new NotImplementedException();
        }

        public Driver GetDriverByEmailaddress(string driverEmailaddress)
        {
            throw new NotImplementedException();
        }

        public void AssignVehicleToDriver(string chassisNumber, string driverEmailaddress)
        {
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}

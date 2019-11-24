using System;
namespace CS313_BeautyParlorManagementSystem
{
    public class Service
    {
        private string serviceName, serviceType;
        private Staff staffMem;
        private double servicePrice;

        public Service(string name, string type, double price, Staff member)
        {
            ServiceName = name;
            ServiceType = type;
            ServicePrice = price;
            StaffMem = member;
        }

        public string ServiceType
        {
            get
            {
                return serviceType;
            }

            private set
            {
                if (value.Equals("Hair") || value.Equals("Nails"))
                    serviceType = value;

            }
        }

        public string ServiceName { get; private set; }
        public double ServicePrice { get; private set; }
        public Staff StaffMem { get; set; }

        public double serviceTotalPrice()
        {

            return ServicePrice + StaffMem.Tip;
        }
    }
}

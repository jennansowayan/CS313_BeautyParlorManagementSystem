using System;
namespace CS313_BeautyParlorManagementSystem
{
    public class Service
    {
        private string serviceName, serviceType;
        private Staff staffMem;
        private double servicePrice;

        public Service()
        {
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
        internal Staff StaffMem { get => staffMem; set => staffMem = value; }

        public double serviceTotalPrice() {
            
            return ServicePrice + StaffMem.Tip;
        }
    }
}

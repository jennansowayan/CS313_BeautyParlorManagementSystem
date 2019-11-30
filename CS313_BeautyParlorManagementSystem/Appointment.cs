using System;
namespace CS313_BeautyParlorManagementSystem
{
    public class Appointment
    {
		private DateTime DT;
		private int numOfappointment;
		private customer appCustomer;
		private staff Stylist;
		private Salon appSalon;
		private Service appservice;


		public appointment(DateTime dt, int Numopp, customer NOC,
						   staff NOStylest, Salon NOSalon, Service TOServicee)
		{
			DT = dt;
			NumOfappointment = Numopp;
			AppCustomer = NOC;
			Stylist = NOStylest;
			appSalo = NOSalon;
			Appservice = TOServicee;
		}
		public DateTime dt
		{
			get
			{
				return DT;
			}
			set => DT = DateTime.Now;
		}

		public customer AppCustomer { get => appCustomer; set => appCustomer = value; }
		public staff Stylist { get => Stylist; set => Stylist = value; }
		public Salon AppSalon { get => appSalon; set => appSalon = value; }
		public Service Appservice { get => appservice; set => appservice = value; }
	}
}

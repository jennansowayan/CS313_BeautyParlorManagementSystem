using System;
namespace CS313_BeautyParlorManagementSystem

{
    abstract class user
    {
        public string UserName
        {
            get;
            private set;
        }
        public string password
        {
            get;
            private set;
        }
        public user(string UserName, string password)
        {
            this.UserName = UserName;
            this.password = password;
        }
        public abstract string identified();

        //class manager.
        public class manager : user
        {
            public string fristName
            {
                get;
                private set;
            }
            public string LastName
            {
                get;
                private set;
            }
            public string SalonWork
            {
                get;
                private set;
            }
            public manager(string fristname, string Lastname, string SalonWork, string UserName, string password)
                : base(UserName, password)
            {
                this.LastName = LastName;
                this.fristName = fristName;
                this.SalonWork = SalonWork;
            }
            public override string identified(){
{
             throw new NotImplementedException();
}
           
            }
            // class staff
            public class staff : user
            {
                public string fristName
            {
                get;
                private set;
            }
            public string LastName
            {
                get;
                private set;
            }
            public string SalonWork
            {
                get;
                private set;
            }
            public string StaffMem
            {
                get;
                private set;
            }
            public string Service
            {
                get;
                private set;
            }
            public staff(string firstName, string LastName, string SalonWork, string StaffMem, string Service
                , string UserName, string password)
                : base(UserName, password)
            {
                this.fristName = fristName;
                this.LastName = LastName;
                this.SalonWork = SalonWork;
                this.StaffMem = StaffMem;
                this.Service = Service;
            }
            public override string identified()
            {
                throw new NotImplementedException();
            }
            }
            //class customer
            public class customer : user
            {
                    public string fristName
                    {
                        get;
                        private set;
                    }
                    public string LastName
                    {
                        get;
                        private set;
                    }
                    public string PhoneNum
                    {
                        get;
                        private set;
                    }
                    public customer(string fristname, string Lastname, string PhoneNum, string UserName, string password)
                        : base(UserName, password)
                    {
                        this.LastName = LastName;
                        this.fristName = fristName;
                        this.PhoneNum = PhoneNum;
                    }
                    public override string identified()
                    {
                        {
                            throw new NotImplementedException();
                        }
                    }
            }
            static void Main(string[] args)
            {
            }
        }
    }
    }

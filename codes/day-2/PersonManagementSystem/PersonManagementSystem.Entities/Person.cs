using System;

namespace PersonManagementSystem.Entities
{
    public class Person
    {
        //string _NameFiled;
        //string _EmailField;
        //long _MobileNumnerField;
        //string _LocationField;

        #region Constructors
        public Person()
        {

        }

        public Person(string personName, string email, long mobile, string place)
        {
            this.Name = Name;
            this.MobileNumber = mobile;
            this.Location = place;
            this.EmailId = email;
        }
        #endregion

        #region Auto-implemented Properties
        public string Name
        {
            set;
            get;
        }

        /**
         *  public string Name
        {
            set =>_NameField = value;
            get => _NameFiled;
        }
         */
        public long MobileNumber
        {
            get;
            set;
        }

        public string EmailId
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }
        #endregion

        #region Methods
        public string GetInformation()
        {
            return this.Name + " " + this.Location;
        }
        #endregion
    }
}

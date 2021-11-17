using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueValueCollection
{
    class Employee : IComparable<Employee>
    {
        #region Data Members
        private int _id;
        private string _name;
        private decimal _basicPay;
        private decimal _daPay;
        private decimal _hraPay;
        private decimal _totalSalary;
        #endregion

        #region Constructor
        public Employee() { }

        public Employee(int id, string name, decimal basicPay, decimal daPay, decimal hraPay)
        {
            _id = id;
            _name = name;
            _basicPay = basicPay;
            _daPay = daPay;
            _hraPay = hraPay;
        }
        #endregion

        #region Properties       

        public decimal TotalSalary
        {
            get { return _totalSalary; }
            protected set { _totalSalary = value; }
        }

        public decimal HraPay
        {
            get { return _hraPay; }
            set { _hraPay = value; }
        }

        public decimal DaPay
        {
            get { return _daPay; }
            set { _daPay = value; }
        }

        public decimal BasicPay
        {
            get { return _basicPay; }
            set { _basicPay = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        #region Methods
        public void CalculateSalary()
        {
            this._totalSalary = this._basicPay + this._daPay + this._hraPay;
        }
        #endregion

        #region Object Method Overrides
        public override bool Equals(object obj)
        {
            if (obj == null)
                throw new NullReferenceException("reference is null");

            if (!(obj is Employee))
                throw new ArgumentException($"not of type {this.GetType().Name}");

            Employee other = obj as Employee;
            if (this == other)
                return true;

            if (!this._id.Equals(other._id))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            const int random = 31;
            return this._id.GetHashCode() * random;
        }

        public override string ToString()
        {
            return $"{this._name}, {this._totalSalary}";
        }
        #endregion

        #region Optional: IComparable Interface Implementation
        public int CompareTo(Employee other)
        {
            if (other == null)
            {
                throw new NullReferenceException("reference is null");
            }
            if (this == other)
                return 0;

            return this._id.CompareTo(other._id);
        }
        #endregion
    }
}

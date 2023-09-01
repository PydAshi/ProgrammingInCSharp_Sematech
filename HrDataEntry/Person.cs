using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrDataEntry
{
    public class Person
    {

        private string _FirstName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
                if (_FirstName.Trim().Length <= 1)
                {
                    throw new ArgumentException("لطفا نام را بصورت صحیح وارد کنید.");
                }
            }
        }


        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;

            }
        }

        private string _MobileNumber;
        public string MobileNumber
        {
            get
            {
                return _MobileNumber;
            }
            set
            {
                _MobileNumber = value;

                if (_MobileNumber.Trim().Substring(0, 3) == "+98")
                {
                    _MobileNumber = _MobileNumber.Replace("+98", "0");
                }
                else if (_MobileNumber.Trim().Substring(0, 1) != "0")
                {
                    _MobileNumber = "0" + _MobileNumber;

                }

                //else if (_MobileNumber.Trim().Length<10)
                //{
                //    throw new Exception("شماره تلفن همراه وارد شده صحیح نمی باشد.");

                //}


            }
        }
  

        private string _NationalCode;
        public string NationalCode
        {
            get
            {
                return _NationalCode;
            }
            set
            {
                _NationalCode = value;

                //if (_NationalCode.Trim().Length!=10)
                //{
                //    throw new ArgumentException("کد ملی باید 10 رقمی باشد.");

                //}


            }
        }


        private bool _Sex;
        public bool Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                _Sex = value;


            }
        }
    }







    }



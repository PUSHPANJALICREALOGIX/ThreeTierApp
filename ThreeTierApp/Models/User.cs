﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreeTierApp.Models
{
    public class User
    {
        private int _Id;
        private string _Name;



        private string _Address;



        private string _EmailID;



        private string _Mobilenumber;



        // Get and set values


        public int Id

        {

            get

            {

                return _Id;

            }

            set

            {

                _Id = value;

            }

        }

        public string Name

        {

            get

            {

                return _Name;

            }

            set

            {

                _Name = value;

            }

        }

        public string address

        {

            get

            {

                return _Address;

            }



            set

            {

                _Address = value;

            }

        }



        public string EmailID

        {

            get

            {

                return _EmailID;

            }



            set

            {

                _EmailID = value;

            }

        }



        public string Mobilenumber

        {



            get

            {

                return _Mobilenumber;

            }

            set

            {

                _Mobilenumber = value;

            }

        }
    }
}
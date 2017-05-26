using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ParkingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        
        // Product ID
        static string Product = "1111";
        public static string ProductID
        {
            get
            {
                return Product;

            }
            set
            {
                Product = value;
            }
        }

        // For connection string

        
      //static string Connection = " Data Source=208.91.198.196;Initial Catalog=ParkingProject;Persist Security Info=True;User ID=ParkingProject; Password=someshpathak ";
      // static string Connection = "Data Source=ROHIT-7X;Initial Catalog=ParkingProject;Integrated Security=True;Pooling=False";
      
       static string Connection = "Data Source=GHOST-MACHINE;Initial Catalog=ParkingProject;Integrated Security=True;Pooling=False";
        public static string ConnectionString
        {
            get
            {
                return Connection;

            }
            set
            {
                Connection= value;
            }
        }

        //For controlling user in login
        static bool accessControl = false;
        public static bool AccessControl
        {
            get
            {
                return accessControl;

            }
            set
            {
                accessControl = value;
            }
        }

        //For controlling user actions
        static bool userAccessControl = false;
        public static bool UserAccessControl
        {
            get
            {
                return userAccessControl;

            }
            set
            {
                userAccessControl = value;
            }
        }

        //For controlling admin actions
        static bool adminAccessControl = false;
        public static bool AdminAccessControl
        {
            get
            {
                return adminAccessControl;

            }
            set
            {
                adminAccessControl = value;
            }
        }

        //Location
        static string Locate;
        public static string Location
        {
            get
            {
                return Locate;

            }
            set
            {
                Locate = value;
            }
        }


        static string Mode;
        public static string PaymentMode
        {
            get
            {
                return Mode;

            }
            set
            {
                Mode = value;
            }
        }

        static string User;
        public static string UserName
        {
            get
            {
                return User;

            }
            set
            {
                User = value;
            }
        }

        static bool Flag = false;
        public static bool Lock
        {
            get
            {
                return Flag;

            }
            set
            {
                Flag = value;
            }
        }

        static string ID;
       
        public static string RFID
        {
            get
            {
                return ID;

            }
            set
            {
                ID = value;
            }
        }
    
        static string port;
        public static string PORT
        {
            get
            {
                return port;

            }
            set
            {
                port = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Class_Library
{

    public class clsPart
    {
        internal object Name;

        // private data member for the the properties
        private string mPartType;
        private Int32 mPartID;
        private Boolean mActive;

        public string PartType
            {
                get
                {
                    // return the private data
                    return mPartType;
                }
                set
                {
                    // set the value of the private data member
                    mPartType = value;
                }
            }

            public int PartID
            {
                get
                {
                    // return the private data
                    return mPartID;
                }
                set
                {
                    // set the value of the private data member
                    mPartID = value;
                }
            }

            public bool Active
            {
                get
                {
                    // return the private data
                    return mActive;
                }
                set
                {
                    // set the value of the private data member
                    mActive = value;
                }
            }

        public object PartName { get; internal set; }

        public static implicit operator clsPart(clsCustomer v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator List<object>(clsPart v)
        {
            throw new NotImplementedException();
        }
    }
    }
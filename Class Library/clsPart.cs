namespace Class_Library
{

    public class clsPart
    {
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



        }
    }
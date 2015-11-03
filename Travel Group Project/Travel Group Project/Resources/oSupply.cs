using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Travel_Group_Project.Resources
{
    public class oSupply
    {
        //created an additional class of the supply selector from the already created list to create what is needed.
        //this is also useful in the later half.
        public string name;
        public bool recommendList;

        public oSupply(string suppplyName)
        {
            //constructor built to perform a similar task as the information placed into oEnviroments & oActivity.
            this.name = suppplyName;
            recommendList = false;
        }
    }
}

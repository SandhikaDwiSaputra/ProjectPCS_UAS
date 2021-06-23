using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMasterMerk
{
    public class MasterModel
    {
        private int id;
        private string model_desc;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Model_desc
        {
            get { return model_desc; }
            set { model_desc = value; }
        }


    }
}

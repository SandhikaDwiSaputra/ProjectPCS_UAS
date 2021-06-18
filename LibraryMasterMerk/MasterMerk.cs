using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMasterMerk
{
    public class MasterMerk
    {
        private int id;
        private string merk_desc;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        

        public string Merk_desc
        {
            get
            {
                return merk_desc;
            }
            set
            {
                merk_desc = value;
            }
        }
    }
}

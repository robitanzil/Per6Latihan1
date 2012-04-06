using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Per6Latihan1
{
    class PdaItem
    {
        // PUBLIC
        public string Name { get; set; }
        public string DateTimeCreated { get; set; }
        public string DateTimeLastUpdate { get; set; }

        // PRIVATE 
        private int Age;

        // PROTECTED
        protected int ZipCode;
    }
}

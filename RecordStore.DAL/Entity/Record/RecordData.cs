using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RecordStore.DAL.Entity.Record
{
    public class RecordData
    {
        public string category { get; set; }
        public string keyname { get; set; }
        public string value { get; set; }
        public int status { get; set; }
    }
}

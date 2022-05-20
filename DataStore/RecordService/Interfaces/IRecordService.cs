using RecordStore.DAL.Entity.Record;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.Domain.RecordService.Interfaces
{
    public interface IRecordService
    {
        Task<string> InsertData(RecordData recordData);
    }
}

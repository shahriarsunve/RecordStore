using Microsoft.EntityFrameworkCore;
using RecordStore.DAL;
using RecordStore.DAL.Entity.Record;
using RecordStore.Domain.RecordService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.Domain.RecordService
{
    public class RecordService:IRecordService
    {

        private readonly RDBContext _context;

        public RecordService(RDBContext context)
        {
            _context = context;
        }


        public async Task<string> InsertData(RecordData recordData)
        {
            try
            {

                var data = await _context.RecordDatas.Where(x => x.category == recordData.category && x.keyname == recordData.keyname).AsNoTracking().FirstOrDefaultAsync();

                if(data == null)
                {
                    _context.RecordDatas.Add(recordData);
                }
                else
                {
                    _context.RecordDatas.Update(recordData);
                }

                await _context.SaveChangesAsync();
                return "Saved";
            }
            catch (Exception ex)
            {
                return "Failed";
            }
        }
    }
}

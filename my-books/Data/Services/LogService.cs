using my_books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class LogsService
    {
        private AppDBContext _context;
        public LogsService(AppDBContext context)
        {
            _context = context;
        }

        public List<Log> GetAllLogsFromDB() => _context.Logs.ToList();
    }
}
